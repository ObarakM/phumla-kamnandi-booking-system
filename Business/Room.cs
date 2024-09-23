using System;

namespace BookingSystem.Business
{
    public class Room
    {
        #region Data members;
        private int roomID;
        private bool availability;
        private double dailyRate; // The cost of the room
        private RoomType roomType;
        #endregion

        #region Constructor
        public Room(int roomID, RoomType roomType)
        {
            this.roomID = roomID;
            this.roomType = roomType;

            // Derive dailyRate based on the roomType
            switch (roomType)
            {
                case (RoomType.Standard):
                    dailyRate = 800;
                    break;
                case (RoomType.Studio):
                    dailyRate = 1200;
                    break;
                case (RoomType.Executive):
                    dailyRate = 1450;
                    break;
                case (RoomType.OneBedroomApartment):
                    dailyRate = 1720;
                    break;
            }
        }
        #endregion

        #region Property Methods
        public RoomType getRoomType
        {
            get { return roomType; }
        }
        #endregion

        #region Other Methods
        public string getDescription()
        {
            switch (roomType)
            {
                case (RoomType.Standard):
                    return "with double bed, shared bathroom and access to fully equipped communal kitchen.";
                case (RoomType.Studio):
                    return "with double or single twin bed, en-suite bathroom and access to fully equipped communal kitchen.";
                case (RoomType.Executive):
                    return "with king-size bed (single twin optional) with en-suite bathroom and kitchenette.";
                case (RoomType.OneBedroomApartment):
                    return "with double bed, living room, en-suite bathroom and a fully equipped kitchen.";
                default:
                    return "unknown room type.";
            }
        }

        public bool isAvailable()
        {
            return availability;
        }

        public void checkIn()
        {
            availability = false;
        }

        public void checkOut()
        {
            availability = true;
        }
        #endregion

        #region Enumeration
        public enum RoomType
        {
            Standard = 0,
            Studio = 1,
            Executive = 2,
            OneBedroomApartment = 3
        }
        #endregion

    }
}