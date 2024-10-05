using BookingSystem.Business;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookingSystem.Business.Room;

namespace BookingSystem.Data
{
    public class DB
    {

        #region Field Members
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        #endregion

        #region Constructor
        public DB()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingDatabase.mdf;Integrated Security=True");
            connection.Open();
        }

        #endregion

        #region CRUD Methods

        // Define method to fetch all rooms belonging to a given hotel (dependent on the hotelID as a foreign key of a room)
        public Collection<Room> getAllRooms()
        {
            Collection<Room> rooms = new Collection<Room>();

            try
            {
                // Define the query to fetch all rooms with reservationID being null (i.e., unreserved rooms)
                string query = "SELECT * FROM Rooms";

                // Initialize the command object with the query and connection
                command = new SqlCommand(query, connection);

                // Execute the query and store the results in a data reader
                dataReader = command.ExecuteReader();

                // Iterate through the result set and populate the collection of rooms
                while (dataReader.Read())
                {
                    Room room = new Room
                    (
                        Convert.ToInt32(dataReader["roomID"]),
                        Convert.ToInt32(dataReader["hotelID"]),
                        dataReader["reservationID"] as int?,
                        (RoomType)Convert.ToInt32(dataReader["roomType"])
                    );

                    rooms.Add(room);
                }

                // Close the reader after reading
                dataReader.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions (you could log it or throw the exception up to the caller)
                Console.WriteLine("An error occurred while fetching the rooms: " + ex.Message);
            }

            return rooms;
        }

        // A method to return a collection of free rooms of the given type at a particular date
        public Collection<Room> getFreeRoomsByType(Room.RoomType roomType, DateTime checkIn, DateTime checkOut)
        {
            Collection<Room> freeRooms = new Collection<Room>(); // Collection to store available rooms

            try
            {
                // SQL query to find rooms of the specified type that are not booked OR booked but available in the given date range
                string query = @"
            SELECT r.roomID, r.hotelID, r.dailyRate, r.roomType 
            FROM Rooms r
            LEFT JOIN Bookings b ON r.roomID = b.roomID
            LEFT JOIN Reservations res ON b.reservationID = res.reservationID
            WHERE r.roomType = @roomType
            AND (
                -- If there's no booking for this room
                b.roomID IS NULL 
                OR 
                -- If room is booked, check if it's free during the specified period
                (res.checkIn > @checkOut OR res.checkOut < @checkIn)
            )";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomType", (int)roomType); // Room type is stored as an int in the DB
                command.Parameters.AddWithValue("@checkIn", checkIn);
                command.Parameters.AddWithValue("@checkOut", checkOut);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Retrieve room details from the query result
                        int roomID = reader.GetInt32(0);
                        int hotelID = reader.GetInt32(1);
                        decimal dailyRate = reader.GetDecimal(2);
                        Room.RoomType type = (Room.RoomType)reader.GetInt32(3);

                        // Create a Room object and add it to the collection
                        Room room = new Room(roomID, hotelID, null, type)
                        {
                            DailyRate = dailyRate
                        };

                        freeRooms.Add(room);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving free rooms: " + ex.Message);
            }

