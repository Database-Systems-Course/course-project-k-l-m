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
            if (combobox_FoodItems.SelectedItem.ToString() != "" )
            {
                OrderedItems.Items.Add(combobox_FoodItems.SelectedItem.ToString());
                Quantity.Items.Add(QtyTextBox.Text);
            }
        }
    }
    
}
