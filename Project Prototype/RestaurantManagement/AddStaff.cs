using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient; //

namespace RestaurantManagement//
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select JobTitle from Jobs";
            command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            sql = "select idBranch from Branch";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetValue(0).ToString());
            }

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }

        private void Textbox_NIC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_AddStaff_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            sq.Open();
            //command.CommandText = "insert into Staff  "
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
