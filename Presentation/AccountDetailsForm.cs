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
    public partial class AccountDetailsForm : Form
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private bool validateDetails()
        {
            return cardNumberTextBox.Text.Length < 15 || dateTimePicker.Value.Date < DateTime.Now || securityCodeTextBox.Text.Length < 3; // assuming the card details are only from south africa

        }

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            if (!validateDetails())
            {
                MessageBox.Show("Payment was successful.");
                this.DialogResult = DialogResult.OK; // Set the result to OK when payment is successful
                this.Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Please enter valid card details");
            }

        }

        private void header_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
