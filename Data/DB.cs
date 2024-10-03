using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
