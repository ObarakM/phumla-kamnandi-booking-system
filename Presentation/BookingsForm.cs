using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class BookingsForm : Form
    {
        private ReservationForm reservationForm;
        private Guest guest;
        private Reservation reservation;
        public BookingsForm()
        {
            InitializeComponent();
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            reservationForm = new ReservationForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            guest = new Guest(int.Parse(idTextBox.Text),nameTextBox.Text,int.Parse(phoneTextBox.Text),emailTextBox.Text);
            reservation = new Reservation(guest, reservationForm.getRooms(),reservationForm.getCheckIn(),reservationForm.getCheckOut(), reservationForm.getCostOfStay());
        }
    }
}
