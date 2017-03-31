namespace courseProject_CarlosRoman
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRUCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedCARSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstName = new System.Windows.Forms.TextBox();
            this.customerLicense = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxmodel = new System.Windows.Forms.TextBox();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.TextBoxPlate = new System.Windows.Forms.TextBox();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.rentedCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(37, 390);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.reportsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARToolStripMenuItem,
            this.tRUCKToolStripMenuItem});
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nEWToolStripMenuItem.Text = "NEW";
            // 
            // cARToolStripMenuItem
            // 
            this.cARToolStripMenuItem.Name = "cARToolStripMenuItem";
            this.cARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cARToolStripMenuItem.Text = "CAR";
            this.cARToolStripMenuItem.Click += new System.EventHandler(this.cARToolStripMenuItem_Click);
            // 
            // tRUCKToolStripMenuItem
            // 
            this.tRUCKToolStripMenuItem.Name = "tRUCKToolStripMenuItem";
            this.tRUCKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tRUCKToolStripMenuItem.Text = "TRUCK";
            this.tRUCKToolStripMenuItem.Click += new System.EventHandler(this.tRUCKToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentedCARSToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // rentedCARSToolStripMenuItem
            // 
            this.rentedCARSToolStripMenuItem.Name = "rentedCARSToolStripMenuItem";
            this.rentedCARSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rentedCARSToolStripMenuItem.Text = "Rented CARS";
            this.rentedCARSToolStripMenuItem.Click += new System.EventHandler(this.rentedCARSToolStripMenuItem_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(187, 73);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(120, 20);
            this.firstName.TabIndex = 3;
            // 
            // customerLicense
            // 
            this.customerLicense.Location = new System.Drawing.Point(502, 73);
            this.customerLicense.Name = "customerLicense";
            this.customerLicense.Size = new System.Drawing.Size(120, 20);
            this.customerLicense.TabIndex = 4;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(39, 80);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(142, 13);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "ENTER CUSTOMER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ENTER LICENSE #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CAR  RENTAL INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Plate #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Other features";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(149, 177);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.ReadOnly = true;
            this.textBoxCompany.Size = new System.Drawing.Size(120, 20);
            this.textBoxCompany.TabIndex = 15;
            // 
            // textBoxmodel
            // 
            this.textBoxmodel.Location = new System.Drawing.Point(149, 218);
            this.textBoxmodel.Name = "textBoxmodel";
            this.textBoxmodel.ReadOnly = true;
            this.textBoxmodel.Size = new System.Drawing.Size(120, 20);
            this.textBoxmodel.TabIndex = 16;
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Location = new System.Drawing.Point(149, 263);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.ReadOnly = true;
            this.textBoxMiles.Size = new System.Drawing.Size(120, 20);
            this.textBoxMiles.TabIndex = 17;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(435, 165);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(170, 20);
            this.textBoxType.TabIndex = 18;
            // 
            // TextBoxPlate
            // 
            this.TextBoxPlate.Location = new System.Drawing.Point(435, 215);
            this.TextBoxPlate.Name = "TextBoxPlate";
            this.TextBoxPlate.ReadOnly = true;
            this.TextBoxPlate.Size = new System.Drawing.Size(170, 20);
            this.TextBoxPlate.TabIndex = 19;
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(435, 263);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.ReadOnly = true;
            this.textBoxOther.Size = new System.Drawing.Size(170, 20);
            this.textBoxOther.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(670, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 221);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "MOST RECENT CAR RENTALS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "E&XIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "LOAD CAR INFORMATION BY GOING TO FILE --> NEW";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "SAVE REPORT ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "NEW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(146, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Return Delivery Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(268, 315);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(120, 20);
            this.textBoxDate.TabIndex = 29;
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(667, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "DOUBLE CLICK TO CHECK DETAILS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 467);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.TextBoxPlate);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.textBoxmodel);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.customerLicense);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.save);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RENT-A-CAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRUCKToolStripMenuItem;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox customerLicense;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxmodel;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox TextBoxPlate;
        private System.Windows.Forms.TextBox textBoxOther;
        
        private System.Windows.Forms.BindingSource rentedCarsBindingSource;
        
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rentedCARSToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Label label13;
    }
}

