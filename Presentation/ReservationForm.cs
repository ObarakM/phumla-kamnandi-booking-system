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

namespace BookingSystem.Presentation
{
    public partial class ReservationForm : Form
    {
        private Hotel hotel;
        private Collection<Room> rooms;
        Room standard;
        Room studio;
        Room executive;
        Room apartment;
        int adults;
        int olderChildren;
        int children;

        public ReservationForm()
        {
            InitializeComponent();
            standard = new Room(1, Room.RoomType.Standard);
            studio = new Room(2, Room.RoomType.Studio);
            executive = new Room(3, Room.RoomType.Executive);
            apartment = new Room(4, Room.RoomType.OneBedroomApartment);
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            showRooms(false);
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
            BookingsForm bookingForm = new BookingsForm();
            bookingForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rooms.Add(standard);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            rooms.Add(studio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            rooms.Add(executive);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            rooms.Add(apartment);
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
    }
}
