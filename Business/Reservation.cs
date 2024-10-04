using System;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;

namespace BookingSystem.Business
{
	public class Reservation
	{
        #region Field Members
        private int reservationID;
		private Guest guest; // A reference to the respective guest
		private Collection<Room> rooms; // The reference to the respective rooms booked by the guest
		private DateTime checkIn;
        private DateTime checkOut;

		private decimal costOfStay; // To be derived based and room type and stay duration 
        #endregion

        #region Property Methods
        public int ReservationID { get { return reservationID; } set { reservationID = value; } }
        public Guest Guest { get { return guest; } set { guest = value; } }

        public Collection<Room> Rooms { get { return rooms; } set { rooms = value; } }

        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }

        public decimal CostOfStay { get { return costOfStay; } set { costOfStay = value; } }
        #endregion 

        #region Constructors
        public Reservation(int reservationID, Guest guest, Collection<Room> rooms, DateTime checkIn, DateTime checkOut, decimal costOfStay)
		{
            this.reservationID = reservationID;
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