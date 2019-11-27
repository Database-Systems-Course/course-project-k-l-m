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
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select Name from FoodItems";
            command.CommandText = sql;
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                combobox_FoodItems.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            sql = "select idStaff from Staff";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
               comboBox1.Items.Add(reader.GetValue(0).ToString());
            }

        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            bool flag = false;

            DbConnection db = new DbConnection();//
            string conString = db.GetConnectionString();//
            SqlConnection sq = new SqlConnection(conString);//
            SqlCommand command = new SqlCommand();//
            command.Connection = sq;
            string sql = "select NIC from Customers";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);
            sq.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == textbox_CustomerNIC.Text)
                {
                    MessageBox.Show("Customer already in Database, No new customer added.");
                    return;
                    
                }
            }
            reader.Close();
            if (textbox_CustomerNIC.Text == "")
            {
                MessageBox.Show("Please enter a CNIC");
                return;
            }
            if (textbox_FirstName.Text == "")
            {
                MessageBox.Show("Please enter FirstName ");
                return;
            }
            if (textbox_LastName.Text == "")
            {
                MessageBox.Show("Please enter LastName ");
                return;
            }
            MessageBox.Show("New customer added in database");

            command = new SqlCommand();//

            command.Connection = sq;
            sql = "select top 1 CustomerID from Customers order by CustomerID desc";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            reader.Read();
            string id = (int.Parse(reader.GetValue(0).ToString())+1).ToString();
            reader.Close();
            command = new SqlCommand();//
            command.Connection = sq;
          

            sql = "insert into Customers values (@id, @NIC , @FirtsName,@LastName)";
            command.CommandText = sql;

            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@NIC", textbox_CustomerNIC.Text);
            command.Parameters.AddWithValue("@FirtsName", textbox_FirstName.Text);
            command.Parameters.AddWithValue("@LastName", textbox_LastName.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            
            









        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {

        }

        private void Button_AddItem_Click(object sender, EventArgs e)
        {
            if (combobox_FoodItems.SelectedItem != null )
            {
                OrderedItems.Items.Add(combobox_FoodItems.SelectedItem.ToString());
                Quantity.Items.Add(QtyTextBox.Text);
            }
        }

        private void Textbox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
