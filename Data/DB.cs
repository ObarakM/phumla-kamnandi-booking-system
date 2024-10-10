using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingSystem.Business.Room;

namespace BookingSystem.Data
{
    public class DB
    {
        #region Field Members
        DB2 db2;  // Use DB2 for database interactions
        #endregion

        #region Constructor
        public DB()
        {
            db2 = new DB2(); // Initialize DB2 instance for connection management
        }

        #endregion

        #region CRUD Methods

        // Method to fetch all rooms from the database
        public Collection<Room> getAllRooms()
        {
            Collection<Room> rooms = new Collection<Room>();

            try
            {
                // Use DB2 to fetch rooms data from the database
                string query = "SELECT * FROM Rooms";
                db2.FillDataSet(query, "Rooms");

                // Iterate over the result set in the dataset and populate the collection of rooms
                foreach (DataRow row in db2.dsMain.Tables["Rooms"].Rows)
                {
                    Room room = new Room(
                        Convert.ToInt32(row["roomID"]),
                        Convert.ToInt32(row["hotelID"]),
                        (RoomType)Convert.ToInt32(row["roomType"])
                    );
                    rooms.Add(room);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching the rooms: " + ex.Message);
            }

            return rooms;
        }

        // Method to get free rooms of a given type in a date range
        public Collection<Room> getFreeRoomsByType(Room.RoomType roomType, DateTime checkIn, DateTime checkOut)
        {
            Collection<Room> freeRooms = new Collection<Room>();

            try
            {
                // SQL query to find rooms of the specified type that are free in the date range
                string query = @"
                SELECT r.roomID, r.hotelID, r.dailyRate, r.roomType 
                FROM Rooms r
                LEFT JOIN Bookings b ON r.roomID = b.roomID
                LEFT JOIN Reservations res ON b.reservationID = res.reservationID
                WHERE r.roomType = " + (int)roomType + @"
                AND (
                    b.roomID IS NULL OR 
                    (res.checkIn > '" + checkOut.ToString("yyyy-MM-dd") + @"' 
                    OR res.checkOut < '" + checkIn.ToString("yyyy-MM-dd") + @"')
                )";

                db2.FillDataSet(query, "FreeRooms");

                foreach (DataRow row in db2.dsMain.Tables["FreeRooms"].Rows)
                {
                    Room room = new Room(
                        Convert.ToInt32(row["roomID"]),
                        Convert.ToInt32(row["hotelID"]),
                        (RoomType)Convert.ToInt32(row["roomType"])
                    )
                    {
                        DailyRate = Convert.ToDecimal(row["dailyRate"])
                    };
                    freeRooms.Add(room);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving free rooms: " + ex.Message);
            }

            return freeRooms;
        }

        // Method to get the count of free rooms
        public int getFreeRoomsCount(Room.RoomType roomType, DateTime checkIn, DateTime checkOut)
        {
            return getFreeRoomsByType(roomType, checkIn, checkOut).Count;
        }

        // Method to find a guest by guestID
        public Guest findGuest(int guestID)
        {
            Guest guest = null;

            try
            {
                string query = "SELECT * FROM Guests WHERE guestID = " + guestID;
                db2.FillDataSet(query, "Guests");

                if (db2.dsMain.Tables["Guests"].Rows.Count > 0)
                {
                    DataRow row = db2.dsMain.Tables["Guests"].Rows[0];
                    guest = new Guest(
                        Convert.ToInt32(row["guestID"]),
                        row["name"].ToString(),
                        Convert.ToInt32(row["phone"]),
                        row["email"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while searching for the guest: " + ex.Message);
            }

            return guest;
        }

        // Method to add a new guest
        public int addGuest(string name, int phone, string email)
        {
            int newGuestID = 0;

            try
            {
                // Find the maximum guestID and increment it
                string queryMaxID = "SELECT MAX(guestID) FROM Guests";
                db2.FillDataSet(queryMaxID, "GuestsMaxID");

                if (db2.dsMain.Tables["GuestsMaxID"].Rows.Count > 0 && db2.dsMain.Tables["GuestsMaxID"].Rows[0][0] != DBNull.Value)
                {
                    newGuestID = Convert.ToInt32(db2.dsMain.Tables["GuestsMaxID"].Rows[0][0]) + 1;
                }
                else
                {
                    newGuestID = 1;
                }

                // Directly insert the new guest into the database
                string insertGuestQuery = @"INSERT INTO Guests (guestID, name, phone, email)
                                    VALUES (" + newGuestID + ", '" + name + "', " + phone + ", '" + email + "')";
                int rows = db2.ExecuteNonQuery(insertGuestQuery);  // This method will directly execute the SQL command
                MessageBox.Show("Numer of rows logged: " + rows);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding the guest: " + ex.Message);
            }

            return newGuestID;
        }

        // Method to make a reservation
        public int makeReservation(Reservation reservation)
        {

            if (reservation.Guest == null)
            {
                throw new ArgumentNullException("Guest cannot be null in the reservation.");
            }
            if (reservation.Rooms == null || reservation.Rooms.Count == 0)
            {
                throw new ArgumentException("At least one room must be associated with the reservation.");
            }

            int newReservationID = 0;

            try
            {
                // Find the maximum reservationID and increment it
                string queryMaxID = "SELECT ISNULL(MAX(reservationID), 0) FROM Reservations";
                db2.FillDataSet(queryMaxID, "ReservationsMaxID");

                if (db2.dsMain.Tables["ReservationsMaxID"].Rows.Count > 0)
                {
                    newReservationID = Convert.ToInt32(db2.dsMain.Tables["ReservationsMaxID"].Rows[0][0]) + 1;
                }

                // Directly insert the new reservation into the database
                string insertReservationQuery = "INSERT INTO Reservations (reservationID, guestID, CheckIn, CheckOut, CostOfStay) VALUES (@reservationID, @guestID, @checkIn, @checkOut, @costOfStay)";

                using (SqlCommand cmd = new SqlCommand(insertReservationQuery, db2.cnMain))
                {
                    cmd.Parameters.AddWithValue("@reservationID", newReservationID);
                    cmd.Parameters.AddWithValue("@guestID", reservation.Guest.GuestID);
                    cmd.Parameters.AddWithValue("@checkIn", reservation.CheckIn.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@checkOut", reservation.CheckOut.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@costOfStay", reservation.CostOfStay);

                    db2.cnMain.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Number of reservations added: " + rows);
                    db2.cnMain.Close();
                }


                // Add bookings for each room
                addToBookings(reservation.Rooms, newReservationID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while making the reservation: " + ex.Message);
            }

            return newReservationID;
        }

        // Method to add bookings
        public void addToBookings(Collection<Room> rooms, int reservationID)
        {
            try
            {
                int rows = 0;
                foreach (Room room in rooms)
                {
                    string insertBookingQuery = "INSERT INTO Bookings (bookingID, reservationID, roomID) VALUES (@bookingID, @reservationID, @roomID)";

                    using (SqlCommand cmd = new SqlCommand(insertBookingQuery, db2.cnMain))
                    {
                        // Generate the next booking ID
                        int newBookingID = GetNextBookingID();

                        // Add the parameters
                        cmd.Parameters.AddWithValue("@bookingID", newBookingID);
                        cmd.Parameters.AddWithValue("@reservationID", reservationID);
                        cmd.Parameters.AddWithValue("@roomID", room.RoomID);

                        // Execute the query
                        db2.cnMain.Open();
                        int row = cmd.ExecuteNonQuery();
                        rows += row;
                        db2.cnMain.Close();
                    }
                }

                MessageBox.Show("Number of bookings added: " + rows);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding bookings: " + ex.Message);
            }
        }

        // Method to get the next booking ID
        private int GetNextBookingID()
        {
            int nextBookingID = 0;

            try
            {
                string queryMaxID = "SELECT ISNULL(MAX(bookingID), 0) FROM Bookings";
                db2.FillDataSet(queryMaxID, "BookingsMaxID");

                if (db2.dsMain.Tables["BookingsMaxID"].Rows.Count > 0)
                {
                    nextBookingID = Convert.ToInt32
                    (nextBookingID = Convert.ToInt32(db2.dsMain.Tables["BookingsMaxID"].Rows[0][0]) + 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the next booking ID: " + ex.Message);
            }

            return nextBookingID;
        }

        #endregion
    }
}
