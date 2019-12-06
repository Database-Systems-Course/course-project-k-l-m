using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;


namespace RestaurantManagement
{
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            if (textbox_CustomerNIC.Text == "" || textbox_StaffID.Text == "")
            {
                MessageBox.Show("Please Enter valid Food and Price");
            }
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select Nam from Customers";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();


        }

        private void textbox_CustomerNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