            return freeRooms; // Return the collection of free rooms
        }

        // A method to get the number of free rooms of a certain type
        public int getFreeRoomsCount(Room.RoomType roomType, DateTime checkIn, DateTime checkOut)
        {
            return getFreeRoomsByType(roomType, checkIn, checkOut).Count; // Return the number of free rooms of the given type
        }

        // Method to search for a guest in the DB
        public Guest findGuest(int guestID)
        {
            Guest guest = null;

            try
            {
                // Define the query to search for the guest by guestID
                string query = "SELECT * FROM Guests WHERE guestID = @GuestID";

                // Initialize the command object with the query and connection
                command = new SqlCommand(query, connection);

                // Add parameter to avoid SQL injection
                command.Parameters.AddWithValue("@GuestID", guestID);

                // Execute the query and store the result in a data reader
                dataReader = command.ExecuteReader();

                // Check if any record is found
                if (dataReader.Read())
                {
                    // Create a new Guest object and populate it with data from the database
                    guest = new Guest
                    (
                        Convert.ToInt32(dataReader["guestID"]),
                        dataReader["name"].ToString(),
                        Convert.ToInt32(dataReader["phone"]),
                        dataReader["email"].ToString()
                    );
                }

                // Close the reader after reading
                dataReader.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions (you could log it or throw the exception up to the caller)
                Console.WriteLine("An error occurred while searching for the guest: " + ex.Message);
            }

            return guest; // Return the found guest or null if not found
        }

        // Define a method to add a new guest to the Guests table in the DB and return the generated guestID
        public int addGuest(string name, int phone, string email)
        {
            int newGuestID = 0;

            try
            {
                // Step 1: Find the biggest guestID in the Guests table
                string queryMaxID = "SELECT MAX(guestID) FROM Guests";

                // Initialize the command to find the maximum guestID
                command = new SqlCommand(queryMaxID, connection);

                // Execute the query and get the result
                object result = command.ExecuteScalar();

                // If no guests are in the table (result is DBNull), start with guestID = 1
                if (result != DBNull.Value)
                {
                    newGuestID = Convert.ToInt32(result) + 1;
                }
                else
                {
                    newGuestID = 1; // First guest if table is empty
                }

                // Step 2: Insert the new guest into the Guests table
                string insertQuery = "INSERT INTO Guests (guestID, name, phone, email) VALUES (@GuestID, @Name, @Phone, @Email)";

                // Initialize the command for the insert operation
                command = new SqlCommand(insertQuery, connection);

                // Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@GuestID", newGuestID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", email);

                // Execute the insert query
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle any exceptions (you could log it or throw the exception up to the caller)
                Console.WriteLine("An error occurred while adding the guest: " + ex.Message);
            }

            // Return the newly generated guestID
            return newGuestID;
        }

        // A method to generate a reservationID, make a reservation object, reserve the rooms given, and return the reservation
        public int makeReservation(Reservation reservation)
        {
            int newReservationID = 0;
            SqlTransaction transaction = null;

            try
            {
                // Start a transaction to ensure all changes happen together
                transaction = connection.BeginTransaction();

                // 1. Generate reservationID by finding the MAX(reservationID) in the Reservations table
                string getMaxIDQuery = "SELECT ISNULL(MAX(reservationID), 0) FROM Reservations";
                SqlCommand getMaxIDCommand = new SqlCommand(getMaxIDQuery, connection, transaction);
                newReservationID = Convert.ToInt32(getMaxIDCommand.ExecuteScalar()) + 1;

                // Set the reservationID of the provided reservation object
                reservation.ReservationID = newReservationID;

                // 2. Insert the new reservation row into the Reservations table
                string insertReservationQuery = @"INSERT INTO Reservations (reservationID, guestID, checkIn, checkOut, CostOfStay) VALUES (@reservationID, @guestID, @checkIn, @checkOut, @costOfStay)";
                SqlCommand insertReservationCommand = new SqlCommand(insertReservationQuery, connection, transaction);
                insertReservationCommand.Parameters.AddWithValue("@reservationID", newReservationID);
                insertReservationCommand.Parameters.AddWithValue("@guestID", reservation.Guest.GuestID);
                insertReservationCommand.Parameters.AddWithValue("@checkIn", reservation.CheckIn);
                insertReservationCommand.Parameters.AddWithValue("@checkOut", reservation.CheckOut);
                insertReservationCommand.Parameters.AddWithValue("@costOfStay", reservation.CostOfStay);
                insertReservationCommand.ExecuteNonQuery();

                // 3. Add the bookings for each room to the Bookings table using the addToBookings() method
                addToBookings(reservation.Rooms, newReservationID, transaction);

                // Commit transaction if everything succeeded
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Rollback transaction if any error occurred
                transaction?.Rollback();
                throw new Exception("An error occurred while making the reservation: " + ex.Message);
            }

            return newReservationID; // Return the new reservationID
        }


        // A method to add a booking to the Bookings table
        public void addToBookings(Collection<Room> rooms, int newReservationID, SqlTransaction transaction)
        {
            try
            {
                // Generate the next bookingID by finding the MAX(bookingID) in the Bookings table
                string getMaxBookingIDQuery = "SELECT ISNULL(MAX(bookingID), 0) FROM Bookings";
                SqlCommand getMaxBookingIDCommand = new SqlCommand(getMaxBookingIDQuery, connection, transaction); // Pass the transaction
                int nextBookingID = Convert.ToInt32(getMaxBookingIDCommand.ExecuteScalar()) + 1;

                // For each room, insert a new row in the Bookings table
                foreach (Room room in rooms)
                {
                    // Prepare the SQL query to insert the booking record
                    string insertBookingQuery = "INSERT INTO Bookings (bookingID, reservationID, roomID) VALUES (@bookingID, @reservationID, @roomID)";
                    SqlCommand insertBookingCommand = new SqlCommand(insertBookingQuery, connection, transaction); // Pass the transaction

                    // Set the parameters for bookingID, reservationID, and roomID
                    insertBookingCommand.Parameters.AddWithValue("@bookingID", nextBookingID);
                    insertBookingCommand.Parameters.AddWithValue("@reservationID", newReservationID);
                    insertBookingCommand.Parameters.AddWithValue("@roomID", room.RoomID);

                    // Execute the query to insert the booking
                    insertBookingCommand.ExecuteNonQuery();

                    // Increment the bookingID for the next room
                    nextBookingID++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding bookings: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }



        // Define a method to fetch all guests in the DB


        // Define a method to fetch all rooms (this infor will be used by form to create rooms - ONLY when reservationID is null, room CAN be reserved)
        // Define a method to update reservationID of a room if it becomes reserved


        // Define a method to fetch all reservations made (Store the reservations in a collection on the form)

        // Define method to add a reservation (first create a reservation object and then store it when done)

        // Define a method to modify a reservation (first modfy the reservation as an object - and use its details to Update)

        #endregion
    }
}
