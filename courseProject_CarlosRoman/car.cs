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
    public partial class car : Form
    {
        public MainForm HandleToMainForm;
        public car(MainForm frm1Handle)
        {
            InitializeComponent();
            HandleToMainForm = frm1Handle;


        }

        public car()
        {

            InitializeComponent();

        }


        private void car_Load(object sender, EventArgs e)
        {
          

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (String.IsNullOrEmpty(textBoxCompany.Text) || String.IsNullOrEmpty(textBoxLicense.Text) || String.IsNullOrEmpty(textBoxMiles.Text) || String.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Please Make sure to Enter all the fields, even the DRAG ones");
            }
            else
            {
                StringBuilder treenodes = new StringBuilder() ;
                foreach (TreeNode tn in treeView1.Nodes[0].Nodes) { treenodes.Append(tn.Text); }
                HandleToMainForm.loadCar(textBoxModel.Text.ToString(), textBoxCompany.Text.ToString(), textBoxMiles.Text.ToString(), textBoxMiles.Text.ToString(), comboBox1.SelectedItem.ToString(), treenodes.ToString() , monthCalendar1.SelectionStart.ToShortDateString());
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TreeView_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void TreeView_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // check to be sure that the drag content is the correct type for this control
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void TreeView_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            TreeNode NewNode;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt;
                TreeNode DestinationNode;
                pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (!(DestinationNode.TreeView == NewNode.TreeView))
                {
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    // remove original node
                    NewNode.Remove();
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
