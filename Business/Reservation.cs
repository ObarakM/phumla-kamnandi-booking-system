﻿using System;
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
        private Room room;

		private double costOfStay; // To be derived based and room type and stay duration 
        #endregion

        #region Property Methods
        public Guest Guest { get { return guest; } set { guest = value; } }

        public Room Room { get { return room; } set { room = value; } }

        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }

        public double CostOfStay { get { return costOfStay; } set { costOfStay = value; } }
        #endregion 

        #region Constructors
        public Reservation(Guest guest, Room room, DateTime checkIn, DateTime checkOut)
		{
            this.guest = guest;
            this.room = room;
            this.checkIn = checkIn;
            this.checkOut = checkOut;

            // Calculate the total costOfStay
            int numberOfDays = (checkOut - checkIn).Days;
            costOfStay = numberOfDays * room.DailyRate;
		}
        #endregion

        #region Methods
        // Cancel Reservation

        #endregion
    }
}