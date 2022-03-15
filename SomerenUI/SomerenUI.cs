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
        private RevenueService revenueService;
        public SomerenUI()
        {
            revenueService = new RevenueService();
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
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listview before filling it again
                    listViewStudents.Items.Clear();

                    foreach (Student student in studentList)
                    {
                        ListViewItem li = new ListViewItem(student.Id.ToString());
                        li.SubItems.Add(student.FullName.ToString());
                        li.SubItems.Add(student.BirthDate.ToString("dd/MM/yyyy"));
                        li.SubItems.Add(student.RoomId.ToString());
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Lecturers")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlRevenue.Hide();

                // show students
                pnlTeacher.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    TeacherService teacherService = new TeacherService(); ;
                    List<Teacher> teacherList = teacherService.GetTeachers(); ;

                    // clear the listview before filling it again
                    listViewTeacher.Clear();
                    listViewTeacher.View = View.Details;
                    listViewTeacher.Columns.Add("Teacher ID", 100);
                    listViewTeacher.Columns.Add("First Name", 100);
                    listViewTeacher.Columns.Add("Last Name", 100);
                    listViewTeacher.Columns.Add("Room ID", 100);

                    foreach (Teacher teacher in teacherList)
                    {
                        //listViewTeacher.Items.Add(teacher.TeacherId.ToString());

                        ListViewItem item = new ListViewItem(teacher.TeacherId.ToString());
                        item.SubItems.Add(teacher.FirstName.ToString());
                        item.SubItems.Add(teacher.LastName.ToString());
                        item.SubItems.Add(teacher.RoomId.ToString());

                        listViewTeacher.Items.Add(item);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeacher.Hide();
                pnlStudents.Hide();
                pnlRevenue.Hide();

                // show students
                pnlRooms.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    RoomService roomService = new RoomService(); ;
                    List<Room> roomList = roomService.GetRooms(); ;

                    // clear the listview before filling it again
                    listViewRooms.Items.Clear();

                    foreach (Room room in roomList)
                    {
                        ListViewItem li = new ListViewItem(room.Id.ToString());
                        li.SubItems.Add(room.Capacity.ToString());
                        li.SubItems.Add(room.Capacity == 1 ? "Teacher" : "Student");

                        listViewRooms.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
            else if (panelName == "Generate Report")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeacher.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();

                // show students
                pnlRevenue.Show();

                try
                {
                    //RevenueService revenueService = new RevenueService(); ;
                    //int sales = revenueService.GetSales(revenueStartDate.DateSelected.Value, revenueEndDate.DateSelected.Value);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Lecturers");
        }
        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Generate Report");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                lblSalesOutput.Text = revenueService.GetSales(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start).ToString();
                lblTurnoverOutput.Text = revenueService.GetTurnover(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start).ToString();
                lblCustomersOutput.Text = revenueService.GetCustomers(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + ex.Message);
            }
        }

        private void revenueEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            revenueStartDate.MaxDate = e.Start.AddDays(-1);
        }
    }
}
