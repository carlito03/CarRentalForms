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
    public partial class truck : Form
    {
        private MainForm handleToMainForm;
        public truck()
        {
            InitializeComponent();
        }

        public truck(MainForm myHandler)
        {
            InitializeComponent();
            handleToMainForm = myHandler;
        }

        private void truck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCompany.Text) || String.IsNullOrEmpty(textBoxPlate.Text) || String.IsNullOrEmpty(textBoxMiles.Text) || String.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Make sure to enter all the fields!");

            }

            else
            {

                handleToMainForm.loadTruck(textBoxModel.Text.ToString(), textBoxCompany.Text.ToString(), textBoxMiles.Text.ToString(),
                    textBoxPlate.Text.ToString(), textBoxType.Text.ToString(), comboBox1.SelectedItem.ToString(), monthCalendar1.SelectionStart.ToShortDateString());
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
