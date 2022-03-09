using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // clear the listview before filling it again
                    listViewStudents.Clear();

                    //how the items are viewed
                    listViewStudents.View = View.Details;
                    listViewStudents.GridLines = true;
                    listViewStudents.FullRowSelect = true;

                    //column header (names, width)
                    listViewStudents.Columns.Add("Student ID", 65);
                    listViewStudents.Columns.Add("Student Name", 120);
                    listViewStudents.Columns.Add("Date of Birth", 75);
                    listViewStudents.Columns.Add("Room ID", 60);


                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;


                    foreach (Student s in studentList)
                    {
                        //string array to separate the object fields and place them in each item
                        string[] student = { s.Id.ToString(), s.FullName, s.BirthDate.ToString("dd/MM/yyyy"), s.RoomId.ToString() };
                        ListViewItem li = new ListViewItem(student);
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }
    }
}
