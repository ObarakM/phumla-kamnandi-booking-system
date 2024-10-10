using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using BookingSystem.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.Presentation
{
    public partial class BookingsForm : Form
    {
        private ReservationForm reservationForm;
        private Guest currentGuest;
        private Reservation reservation;
        public static BookingsForm bookingform;

        private DB db = new DB();
        public BookingsForm()
        {
            InitializeComponent();
            showFormInfo(false);
            idLabel.Visible = false;
            idTextBox.Visible = false;
            searchButton.Visible = false;

        }
        #region
        // testing for message box

        #endregion


        public void showFormInfo(bool value)
        {
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            emailLabel.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            emailTextBox.Visible = value;
            completeReservationButton.Visible = value;
        }
        public void showSearchInfo(bool value)
        {
            idLabel.Visible = value;
            idTextBox.Visible = value;
            searchButton.Visible = value;
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            reservationForm = ReservationForm.reservationForm;
            bookingform = new BookingsForm();
            //showFormInfo(false);
            //idLabel.Visible = false;
            //idTextBox.Visible = false;
            //searchButton.Visible = false;

        }

        private void clearTextBoxes()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (newGuestRadioButton1.Checked)
            {
                idTextBox.Text = db.addGuest(nameTextBox.Text, int.Parse(phoneTextBox.Text), emailTextBox.Text).ToString();
                MessageBox.Show("Guest with ID: " + idTextBox.Text + " successfully created.");
                clearTextBoxes();
                newGuestRadioButton1.Checked = false;
                showFormInfo(false);


            }
            if (existingGuestRadioButton2.Checked)
            {
                AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
                DialogResult result = accountDetailsForm.ShowDialog(); // This will block until the form is closed

                // Check if the form was closed successfully
                if (result == DialogResult.OK) // Adjust this condition based on your form's logic
                {
                    // Proceed with creating the reservation only if the form was closed successfully
                    reservation = new Reservation(0, currentGuest, reservationForm.getRooms(), reservationForm.getCheckIn(), reservationForm.getCheckOut(), reservationForm.getCostOfStay());

                    int reference = db.makeReservation(reservation);
                    MessageBox.Show("Reservation complete and the reference number is: " + reference);
                    clearTextBoxes();
                    existingGuestRadioButton2.Checked = false;
                    showSearchInfo(false);
                }
                else
                {
                    // Handle cases where the user canceled or closed the AccountDetailsForm without completing the action
                    MessageBox.Show("The payment was not completed.");
                }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservationForm.reservationForm.Show();
            this.Close();
        }

        private void newGuestRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearTextBoxes();
            showFormInfo(true);
            showSearchInfo(false);
            completeReservationButton.Text = "Create Guest";
            headerLabel.Text = "Enter New Guest's Details";
        }

        private void existingGuestRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clearTextBoxes();
            showFormInfo(false);
            showSearchInfo(true);
            completeReservationButton.Text = "Complete Reservation";
            headerLabel.Text = "Enter ID To Search For Existing Guest";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            currentGuest = db.findGuest(int.Parse(idTextBox.Text));
            if (currentGuest != null)
            {
                showFormInfo(true);
                searchButton.Visible = false;
                idTextBox.Text = currentGuest.GuestID.ToString();
                nameTextBox.Text = currentGuest.Name;
                emailTextBox.Text = currentGuest.Email;
                phoneTextBox.Text = currentGuest.Phone.ToString();
            }
            else
            {
                MessageBox.Show("Guest not found, please enter valid ID.");
            }

        }
    }
}
