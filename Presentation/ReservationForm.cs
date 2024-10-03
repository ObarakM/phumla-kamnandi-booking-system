using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookingSystem.Presentation
{
    public partial class ReservationForm : Form
    {
        #region data members
        public static ReservationForm reservationForm;
        private Hotel hotel;
        private Collection<Room> rooms;
        private Room standard;
        private Room studio;
        private Room executive;
        private Room apartment;
        private int adults;
        private int olderChildren;
        private int children;
        private decimal costOfStay;
        #endregion

        public ReservationForm()
        {

            InitializeComponent();
            standard = new Room(1,1,1, Room.RoomType.Standard);
            studio = new Room(2,1,1, Room.RoomType.Studio);
            executive = new Room(3,1,1, Room.RoomType.Executive);
            apartment = new Room(4,1,1, Room.RoomType.OneBedroomApartment);
            rooms = new Collection<Room>();

        }

        private void showRooms(bool value)
        {
            if (!(adults>0) ) { // assuming children cannot be in the hotel without an adult
                value = false;
            }
            pictureBox1.Visible = value;
            pictureBox2.Visible = value;
            pictureBox3.Visible = value;
            pictureBox4.Visible = value;
            roomDescription1.Visible = value;
            roomDescription2.Visible = value;
            roomDescription3.Visible = value;
            roomDescription4.Visible = value;
            select1.Visible = value;
            select2.Visible = value;
            select3.Visible = value;
            select4.Visible = value;
            finishBookingButton.Visible = value;
            reservationListView.Visible = value;
        }

        public void calculateCostOfStay()
        {
            foreach (Room room in rooms)
            {
                costOfStay += room.DailyRate;
            }
        }
        #region accessor methods
        public Collection<Room> getRooms()
        {
            return rooms;
        }
        public decimal getCostOfStay()
        {
            return costOfStay;
        }
        public DateTime getCheckIn()
        {
            return dateTimePicker1.Value;
        }

        public DateTime getCheckOut()
        {
            return dateTimePicker2.Value;
        }
        #endregion



        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            reservationForm = new ReservationForm();    
            showRooms(false);


            finishBookingButton.Visible = false;
            reservationListView.Visible = false;
            reservationListView.View = View.Details; // set list view to view details

            // add column headers
            reservationListView.Columns.Add("Room type", 150);  // Header "Room Type", width 100
            reservationListView.Columns.Add("Max Occupancy", 150);         // Header "Price", width 100
            reservationListView.Columns.Add("Rate", 100);       // Header "Deposit", width 100
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            children = (int)numericUpDown1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PhumlaKamnandiHotelForm.bookingsForm.Show();
            //bookingForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rooms.Add(standard);
            // add items to the list view
            ListViewItem item = new ListViewItem(standard.getRoomType.ToString());
            item.SubItems.Add(4.ToString());
            item.SubItems.Add(standard.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible=true;
            reservationListView.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            rooms.Add(studio);
            // add items to the list view
            ListViewItem item = new ListViewItem(studio.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(studio.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            rooms.Add(executive);
            // add items to the list view
            ListViewItem item = new ListViewItem(executive.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(executive.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            rooms.Add(apartment);
            // add items to the list view
            ListViewItem item = new ListViewItem(apartment.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(apartment.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomDescription1.Text = standard.getDescription();
            roomDescription2.Text = studio.getDescription();
            roomDescription3.Text = executive.getDescription();
            roomDescription4.Text = apartment.getDescription();
            showRooms(true);
        }

        private void roomDescription2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomDescription3_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomDescription4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            adults = (int)numericUpDown3.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            olderChildren = (int)numericUpDown2.Value;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //PhumlaKamnandiHotelForm kamnandiHotelForm = new PhumlaKamnandiHotelForm();
            PhumlaKamnandiHotelForm.phumlaKamnandi.Show();
            //kamnandiHotelForm.Show();
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
