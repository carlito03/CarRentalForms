using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace courseProject_CarlosRoman
{
    public partial class customers01 : courseProject_CarlosRoman.rentedCars
    {
        public customers01()
        {
            InitializeComponent();
            string sql = "SELECT name FROM rentedVehicles";
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

        private void customers01_Load(object sender, EventArgs e)
        {

        }
    }
}
