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
        public Collection<Room> GetAllRooms()
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
                        Convert.ToInt32(dataReader["reservationID"]),
                        Convert.ToDecimal(dataReader["dailyRate"]),
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

        public int getFreeRoomsCount(RoomType roomType)
        {
            int freeRoomsCount = 0;

            try
            {
                // Define the query to count rooms of the specific type that have null in ReservationID
                string query = "SELECT COUNT(*) FROM Rooms WHERE RoomType = @RoomType AND ReservationID IS NULL";

                // Initialize the command object with the query and connection
                command = new SqlCommand(query, connection);

                // Add parameter to avoid SQL injection (RoomType is an enum, cast it to int)
                command.Parameters.AddWithValue("@RoomType", (int)roomType);

                // Execute the query and get the count result
                freeRoomsCount = (int)command.ExecuteScalar(); // ExecuteScalar returns a single value (the count)
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("An error occurred while counting free rooms: " + ex.Message);
            }

            return freeRoomsCount; // Return the number of free rooms of the given type
        }



        // Define a method to fetch all guests in the DB

        // Define a method to add a new guest to the Guests table in the DB


        // Define a method to fetch all rooms (this infor will be used by form to create rooms - ONLY when reservationID is null, room CAN be reserved)
        // Define a method to update reservationID of a room if it becomes reserved


        // Define a method to fetch all reservations made (Store the reservations in a collection on the form)

        // Define method to add a reservation (first create a reservation object and then store it when done)

        // Define a method to modify a reservation (first modfy the reservation as an object - and use its details to Update)

        #endregion
    }
}
