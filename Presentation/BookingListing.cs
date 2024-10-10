using BookingSystem.Business;
using BookingSystem.Data;
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
    public partial class BookingListing : Form
    {
        public BookingListing()
        {
            InitializeComponent();
            showAll(false);
        }
        private DB db = new DB();

        public void showAll(bool value)
        {
            reservationIDLabel.Visible = value;
            guestIDLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            emailLabel.Visible = value;
            checkInLabel.Visible = value;
            checkOutLabel.Visible = value;
            costOfLabel.Visible = value;
            editButton.Visible = value;
            deleteButton.Visible = value;
            cancelButton.Visible = value;
            submitButton.Visible = value;
            reservationIDTextBox.Visible = value;
            guestIDTextBox.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            emailTextBox.Visible = value;
            checkInTextBox.Visible = value;
            checkOutTextBox.Visible = value;
            costOfStayTextBox.Visible = value;

        }

        // clear all text boxes
        private void clearAll()
        {
            reservationIDTextBox.Text = "";
            guestIDTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            emailTextBox.Text = "";
            checkInTextBox.Text = "";
            checkOutTextBox.Text = "";
            costOfStayTextBox.Text = "";
        }

        private void populateTextBoxes(int guestID, string guestName, int phone, string email)
        {
            guestIDTextBox.Text = guestID.ToString();
            nameTextBox.Text = guestName;
            phoneTextBox.Text = phone.ToString();
            emailTextBox.Text = email.ToString();
        }
        private void BookingListing_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            bookingsListView.GridLines = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PhumlaKamnandiHotelForm kamnandiHotelForm = new PhumlaKamnandiHotelForm();
            //kamnandiHotelForm.Show();
            PhumlaKamnandiHotelForm.phumlaKamnandi.Show();
            this.Close();
        }


        private void bookingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bookingsListView.SelectedItems.Count > 0)
            {
                //get the selected guest and their reservation using their id

                Guest selectedGuest = db.findGuest(int.Parse(bookingsListView.SelectedItems[0].Text));
                populateTextBoxes(selectedGuest.GuestID, selectedGuest.Name, selectedGuest.Phone, selectedGuest.Email);
                showAll(true);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            clearAll();
            showAll(false);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearAll();
            showAll(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhumlaKamnandiHotelForm.phumlaKamnandi.Show();
            this.Close();
        }
    }
}
