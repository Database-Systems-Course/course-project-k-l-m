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
    public partial class SearchOrder : Form
    {
        public SearchOrder()
        {
            InitializeComponent();
        }

        private void SarchOrder_Load(object sender, EventArgs e)
        {

        }

        private void label_CustomerNIC_Click(object sender, EventArgs e)
        {

        }

        private void button_View_Click(object sender, EventArgs e)
        {
            AddOrder Form = new AddOrder();
            this.Hide();

            Form.ShowDialog();
        }
    }
}
