using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                // Insert the new guest into the dataset
                DataRow newRow = db2.dsMain.Tables["Guests"].NewRow();
                newRow["guestID"] = newGuestID;
                newRow["name"] = name;
                newRow["phone"] = phone;
                newRow["email"] = email;
                db2.dsMain.Tables["Guests"].Rows.Add(newRow);

                // Update the data source
                string insertQuery = "SELECT * FROM Guests"; // Use a query to refresh the dataset after insertion
                db2.UpdateDataSource(insertQuery, "Guests");
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

                // Insert the new reservation into the dataset
                DataRow newRow = db2.dsMain.Tables["Reservations"].NewRow();
                newRow["reservationID"] = newReservationID;
                newRow["guestID"] = reservation.Guest.GuestID;
                newRow["checkIn"] = reservation.CheckIn;
                newRow["checkOut"] = reservation.CheckOut;
                newRow["CostOfStay"] = reservation.CostOfStay;
                db2.dsMain.Tables["Reservations"].Rows.Add(newRow);

                // Update the data source
                string insertQuery = "SELECT * FROM Reservations";
                db2.UpdateDataSource(insertQuery, "Reservations");

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
                foreach (Room room in rooms)
                {
                    DataRow newRow = db2.dsMain.Tables["Bookings"].NewRow();
                    newRow["bookingID"] = GetNextBookingID();
                    newRow["reservationID"] = reservationID;
                    newRow["roomID"] = room.RoomID;
                    db2.dsMain.Tables["Bookings"].Rows.Add(newRow);
                }

                // Update the data source
                string insertQuery = "SELECT * FROM Bookings";
                db2.UpdateDataSource(insertQuery, "Bookings");
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
