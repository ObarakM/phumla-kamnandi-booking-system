using System;
using System.Collections.ObjectModel;

namespace BookingSystem.Business
{
	public class Guest
	{

        #region Field Members
        private int id;
        private string name;
        private int phone;
        private string email;

        private Collection<Reservation> reservations; // To store all the reservations made by a guest
        #endregion

        #region Constructors
        public Guest()
		{
            
		}
        #endregion
    }
}
