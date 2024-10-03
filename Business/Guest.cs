using System;
using System.Collections.ObjectModel;

namespace BookingSystem.Business
{
	public class Guest
	{

        #region Field Members
        private int guestID;
        private string name;
        private int phone;
        private string email;

        private Collection<Reservation> reservations; // To store all the reservations made by a guest
        #endregion

        #region Property Methods
        public int Id { set; get; }
        public string Name { set; get; }
        public int Phone { set; get; }
        public string Email { set; get; }
        #endregion

        #region Constructors
        public Guest(int guestID, string name, int phone, string email)
		{
            this.guestID = guestID;
            this.name = name;
            this.phone = phone;
            this.email = email;
		}
        #endregion

        #region Methods
        public void addReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        #endregion
    }
}
