namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksSuppliesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlDrinksSupplies = new System.Windows.Forms.Panel();
            this.lblALTERDRINKSUPPLIES = new System.Windows.Forms.Label();
            this.nonAlcoholButton = new System.Windows.Forms.Button();
            this.alcoholButton = new System.Windows.Forms.Button();
            this.lblDRINKPRICEINSERT = new System.Windows.Forms.Label();
            this.lblDRINKSUPPLYINSERT = new System.Windows.Forms.Label();
            this.lblDRINKNAMEINSERT = new System.Windows.Forms.Label();
            this.drinkDeleteButton = new System.Windows.Forms.Button();
            this.drinkUpdateButton = new System.Windows.Forms.Button();
            this.drinkAddButton = new System.Windows.Forms.Button();
            this.drinkPriceTextBox = new System.Windows.Forms.TextBox();
            this.drinkSupplyTextBox = new System.Windows.Forms.TextBox();
            this.drinkNameTextBox = new System.Windows.Forms.TextBox();
            this.listViewDrinksSupplies = new System.Windows.Forms.ListView();
            this.drinkidclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinknameclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinksupplyclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkpriceclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkamountclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkwarningclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDRINKSUPPLIES = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDrinksSupplies.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(627, 0);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(311, 270);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksSuppliesStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksSuppliesStripMenuItem
            // 
            this.drinksSuppliesStripMenuItem.Name = "drinksSuppliesStripMenuItem";
            this.drinksSuppliesStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.drinksSuppliesStripMenuItem.Text = "Drinks Supplies";
            this.drinksSuppliesStripMenuItem.Click += new System.EventHandler(this.drinksSuppliesStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(12, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(938, 466);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(12, 24);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(938, 466);
            this.pnlStudents.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB,
            this.StudentRoom});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            this.studentName.Width = 110;
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 80;
            // 
            // StudentRoom
            // 
            this.StudentRoom.Text = "Room";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnlDrinksSupplies
            // 
            this.pnlDrinksSupplies.Controls.Add(this.lblALTERDRINKSUPPLIES);
            this.pnlDrinksSupplies.Controls.Add(this.nonAlcoholButton);
            this.pnlDrinksSupplies.Controls.Add(this.alcoholButton);
            this.pnlDrinksSupplies.Controls.Add(this.lblDRINKPRICEINSERT);
            this.pnlDrinksSupplies.Controls.Add(this.lblDRINKSUPPLYINSERT);
            this.pnlDrinksSupplies.Controls.Add(this.lblDRINKNAMEINSERT);
            this.pnlDrinksSupplies.Controls.Add(this.drinkDeleteButton);
            this.pnlDrinksSupplies.Controls.Add(this.drinkUpdateButton);
            this.pnlDrinksSupplies.Controls.Add(this.drinkAddButton);
            this.pnlDrinksSupplies.Controls.Add(this.drinkPriceTextBox);
            this.pnlDrinksSupplies.Controls.Add(this.drinkSupplyTextBox);
            this.pnlDrinksSupplies.Controls.Add(this.drinkNameTextBox);
            this.pnlDrinksSupplies.Controls.Add(this.listViewDrinksSupplies);
            this.pnlDrinksSupplies.Controls.Add(this.lblDRINKSUPPLIES);
            this.pnlDrinksSupplies.Location = new System.Drawing.Point(9, 27);
            this.pnlDrinksSupplies.Name = "pnlDrinksSupplies";
            this.pnlDrinksSupplies.Size = new System.Drawing.Size(938, 466);
            this.pnlDrinksSupplies.TabIndex = 6;
            // 
            // lblALTERDRINKSUPPLIES
            // 
            this.lblALTERDRINKSUPPLIES.AutoSize = true;
            this.lblALTERDRINKSUPPLIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALTERDRINKSUPPLIES.Location = new System.Drawing.Point(618, 42);
            this.lblALTERDRINKSUPPLIES.Name = "lblALTERDRINKSUPPLIES";
            this.lblALTERDRINKSUPPLIES.Size = new System.Drawing.Size(121, 17);
            this.lblALTERDRINKSUPPLIES.TabIndex = 17;
            this.lblALTERDRINKSUPPLIES.Text = "Alter Drink Supply";
            // 
            // nonAlcoholButton
            // 
            this.nonAlcoholButton.Location = new System.Drawing.Point(694, 183);
            this.nonAlcoholButton.Name = "nonAlcoholButton";
            this.nonAlcoholButton.Size = new System.Drawing.Size(84, 23);
            this.nonAlcoholButton.TabIndex = 16;
            this.nonAlcoholButton.Text = "Alcohol Free";
            this.nonAlcoholButton.UseVisualStyleBackColor = true;
            // 
            // alcoholButton
            // 
            this.alcoholButton.Location = new System.Drawing.Point(601, 183);
            this.alcoholButton.Name = "alcoholButton";
            this.alcoholButton.Size = new System.Drawing.Size(87, 23);
            this.alcoholButton.TabIndex = 15;
            this.alcoholButton.Text = "Alcohol";
            this.alcoholButton.UseVisualStyleBackColor = true;
            this.alcoholButton.Click += new System.EventHandler(this.alcoholButton_Click);
            // 
            // lblDRINKPRICEINSERT
            // 
            this.lblDRINKPRICEINSERT.AutoSize = true;
            this.lblDRINKPRICEINSERT.Location = new System.Drawing.Point(561, 149);
            this.lblDRINKPRICEINSERT.Name = "lblDRINKPRICEINSERT";
            this.lblDRINKPRICEINSERT.Size = new System.Drawing.Size(34, 13);
            this.lblDRINKPRICEINSERT.TabIndex = 14;
            this.lblDRINKPRICEINSERT.Text = "Price:";
            // 
            // lblDRINKSUPPLYINSERT
            // 
            this.lblDRINKSUPPLYINSERT.AutoSize = true;
            this.lblDRINKSUPPLYINSERT.Location = new System.Drawing.Point(553, 114);
            this.lblDRINKSUPPLYINSERT.Name = "lblDRINKSUPPLYINSERT";
            this.lblDRINKSUPPLYINSERT.Size = new System.Drawing.Size(42, 13);
            this.lblDRINKSUPPLYINSERT.TabIndex = 13;
            this.lblDRINKSUPPLYINSERT.Text = "Supply:";
            // 
            // lblDRINKNAMEINSERT
            // 
            this.lblDRINKNAMEINSERT.AutoSize = true;
            this.lblDRINKNAMEINSERT.Location = new System.Drawing.Point(557, 81);
            this.lblDRINKNAMEINSERT.Name = "lblDRINKNAMEINSERT";
            this.lblDRINKNAMEINSERT.Size = new System.Drawing.Size(38, 13);
            this.lblDRINKNAMEINSERT.TabIndex = 12;
            this.lblDRINKNAMEINSERT.Text = "Name:";
            // 
            // drinkDeleteButton
            // 
            this.drinkDeleteButton.Location = new System.Drawing.Point(601, 296);
            this.drinkDeleteButton.Name = "drinkDeleteButton";
            this.drinkDeleteButton.Size = new System.Drawing.Size(177, 31);
            this.drinkDeleteButton.TabIndex = 11;
            this.drinkDeleteButton.Text = "Delete";
            this.drinkDeleteButton.UseVisualStyleBackColor = true;
            this.drinkDeleteButton.Click += new System.EventHandler(this.drinkDeleteButton_Click);
            // 
            // drinkUpdateButton
            // 
            this.drinkUpdateButton.Location = new System.Drawing.Point(601, 259);
            this.drinkUpdateButton.Name = "drinkUpdateButton";
            this.drinkUpdateButton.Size = new System.Drawing.Size(177, 31);
            this.drinkUpdateButton.TabIndex = 10;
            this.drinkUpdateButton.Text = "Update";
            this.drinkUpdateButton.UseVisualStyleBackColor = true;
            this.drinkUpdateButton.Click += new System.EventHandler(this.drinkUpdateButton_Click);
            // 
            // drinkAddButton
            // 
            this.drinkAddButton.Location = new System.Drawing.Point(601, 221);
            this.drinkAddButton.Name = "drinkAddButton";
            this.drinkAddButton.Size = new System.Drawing.Size(177, 32);
            this.drinkAddButton.TabIndex = 9;
            this.drinkAddButton.Text = "Add";
            this.drinkAddButton.UseVisualStyleBackColor = true;
            this.drinkAddButton.Click += new System.EventHandler(this.drinkAddButton_Click);
            // 
            // drinkPriceTextBox
            // 
            this.drinkPriceTextBox.Location = new System.Drawing.Point(601, 146);
            this.drinkPriceTextBox.Name = "drinkPriceTextBox";
            this.drinkPriceTextBox.Size = new System.Drawing.Size(177, 20);
            this.drinkPriceTextBox.TabIndex = 8;
            // 
            // drinkSupplyTextBox
            // 
            this.drinkSupplyTextBox.Location = new System.Drawing.Point(601, 111);
            this.drinkSupplyTextBox.Name = "drinkSupplyTextBox";
            this.drinkSupplyTextBox.Size = new System.Drawing.Size(177, 20);
            this.drinkSupplyTextBox.TabIndex = 7;
            // 
            // drinkNameTextBox
            // 
            this.drinkNameTextBox.Location = new System.Drawing.Point(601, 78);
            this.drinkNameTextBox.Name = "drinkNameTextBox";
            this.drinkNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.drinkNameTextBox.TabIndex = 6;
            // 
            // listViewDrinksSupplies
            // 
            this.listViewDrinksSupplies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.drinkidclm,
            this.drinknameclm,
            this.drinksupplyclm,
            this.drinkpriceclm,
            this.drinkamountclm,
            this.drinkwarningclm});
            this.listViewDrinksSupplies.FullRowSelect = true;
            this.listViewDrinksSupplies.GridLines = true;
            this.listViewDrinksSupplies.HideSelection = false;
            this.listViewDrinksSupplies.Location = new System.Drawing.Point(18, 42);
            this.listViewDrinksSupplies.Name = "listViewDrinksSupplies";
            this.listViewDrinksSupplies.Size = new System.Drawing.Size(512, 285);
            this.listViewDrinksSupplies.TabIndex = 5;
            this.listViewDrinksSupplies.UseCompatibleStateImageBehavior = false;
            this.listViewDrinksSupplies.View = System.Windows.Forms.View.Details;
            // 
            // drinkidclm
            // 
            this.drinkidclm.Text = "ID";
            this.drinkidclm.Width = 24;
            // 
            // drinknameclm
            // 
            this.drinknameclm.Text = "Name";
            this.drinknameclm.Width = 89;
            // 
            // drinksupplyclm
            // 
            this.drinksupplyclm.Text = "Supply";
            this.drinksupplyclm.Width = 74;
            // 
            // drinkpriceclm
            // 
            this.drinkpriceclm.Text = "Price";
            this.drinkpriceclm.Width = 66;
            // 
            // drinkamountclm
            // 
            this.drinkamountclm.Text = "Amount Sold";
            this.drinkamountclm.Width = 74;
            // 
            // drinkwarningclm
            // 
            this.drinkwarningclm.Text = "Warning";
            this.drinkwarningclm.Width = 179;
            // 
            // lblDRINKSUPPLIES
            // 
            this.lblDRINKSUPPLIES.AutoSize = true;
            this.lblDRINKSUPPLIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRINKSUPPLIES.Location = new System.Drawing.Point(10, 10);
            this.lblDRINKSUPPLIES.Name = "lblDRINKSUPPLIES";
            this.lblDRINKSUPPLIES.Size = new System.Drawing.Size(182, 29);
            this.lblDRINKSUPPLIES.TabIndex = 3;
            this.lblDRINKSUPPLIES.Text = "Drinks Supplies";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnlDrinksSupplies);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDrinksSupplies.ResumeLayout(false);
            this.pnlDrinksSupplies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ColumnHeader StudentRoom;
        private System.Windows.Forms.Panel pnlDrinksSupplies;
        private System.Windows.Forms.ListView listViewDrinksSupplies;
        private System.Windows.Forms.ColumnHeader drinknameclm;
        private System.Windows.Forms.ColumnHeader drinksupplyclm;
        private System.Windows.Forms.ColumnHeader drinkpriceclm;
        private System.Windows.Forms.ColumnHeader drinkamountclm;
        private System.Windows.Forms.Label lblDRINKSUPPLIES;
        private System.Windows.Forms.ColumnHeader drinkwarningclm;
        private System.Windows.Forms.Label lblDRINKPRICEINSERT;
        private System.Windows.Forms.Label lblDRINKSUPPLYINSERT;
        private System.Windows.Forms.Label lblDRINKNAMEINSERT;
        private System.Windows.Forms.Button drinkDeleteButton;
        private System.Windows.Forms.Button drinkUpdateButton;
        private System.Windows.Forms.Button drinkAddButton;
        private System.Windows.Forms.TextBox drinkPriceTextBox;
        private System.Windows.Forms.TextBox drinkSupplyTextBox;
        private System.Windows.Forms.TextBox drinkNameTextBox;
        private System.Windows.Forms.Button nonAlcoholButton;
        private System.Windows.Forms.Button alcoholButton;
        private System.Windows.Forms.Label lblALTERDRINKSUPPLIES;
        private System.Windows.Forms.ColumnHeader drinkidclm;
        private System.Windows.Forms.ToolStripMenuItem drinksSuppliesStripMenuItem;
    }
}

