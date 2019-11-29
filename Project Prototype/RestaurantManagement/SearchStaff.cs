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
    public partial class SearchStaff : Form
    {
        string var = "";

        public SearchStaff()
        {
            InitializeComponent();
            

        }

        private void DisplayData()
        {
            
            SqlConnection con;
            DbConnection db = new DbConnection();//
            string connString = db.GetConnectionString();
            con = new SqlConnection(connString);
            con.ConnectionString = "server=DESKTOP-09G2FL8; Initial Catalog=WSMS; Integrated Security=true;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "EXEC [Staff Display]" + var;
            Debug.WriteLine(cmd.CommandText);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            dataGridView1.DataSource = ds.Tables["SearchResult"];
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Refresh();

        }
            private void label_AddStaff_Click(object sender, EventArgs e)
        {

        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            Menu Form = new Menu();
            this.Hide();
            Form.Show();
        }

        private void textbox_NIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetimepicker_HiringDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_BranchID_Click(object sender, EventArgs e)
        {

        }

        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_View_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_Staff_Click(object sender, EventArgs e)
        {
            
            if (textbox_NIC.Text != "")
            {
                var = var + "@NIC = " + textbox_NIC.Text + ",";
            }

            Debug.WriteLine(var);

            if (textbox_FirstName.Text != "")
            {
                var = var + "@FirstName = " + textbox_FirstName.Text + ",";
            }

            //Debug.WriteLine(var);

            if (textbox_LastName.Text != "")
            {
                var = var + "@LastName = " + textbox_LastName.Text + ",";
            }

            //Debug.WriteLine(var);


            if (textbox_BranchID.Text != "")
            {
                var = var + "@BranchId = " + textbox_BranchID.Text + ",";
            }

            //Debug.WriteLine(var);

            if (textbox_JobTitle.Text != "")
            {
                var = var + "@JobTitle = " + textbox_JobTitle.Text + ",";
            }

            //Debug.WriteLine(var);

            if (datetimepicker_HiringDate.Value.ToString("yyyy-MM-dd") != "")
            {
                var = var + " @HiringData = " + datetimepicker_HiringDate.Value.ToString("yyyy-MM-dd") + ",";
            }

            //Debug.WriteLine(var);

            if (textbox_DailyWorkHours.Text != "")
            {
                var = var + "@WorkHours = " + textbox_DailyWorkHours.Text + ",";
            }
            DisplayData();
        }

        private void label_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void label_LastName_Click(object sender, EventArgs e)
        {

        }

        private void SearchStaff_Load(object sender, EventArgs e)
        {

        }

        private void label_JobTitle_Click(object sender, EventArgs e)
        {

        }

        private void label_HiringDate_Click(object sender, EventArgs e)
        {

        }

        private void label_DailyWorkHours_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
