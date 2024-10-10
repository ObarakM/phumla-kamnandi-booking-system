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
    public partial class PhumlaKamnandiHotelForm : Form
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
            phumlaKamnandi = this;
            bookingsForm = new BookingsForm();
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
            this.Hide();
        }

        // Declare the ToolTip at the form level
        ToolTip toolTip1 = new ToolTip();

        private void reservationButton_MouseEnter(object sender, EventArgs e)
        {
            // Change the background color when mouse enters
            reservationButton.BackColor = Color.LightBlue;

            // Show a tooltip when hovering over the button
            toolTip1.Show("This is a tooltip!", reservationButton);
        }

        private void reservationButton_MouseLeave(object sender, EventArgs e)
        {
            // Change the background color back when the mouse leaves
            reservationButton.BackColor = SystemColors.Control;

            // Hide the tooltip when the mouse leaves
            toolTip1.Hide(reservationButton);
        }


        private void bookingsButton_Click(object sender, EventArgs e)
        {
            BookingListing bookingListing = new BookingListing();
            bookingListing.Show();
            this.Hide();
        }
    }
}
