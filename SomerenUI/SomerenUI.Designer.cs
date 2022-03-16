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
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.roomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.listViewTeacher = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblCustomersOutput = new System.Windows.Forms.Label();
            this.lblTurnoverOutput = new System.Windows.Forms.Label();
            this.lblSalesOutput = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblTurnover = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.revenueEndDate = new System.Windows.Forms.MonthCalendar();
            this.revenueStartDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.drinksSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStudents.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(470, 0);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(233, 219);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.revenueReportToolStripMenuItem,
            this.drinksSuppliesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
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
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
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
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(9, 22);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(704, 379);
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
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.lbl_Rooms);
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Location = new System.Drawing.Point(12, 24);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(938, 466);
            this.pnlRooms.TabIndex = 4;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Location = new System.Drawing.Point(13, 13);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(166, 13);
            this.lbl_Rooms.TabIndex = 1;
            this.lbl_Rooms.Text = "Welcome to the Someren Rooms!";
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomID,
            this.capacity,
            this.roomType});
            this.listViewRooms.GridLines = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(16, 42);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(766, 307);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomID
            // 
            this.roomID.Text = "ID";
            // 
            // capacity
            // 
            this.capacity.Text = "Capacity";
            // 
            // roomType
            // 
            this.roomType.Text = "Room Type";
            this.roomType.Width = 70;
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
            this.listViewStudents.Location = new System.Drawing.Point(12, 34);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(576, 250);
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
            this.StudentRoom.Text = "Room ID";
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
            // pnlTeacher
            // 
            this.pnlTeacher.Controls.Add(this.listViewTeacher);
            this.pnlTeacher.Controls.Add(this.pictureBox2);
            this.pnlTeacher.Controls.Add(this.teacherLabel);
            this.pnlTeacher.Location = new System.Drawing.Point(9, 20);
            this.pnlTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(704, 379);
            this.pnlTeacher.TabIndex = 6;
            // 
            // listViewTeacher
            // 
            this.listViewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeacher.GridLines = true;
            this.listViewTeacher.HideSelection = false;
            this.listViewTeacher.Location = new System.Drawing.Point(12, 34);
            this.listViewTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.listViewTeacher.Name = "listViewTeacher";
            this.listViewTeacher.Size = new System.Drawing.Size(576, 250);
            this.listViewTeacher.TabIndex = 5;
            this.listViewTeacher.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(604, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(10, 10);
            this.teacherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(103, 29);
            this.teacherLabel.TabIndex = 3;
            this.teacherLabel.Text = "Teacher";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.Controls.Add(this.lblCustomersOutput);
            this.pnlRevenue.Controls.Add(this.lblTurnoverOutput);
            this.pnlRevenue.Controls.Add(this.lblSalesOutput);
            this.pnlRevenue.Controls.Add(this.lblCustomers);
            this.pnlRevenue.Controls.Add(this.lblTurnover);
            this.pnlRevenue.Controls.Add(this.lblSales);
            this.pnlRevenue.Controls.Add(this.btnGenerateReport);
            this.pnlRevenue.Controls.Add(this.lblToDate);
            this.pnlRevenue.Controls.Add(this.lblFromDate);
            this.pnlRevenue.Controls.Add(this.revenueEndDate);
            this.pnlRevenue.Controls.Add(this.revenueStartDate);
            this.pnlRevenue.Controls.Add(this.label1);
            this.pnlRevenue.Location = new System.Drawing.Point(9, 22);
            this.pnlRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(712, 388);
            this.pnlRevenue.TabIndex = 7;
            // 
            // lblCustomersOutput
            // 
            this.lblCustomersOutput.AutoSize = true;
            this.lblCustomersOutput.Location = new System.Drawing.Point(484, 125);
            this.lblCustomersOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomersOutput.Name = "lblCustomersOutput";
            this.lblCustomersOutput.Size = new System.Drawing.Size(13, 13);
            this.lblCustomersOutput.TabIndex = 11;
            this.lblCustomersOutput.Text = "0";
            // 
            // lblTurnoverOutput
            // 
            this.lblTurnoverOutput.AutoSize = true;
            this.lblTurnoverOutput.Location = new System.Drawing.Point(484, 102);
            this.lblTurnoverOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnoverOutput.Name = "lblTurnoverOutput";
            this.lblTurnoverOutput.Size = new System.Drawing.Size(13, 13);
            this.lblTurnoverOutput.TabIndex = 10;
            this.lblTurnoverOutput.Text = "0";
            // 
            // lblSalesOutput
            // 
            this.lblSalesOutput.AutoSize = true;
            this.lblSalesOutput.Location = new System.Drawing.Point(484, 78);
            this.lblSalesOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesOutput.Name = "lblSalesOutput";
            this.lblSalesOutput.Size = new System.Drawing.Size(13, 13);
            this.lblSalesOutput.TabIndex = 9;
            this.lblSalesOutput.Text = "0";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(413, 125);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 8;
            this.lblCustomers.Text = "Customers";
            // 
            // lblTurnover
            // 
            this.lblTurnover.AutoSize = true;
            this.lblTurnover.Location = new System.Drawing.Point(413, 102);
            this.lblTurnover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnover.Name = "lblTurnover";
            this.lblTurnover.Size = new System.Drawing.Size(53, 13);
            this.lblTurnover.TabIndex = 7;
            this.lblTurnover.Text = "Turnover:";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(413, 78);
            this.lblSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(36, 13);
            this.lblSales.TabIndex = 6;
            this.lblSales.Text = "Sales:";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(140, 265);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(77, 20);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(193, 56);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(46, 13);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(15, 56);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(56, 13);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            // 
            // revenueEndDate
            // 
            this.revenueEndDate.Location = new System.Drawing.Point(183, 57);
            this.revenueEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.revenueEndDate.MaxDate = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            this.revenueEndDate.Name = "revenueEndDate";
            this.revenueEndDate.TabIndex = 2;
            this.revenueEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.revenueEndDate_DateChanged);
            // 
            // revenueStartDate
            // 
            this.revenueStartDate.Location = new System.Drawing.Point(14, 57);
            this.revenueStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.revenueStartDate.MaxDate = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            this.revenueStartDate.Name = "revenueStartDate";
            this.revenueStartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate a revenue report";
            // 
            // drinksSuppliesToolStripMenuItem
            // 
            this.drinksSuppliesToolStripMenuItem.Name = "drinksSuppliesToolStripMenuItem";
            this.drinksSuppliesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.drinksSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            this.drinksSuppliesToolStripMenuItem.Click += new System.EventHandler(this.drinksSuppliesToolStripMenuItem_Click);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 410);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRevenue);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlStudents);
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
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
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
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader roomID;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader roomType;
        private System.Windows.Forms.ColumnHeader StudentRoom;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.ListView listViewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.MonthCalendar revenueEndDate;
        private System.Windows.Forms.MonthCalendar revenueStartDate;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblTurnover;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblTurnoverOutput;
        private System.Windows.Forms.Label lblSalesOutput;
        private System.Windows.Forms.Label lblCustomersOutput;
        private System.Windows.Forms.ToolStripMenuItem drinksSuppliesToolStripMenuItem;
    }
}

