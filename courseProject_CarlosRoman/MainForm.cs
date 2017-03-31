//Windows forms program that keeps track of customers and car rentals 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace courseProject_CarlosRoman
{
    
    public partial class MainForm : Form
    {
        private static List<myCars> list = new List<myCars>();

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.rentedCars' table. You can move, or remove it, as needed.
          

        }

        private void cARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if user has entered a name and ID license 
            if (String.IsNullOrEmpty(firstName.Text) || String.IsNullOrEmpty(customerLicense.Text) )
            {
                MessageBox.Show("Make sure to enter Name AND License first!");

            }
            else {

                // Load  car form 
            car newCarForm = new car(this); 
            newCarForm.Show();

            }
        }

        //we call this program to load the values from the car form and the same time add the car to the listview1 
        //note that we create a new object car so we can ADD TO the static list as well 

        public void loadCar(string model, string company, string miles, string licensePlate, string type, string otherFeatures, string returnDate)
        {
            textBoxCompany.Text = company;
            textBoxmodel.Text = model;
            textBoxMiles.Text = miles;
            TextBoxPlate.Text = licensePlate;
            textBoxType.Text = type;
            textBoxOther.Text = otherFeatures;
            textBoxDate.Text = returnDate;

            myCars car = new myCars(model,company, miles, licensePlate, type, otherFeatures,returnDate );

            listView1.Items.Add(car.Model.ToString()+ " " +firstName.Text.ToString());
           
            list.Add(car);

        }


        public void loadTruck(string model, string company, string miles, string licensePlate, string type, string otherFeatures, string returnDate)
        {
            myTrucks truck = new myTrucks(model,company, miles, licensePlate, type, otherFeatures, returnDate);

            textBoxCompany.Text = company;
            textBoxmodel.Text = model;
            textBoxMiles.Text = miles;
            TextBoxPlate.Text = licensePlate;
            textBoxType.Text = type;
            textBoxOther.Text = otherFeatures;
            textBoxDate.Text = returnDate;

            listView1.Items.Add(truck.Model.ToString() + " " + firstName.Text.ToString());

            list.Add(truck);
        }

        

        private void tRUCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstName.Text) || String.IsNullOrEmpty(customerLicense.Text))
            {
                MessageBox.Show("Make sure to enter Name AND License first!");

            }
            else
            {


                truck newTruckForm = new truck(this); //add this
                newTruckForm.Show();

            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //new SQL connection MAKE SURE YOUR FILE IS AT C:\databases !!


            System.Data.SqlClient.SqlConnection con;
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=C:\databases\Database1.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;";
            con.Open();
            string query = "INSERT INTO rentedVehicles (name, company, model, miles, type, plates, customerLicense, returnDate, otherFeatures) values('" + firstName.Text + "','" + textBoxCompany.Text + "','" + textBoxmodel.Text + "','" + textBoxMiles.Text + "','" + textBoxType.Text + "','" + TextBoxPlate.Text + "','" + customerLicense.Text + "','" + textBoxDate.Text + "','" + textBoxOther.Text + "');";
            System.Data.SqlClient.SqlCommand cmdDataBase = new System.Data.SqlClient.SqlCommand(query, con);

            System.Data.SqlClient.SqlDataReader myReader;
              try
            {


                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                textBoxCompany.Clear();
                textBoxmodel.Clear();
                textBoxMiles.Clear();
                TextBoxPlate.Clear();
                textBoxType.Clear();
                textBoxOther.Clear();
                textBoxDate.Clear();
                firstName.Clear();
                customerLicense.Clear();
                while (myReader.Read())
                {


                }

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            con.Close();


           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rentedCARSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rentedCars newRentedCars = new rentedCars();
            newRentedCars.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
          

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var myIndice = listView1.FocusedItem.Index;
            MessageBox.Show(list[myIndice].displayInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCompany.Clear();
            textBoxmodel.Clear();
            textBoxMiles.Clear();
            TextBoxPlate.Clear();
            textBoxType.Clear();
            textBoxOther.Clear();
            textBoxDate.Clear();
            firstName.Clear();
            customerLicense.Clear();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customers01 newCustomersForm = new customers01();
            newCustomersForm.Show();
        }
    }
}
