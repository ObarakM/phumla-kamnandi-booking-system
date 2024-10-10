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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PhumlaKamnandiHotelForm.phumlaKamnandi.Show();
            this.Close();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
