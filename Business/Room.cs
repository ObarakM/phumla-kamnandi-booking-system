using System;

namespace BookingSystem.Business
{
    public class Room
    {
        #region Data members;
        private int roomID; // PK
        private int hotelID; // FK1
        private int? reservationID; // FK2 (it is NULLABLE)

        private bool availability; // To be derived from the NULLness of the reservationID

        private decimal dailyRate; // The cost of the room
        private RoomType roomType;
        #endregion

        #region Constructor
        public Room(int roomID, int hotelID, int? reservationID, decimal dailyRate, RoomType roomType)
        {
            this.roomID = roomID;
            this.roomType = roomType;
            this.reservationID = reservationID;
            this.dailyRate = dailyRate;
            this.roomType = roomType;

            if (reservationID != null ) availability = false;

            //// Derive dailyRate based on the roomType
            //switch (roomType)
            //{
            //    case (RoomType.Standard):
            //        dailyRate = 800;
            //        break;
            //    case (RoomType.Studio):
            //        dailyRate = 1200;
            //        break;
            //    case (RoomType.Executive):
            //        dailyRate = 1450;
            //        break;
            //    case (RoomType.OneBedroomApartment):
            //        dailyRate = 1720;
            //        break;
            //}


        }
        #endregion

        #region Property Methods
        public RoomType getRoomType
        {
            get { return roomType; }
        }

        public decimal DailyRate {get {return dailyRate;} set { dailyRate = value; } }
       
        #endregion

        #region Other Methods
        public string getDescription()
        {
            switch (roomType)
            {
                case (RoomType.Standard):
                    return "Standard Room with double bed, shared bathroom and access to fully equipped communal kitchen.";
                case (RoomType.Studio):
                    return "Studio with double or single twin bed, en-suite bathroom and access to fully equipped communal kitchen.";
                case (RoomType.Executive):
                    return "Executive Room with king-size bed (single twin optional) with en-suite bathroom and kitchenette.";
                case (RoomType.OneBedroomApartment):
                    return "One-Bedroom Apartment with double bed, living room, en-suite bathroom and a fully equipped kitchen.";
                default:
                    return "unknown room type.";
            }
        }
        public decimal getDeposit()
        {
            switch (roomType)
            {
                case (RoomType.Standard):
                    return dailyRate * (decimal)0.1;
                case (RoomType.Studio):
                    return dailyRate * (decimal)0.1;
                case (RoomType.Executive):
                    return dailyRate * (decimal)0.1;
                case (RoomType.OneBedroomApartment):
                    return dailyRate * (decimal)0.1;
                default:
                    return 0;
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