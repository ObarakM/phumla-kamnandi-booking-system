using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BookingSystem.Business
{

    public class Hotel
    {
        #region Field Members
        private int hotelID;
        private string hotelName;
        private Collection<Room> rooms; // All the rooms in the hotel
        private Collection<Room> availableRooms;
        #endregion

        #region Property Methods
        public int HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        public int NumOfRooms
        {
            get { return rooms.Count; }  // Derived from the size of the rooms collection
        }

        public Collection<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public Collection<Room> AvailableRooms
        {
            get { return availableRooms; }
            set { availableRooms = value; }
        }
        #endregion

        #region Constructor
        public Hotel(int ID, string name)
        {
            hotelID = ID;
            hotelName = name;
        }
        #endregion

        #region Methods
        public void addRoom(Room room)
        {
            rooms.Add(room);
        }
        #endregion
    }
}