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
        public int GuestID { set { guestID = value; } get { return guestID; } }
        public string Name { set { name = value; } get { return name; } }
        public int Phone { set { phone = value; } get { return phone; } }
        public string Email { set { email = value; } get { return email; } }
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
