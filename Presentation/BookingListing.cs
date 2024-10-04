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
        }

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
        private void BookingListing_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            showAll(false);
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
    }
}
