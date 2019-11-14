using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void label_LastName_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_Soda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_Tea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_Coffee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }
    }
}
