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
        private bool drinkIsAlcohol;
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
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();

                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();

                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents();

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
                pnlDrinksSupplies.Hide();

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
                pnlDrinksSupplies.Hide();

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
            else if (panelName == "Drinks Supplies")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeacher.Hide();
                pnlRooms.Hide();
                pnlRevenue.Hide();

                pnlDrinksSupplies.Show();

                try
                {
                    //List with Drinks directly from DB
                    DrinkSupplyService supplyService = new DrinkSupplyService();
                    List<Drink> drinksSupplies = supplyService.GetDrinksSupplies();

                    listViewDrinksSupplies.Items.Clear();

                    foreach (Drink supply in drinksSupplies)
                    {
                        ListViewItem supplyList = new ListViewItem(supply.DrinkId.ToString());
                        supplyList.SubItems.Add(supply.DrinkName.ToString());
                        supplyList.SubItems.Add(supply.Stock.ToString());
                        supplyList.SubItems.Add($"{supply.Price} token(s)");
                        supplyList.SubItems.Add(supply.AmountSold.ToString());

                        string warning;

                        if (supply.Stock < 10)
                        {
                            warning = "Stock nearly depleted";
                        }
                        else warning = "Stock sufficient";

                        supplyList.SubItems.Add(warning);

                        listViewDrinksSupplies.Items.Add(supplyList);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the Drinks Supplies: " + e.Message);
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
                pnlDrinksSupplies.Hide();

                // show students
                pnlRevenue.Show();
            }
            else if (panelName == "Activities")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeacher.Hide();
                pnlRooms.Hide();
                pnlRevenue.Hide();

                //show Drink Supplies
                pnlDrinksSupplies.Show();
                try
                {
                    ActivityService activityService = new ActivityService();
                    List<Activity> activities = activityService.GetActivities();

                    listViewActivity.Items.Clear();

                    foreach (Activity activity in activities)
                    {
                        ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                        listViewItem.SubItems.Add(activity.ActivityDescription);
                        listViewItem.SubItems.Add(activity.ActivityStartDateTime.ToString());
                        listViewItem.SubItems.Add(activity.ActivityEndDateTime.ToString());
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading activity: " + e.Message);
                }
            }
        }
        //Confirm Alcohol
        private void alcoholButton_Click(object sender, EventArgs e)
        {
            drinkIsAlcohol = true; 
        }
        //Confirm Alcohol-Free
        private void nonAlcoholButton_Click(object sender, EventArgs e)
        {
            drinkIsAlcohol = false;
        }
        //ADD drinks to List AND Database (DONE)
        private void drinkAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(drinkNameTextBox.Text) || string.IsNullOrEmpty(drinkSupplyTextBox.Text) || string.IsNullOrEmpty(drinkPriceTextBox.Text))
                {
                    return;
                }
                else
                {
                    if (listViewDrinksSupplies.FindItemWithText(drinkNameTextBox.Text) != null)
                    {
                        MessageBox.Show($"{drinkNameTextBox.Text} already exist ");
                        drinkNameTextBox.Clear();
                        drinkPriceTextBox.Clear();
                        drinkSupplyTextBox.Clear();
                        return;
                    }

                    DrinkSupplyService service = new DrinkSupplyService();

                    ListViewItem supplyList = new ListViewItem("new");
                    supplyList.SubItems.Add(drinkNameTextBox.Text);
                    supplyList.SubItems.Add(drinkSupplyTextBox.Text);
                    supplyList.SubItems.Add($"{drinkPriceTextBox.Text} token(s)");
                    supplyList.SubItems.Add(0.ToString());

                    string warning;

                    if (int.Parse(drinkSupplyTextBox.Text) < 10)
                    {
                        warning = "Stock nearly depleted";
                    }
                    else warning = "Stock sufficient";

                    supplyList.SubItems.Add(warning);

                    listViewDrinksSupplies.Items.Add(supplyList);

                    int vatId;
                    if (drinkIsAlcohol)
                    {
                        vatId = 2;
                    }
                    else vatId = 1;

                    Drink drink = new Drink(drinkNameTextBox.Text, int.Parse(drinkSupplyTextBox.Text), int.Parse(drinkPriceTextBox.Text), vatId, 0);

                    service.AddDrinkSupply(drink);

                    MessageBox.Show($"Succesfully added: {drink.DrinkName}!");
                }
            }
            catch (Exception Add)
            {
                MessageBox.Show(Add.Message);
            }
            finally
            {
                drinkNameTextBox.Clear();
                drinkPriceTextBox.Clear();
                drinkSupplyTextBox.Clear();
            }
        }
        //Update Drinks from ListView to Database (DONE)
        private void drinkUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkSupplyService supplyService = new DrinkSupplyService();
                List<Drink> drinksSupplies = supplyService.GetDrinksSupplies();
                Drink drink = null;

                foreach (Drink supply in drinksSupplies)
                {
                    if (supply.DrinkId == int.Parse(listViewDrinksSupplies.SelectedItems[0].SubItems[0].Text))
                    {
                        drink = supply;
                    }
                }

                if (!string.IsNullOrEmpty(drinkNameTextBox.Text))
                {
                    if (listViewDrinksSupplies.FindItemWithText(drinkNameTextBox.Text) != null)
                    {
                        MessageBox.Show($"{drinkNameTextBox.Text} already exist ");
                        drinkNameTextBox.Clear();
                        drinkPriceTextBox.Clear();
                        drinkSupplyTextBox.Clear();
                        return;
                    }
                    listViewDrinksSupplies.SelectedItems[0].SubItems[1].Text = drinkNameTextBox.Text;
                    drink.DrinkName = drinkNameTextBox.Text;
                }
                if (!string.IsNullOrEmpty(drinkSupplyTextBox.Text))
                {
                    listViewDrinksSupplies.SelectedItems[0].SubItems[2].Text = drinkSupplyTextBox.Text;
                    drink.Stock = int.Parse(drinkSupplyTextBox.Text);

                    string warning;

                    if (int.Parse(drinkSupplyTextBox.Text) < 10)
                    {
                        warning = "Stock nearly depleted";
                    }
                    else warning = "Stock sufficient";

                    listViewDrinksSupplies.SelectedItems[0].SubItems[5].Text = warning;

                }
                if (!string.IsNullOrEmpty(drinkPriceTextBox.Text))
                {
                    listViewDrinksSupplies.SelectedItems[0].SubItems[3].Text = $"{drinkPriceTextBox.Text} token(s)";
                    drink.Price = int.Parse(drinkPriceTextBox.Text);
                }

                supplyService.UpdateDrinkSupply(drink);
            }
            catch(Exception update)
            {
                MessageBox.Show(update.Message);
            }
            finally
            {
                drinkNameTextBox.Clear();
                drinkPriceTextBox.Clear();
                drinkSupplyTextBox.Clear();
            }
        }

        //Delete Drinks from ListView AND Database (DONE)
        private void drinkDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDrinksSupplies.Items.Count > 0)
                {
                    DrinkSupplyService supplyService = new DrinkSupplyService();
                    List<Drink> drinksSupplies = supplyService.GetDrinksSupplies();

                    foreach (Drink supply in drinksSupplies)
                    {
                        if (supply.DrinkName == listViewDrinksSupplies.SelectedItems[0].SubItems[1].Text)
                        {
                            supplyService.DeleteDrinkSupply(supply);
                        }
                    }
                    listViewDrinksSupplies.Items.Remove(listViewDrinksSupplies.SelectedItems[0]);
                }
                else return;
            }
            catch (Exception delete)
            {
                MessageBox.Show("Cannot delete drink Supply when it has sales: " + delete.Message);
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
        private void drinksSuppliesStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks Supplies");
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
                MessageBox.Show("Something went wrong while generating the revenue report: " + ex.Message);
            }
        }
        private void revenueEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            revenueStartDate.MaxDate = e.Start;
        }

        private void activityAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityService activityService = new ActivityService();
                if (string.IsNullOrEmpty(activityDescriptionTextbox.Text) || string.IsNullOrEmpty(activityStartTextbox.Text) || string.IsNullOrEmpty(activityEndTextbox.Text))
                {
                    return;
                }
                else
                {
                    if (listViewActivity.FindItemWithText(activityDescriptionTextbox.Text) != null)
                    {
                        MessageBox.Show($"{activityDescriptionTextbox.Text} already exist");
                        activityStartTextbox.Clear();
                        activityEndTextbox.Clear();
                        activityDescriptionTextbox.Clear();
                    }
                }
                Activity activity = new Activity(0, activityDescriptionTextbox.Text, DateTime.Parse(activityStartTextbox.Text), DateTime.Parse(activityEndTextbox.Text));

                activityService.AddActivity(activity);

                ListViewItem activityItem = new ListViewItem(activityDescriptionTextbox.Text);
                activityItem.SubItems.Add(activityStartTextbox.Text);
                activityItem.SubItems.Add(activityEndTextbox.Text);
                listViewActivity.Items.Add(activityItem);

                MessageBox.Show($"Succesfully added: {activity.ActivityDescription}");
            }
            catch (Exception Add)
            {
                MessageBox.Show(Add.Message);
            }
            finally
            {
                activityDescriptionTextbox.Clear();
                activityStartTextbox.Clear();
                activityEndTextbox.Clear();
            }
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void updateActivityButton_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityService activityService = new ActivityService();
                List<Activity> activities = activityService.GetActivities();
                Activity activity = null;

                foreach (Activity alterActivity in activities)
                {
                    if (alterActivity.ActivityId == int.Parse(listViewActivity.SelectedItems[0].SubItems[0].Text))
                    {
                        activity = alterActivity;
                    }
                }

                if (!string.IsNullOrEmpty(activityDescriptionTextbox.Text))
                {
                    if (listViewActivity.FindItemWithText(activityDescriptionTextbox.Text) != null)
                    {
                        MessageBox.Show($"{activityDescriptionTextbox.Text} already exist");
                        activityDescriptionTextbox.Clear();
                        activityStartTextbox.Clear();
                        activityEndTextbox.Clear();
                        return;
                    }
                    listViewActivity.SelectedItems[0].SubItems[1].Text = activityDescriptionTextbox.Text;
                    activity.ActivityDescription = activityDescriptionTextbox.Text;
                }
                if (!string.IsNullOrEmpty(activityStartTextbox.Text))
                {
                    listViewActivity.SelectedItems[0].SubItems[2].Text = activityStartTextbox.Text;
                    activity.ActivityStartDateTime = DateTime.Parse(activityStartTextbox.Text);
                }
                if (!string.IsNullOrEmpty(activityEndTextbox.Text))
                {
                    listViewActivity.SelectedItems[0].SubItems[3].Text = activityEndTextbox.Text;
                    activity.ActivityEndDateTime = DateTime.Parse(activityEndTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                activityDescriptionTextbox.Clear();
                activityStartTextbox.Clear();
                activityEndTextbox.Clear();
            }
        }

        private void deleteActivityButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this activity?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ActivityService activityService = new ActivityService();
                    List<Activity> activities = activityService.GetActivities();

                    foreach (Activity activity in activities)
                    {
                        if (activity.ActivityDescription == listViewActivity.SelectedItems[0].SubItems[1].Text)
                        {
                            activityService.DeleteActivity(activity);
                        }
                    }
                    listViewActivity.Items.Remove(listViewActivity.SelectedItems[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete activity: " + ex.Message);
                }
            }
            
        }
    }
}
