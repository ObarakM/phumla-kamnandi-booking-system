using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class PhumlaKamnandiHotelForm  : Form
    {
        public static PhumlaKamnandiHotelForm phumlaKamnandi;
        public static BookingsForm bookingsForm;
        public PhumlaKamnandiHotelForm()
        {
            InitializeComponent();
            
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            phumlaKamnandi = new PhumlaKamnandiHotelForm();
            bookingsForm = new BookingsForm();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
            this.Hide();
        }

        private void bookingsButton_Click(object sender, EventArgs e)
        {
            BookingListing bookingListing = new BookingListing();
            bookingListing.Show();
            this.Hide();
        }
    }
}
