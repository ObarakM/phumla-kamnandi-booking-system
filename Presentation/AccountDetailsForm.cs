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

        private void makePaymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment was successful.");
            this.DialogResult = DialogResult.OK; // Set the result to OK when payment is successful
            this.Close(); // Close the form
        }

        private void header_Click(object sender, EventArgs e)
        {
            this.StartPosition= FormStartPosition.CenterScreen;
        }
    }
}
