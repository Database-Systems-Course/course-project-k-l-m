﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isStaff = false;
            bool isManager = false;
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            //string sql = "Select ;
            //command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            // we will put a check after connecting forms to database
            //on click we will check whether the login id and password exists in databse
            if (isStaff==true & textbox_Password.Text.ToString()== "iamstaff")
            {
                Menu Form = new Menu();
                this.Hide();
                Form.Show();
            }
            if (isManager == true & textbox_Password.Text.ToString() == "iammanager")
            {
                Menu Form = new Menu();
                this.Hide();
                Form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
