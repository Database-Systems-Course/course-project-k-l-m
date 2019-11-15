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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddOrder Form = new AddOrder();
            this.Hide();
            Form.Show();
        }

        private void button_SearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrder Form = new SearchOrder();
            this.Hide();
            Form.Show();
        }

        private void button_AddStaff_Click(object sender, EventArgs e)
        {
            AddStaff Form = new AddStaff();
            this.Hide();
            Form.Show();

        }

        private void button_SearchStaff_Click(object sender, EventArgs e)
        {
            SearchStaff Form = new SearchStaff();
            this.Hide();
   
            Form.Show();

        }
    }
}
