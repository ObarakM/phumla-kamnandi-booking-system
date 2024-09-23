using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BookingSystem.Business
{

    public class Hotel
    {
        private string hotelID;
        private string hotelName;
        private int numOfRooms; // This must be indicated as a derived variable
        private Collection<Room> rooms; // All the rooms in the hotel
        private Collection<Room> availableRooms;

        #region Constructor
        public Hotel(string ID, string name)
        {
            hotelID = ID;
            hotelName = name;
            numOfRooms = 0; // The rooms will be later populated 
        }
        #endregion

        #region Methods
        public void addRoom(Room room)
        {
            rooms.Add(room);
            numOfRooms++;
        }
        #endregion
    }
}