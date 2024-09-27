using System;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;

namespace BookingSystem.Business
{
	public class Reservation
	{
        #region Field Members
		private Guest guest; // A reference to the respective guest
		private Collection<Room> rooms; // The reference to the respective rooms booked by the guest
		private DateTime checkIn;
        private DateTime checkOut;

		private double costOfStay; // To be derived based and room type and stay duration 
        #endregion

        #region Property Methods
        public Guest Guest { get { return guest; } set { guest = value; } }

        public Collection<Room> Rooms { get { return rooms; } set { rooms = value; } }

        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }

        public double CostOfStay { get { return costOfStay; } set { costOfStay = value; } }
        #endregion 

        #region Constructors
        public Reservation(Guest guest, Collection<Room> rooms, DateTime checkIn, DateTime checkOut, double costOfStay)
		{
            this.guest = guest;
            this.rooms = rooms;
            this.checkIn = checkIn;
            this.checkOut = checkOut;

            this.costOfStay = costOfStay;
		}
        #endregion

        #region Methods
        // Cancel Reservation

        #endregion
    }
}