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

namespace courseProject_CarlosRoman
{
    public partial class rentedCars : Form
    {
        public rentedCars()
        {
            InitializeComponent();
            string sql = "SELECT * FROM rentedVehicles";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\databases\Database1.mdf;Integrated Security = True;Connect Timeout = 30; ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "rentedVehicles");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "rentedVehicles";

        }

        private void rentedCars_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
