using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class AddOrder : Form
    {
        SqlConnection con;
        public AddOrder()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-09G2FL8; Initial Catalog=Project; Integrated Security=true;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
               // gender.Items.Add(rd[0]);
            }
            rd.Close();

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

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }
    }
}
