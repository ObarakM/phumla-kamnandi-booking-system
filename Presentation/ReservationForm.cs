using BookingSystem.Business;
using BookingSystem.Data;
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
        private int adults = 0;
        private int olderChildren = 0;
        private int children = 0;
        private decimal costOfStay;
        private DB db = new DB();

        private int selectableStandard = 0;
        private int selectableStudio = 0;
        private int selectableExecutive = 0;
        private int selectableApartment = 0;

        private DateTime checkIn;
        private DateTime checkOut;
        #endregion

        public ReservationForm()
        {

            InitializeComponent();
            rooms = new Collection<Room>();

            standard = new Room(1, 1, Room.RoomType.Standard);
            studio = new Room(2, 1, Room.RoomType.Studio);
            executive = new Room(3, 1, Room.RoomType.Executive);
            apartment = new Room(4, 1, Room.RoomType.OneBedroomApartment);
        }

        private void SetRoomVisibility(Room.RoomType roomType, bool value)
        {
            switch (roomType)
            {
                case Room.RoomType.Standard:
                    pictureBox1.Visible = value;
                    roomDescription1.Visible = value;
                    select1.Visible = value;
                    break;
                case Room.RoomType.Studio:
                    pictureBox2.Visible = value;
                    roomDescription2.Visible = value;
                    select2.Visible = value;
                    break;
                case Room.RoomType.Executive:
                    pictureBox3.Visible = value;
                    roomDescription3.Visible = value;
                    select3.Visible = value;
                    break;
                case Room.RoomType.OneBedroomApartment:
                    pictureBox4.Visible = value;
                    roomDescription4.Visible = value;
                    select4.Visible = value;
                    break;
            }
        }


        private void showRooms(bool value)
        {
            if (adults==0 ) { // assuming children cannot be in the hotel without an adult
                value = false;
            }
            
            for (int i = 0; i < 4; i++) // check if rooms are available
            {
                // Check if rooms are available AND if 'value' (based on adults) is true
                if (value && db.getFreeRoomsCount((Room.RoomType)i, checkIn, checkOut) != 0)
                {
                    SetRoomVisibility((Room.RoomType)i, true);
                }
                else
                {
                    SetRoomVisibility((Room.RoomType)i, false);
                }
            }
            finishBookingButton.Visible = value;
            reservationListView.Visible = value;
        }


        public void calculateCostOfStay()
        {
            foreach (Room room in rooms)
            {
                costOfStay += (room.DailyRate*adults+(room.DailyRate/2)*children);
            }
        }

        public bool sufficientRooms()
        {
            int spaceReserved = 0;
            int spaceNeeded = adults + olderChildren + children;
            foreach (Room room in rooms)
            {
                if (room.getRoomType == Room.RoomType.Standard)
                {
                    spaceReserved += 4;
                }
                else
                {
                    spaceReserved += 2;
                }
            }
            return spaceReserved >= spaceNeeded;

        }



        #region accessor methods
        public Collection<Room> getRooms()
        {
            return rooms;
        }
        public decimal getCostOfStay()
        {
            calculateCostOfStay();
            return costOfStay;
        }
        public DateTime getCheckIn()
        {
            return dateTimePicker1.Value.Date;
        }

        public DateTime getCheckOut()
        {
            return dateTimePicker2.Value.Date;
        }
        #endregion



        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            reservationForm = this;    
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
            

                int selectedStandard = db.getFreeRoomsCount(Room.RoomType.Standard, checkIn, checkOut)-selectableStandard;
                Collection<Room> temp = db.getFreeRoomsByType(Room.RoomType.Standard, checkIn, checkOut);
                for (int i = 0; i < selectedStandard; i++)
                {
                    rooms.Add(temp[0]);
                    temp.RemoveAt(0);
                }
                
                int selectedStudio = db.getFreeRoomsCount(Room.RoomType.Studio, checkIn, checkOut)-selectableStudio;
                temp = db.getFreeRoomsByType(Room.RoomType.Studio, checkIn, checkOut);
                for (int i = 0; i < selectedStudio; i++)
                {
                    rooms.Add(temp[0]);
                    temp.RemoveAt(0);
                }
                                
                int selectedExecutive = db.getFreeRoomsCount(Room.RoomType.Executive, checkIn, checkOut)-selectableExecutive;
                temp = db.getFreeRoomsByType(Room.RoomType.Executive, checkIn, checkOut);
                for (int i = 0; i < selectedExecutive; i++)
                {
                    rooms.Add(temp[0]);
                    temp.RemoveAt(0);
                }
                                
                int selectedApartment = db.getFreeRoomsCount(Room.RoomType.OneBedroomApartment, checkIn, checkOut)-selectableApartment;
                temp = db.getFreeRoomsByType(Room.RoomType.OneBedroomApartment, checkIn, checkOut);
                for (int i = 0; i < selectedApartment; i++)
                {
                    rooms.Add(temp[0]);
                    temp.RemoveAt(0);
                }


            if (sufficientRooms())
            {
                PhumlaKamnandiHotelForm.bookingsForm.Show();
                //bookingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select more rooms to accomodate all guests!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            // add items to the list view
            ListViewItem item = new ListViewItem(standard.getRoomType.ToString());
            item.SubItems.Add(4.ToString());
            item.SubItems.Add(standard.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible=true;
            reservationListView.Visible=true;

            selectableStandard--;
            if (selectableStandard == 0)
            {
                pictureBox1.Visible=false;
                roomDescription1.Visible=false;
                select1.Visible=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            // add items to the list view
            ListViewItem item = new ListViewItem(studio.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(studio.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;

            selectableStudio--;
            if (selectableStudio == 0)
            {
                pictureBox2.Visible = false;
                roomDescription2.Visible = false;
                select2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            // add items to the list view
            ListViewItem item = new ListViewItem(executive.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(executive.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;
            selectableExecutive--;
            if (selectableExecutive == 0)
            {
                pictureBox3.Visible = false;
                roomDescription3.Visible = false;
                select3.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            // add items to the list view
            ListViewItem item = new ListViewItem(apartment.getRoomType.ToString());
            item.SubItems.Add(2.ToString());
            item.SubItems.Add(apartment.DailyRate.ToString());
            reservationListView.Items.Add(item);
            //set the list view and finish booking button visibility to true
            finishBookingButton.Visible = true;
            reservationListView.Visible = true;
            selectableApartment--;
            if (selectableApartment == 0)
            {
                pictureBox4.Visible = false;
                roomDescription4.Visible = false;
                select4.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Capture the cheking dates
            checkIn = dateTimePicker1.Value;
            checkOut = dateTimePicker2.Value;

            // initialise selactable counts correctly
            selectableStandard = db.getFreeRoomsCount(Room.RoomType.Standard, checkIn, checkOut);
            selectableExecutive = db.getFreeRoomsCount(Room.RoomType.Executive, checkIn, checkOut);
            selectableStudio = db.getFreeRoomsCount(Room.RoomType.Studio, checkIn, checkOut);
            selectableApartment = db.getFreeRoomsCount(Room.RoomType.OneBedroomApartment, checkIn, checkOut);

            roomDescription1.Text = standard.getDescription();
            roomDescription2.Text = studio.getDescription();
            roomDescription3.Text = executive.getDescription();
            roomDescription4.Text = apartment.getDescription();
            //reservationListView.Clear();
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

                PhumlaKamnandiHotelForm.phumlaKamnandi.Show();
                this.Close();
            

            //PhumlaKamnandiHotelForm kamnandiHotelForm = new PhumlaKamnandiHotelForm();
            
            //kamnandiHotelForm.Show();
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reservationListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }
    }
}
