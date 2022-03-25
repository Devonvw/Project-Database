using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        private RevenueService revenueService;
        private OrderService orderService;
        private ActivityService activityService;
        private bool drinkIsAlcohol;
        private List<OrderLine> orderLines;

        public SomerenUI()
        {
            revenueService = new RevenueService();
            activityService = new ActivityService();
            orderService = new OrderService();
            orderLines = new List<OrderLine>();

            InitializeComponent();
        }
        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel(Panel.Dashboard);
        }   
        private void showPanel(Panel panelName)
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlTeacher.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlRevenue.Hide();
            pnlDrinksSupplies.Hide();
            pnlActivityParticipants.Hide();
            pnlCashRegister.Hide();

            if (panelName == Panel.Dashboard)
            {
<<<<<<< HEAD
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();
                pnlActivity.Hide();

=======
>>>>>>> Devon
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == Panel.Students)
            {
<<<<<<< HEAD
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlTeacher.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();
                pnlActivity.Hide();


=======
>>>>>>> Devon
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
            else if (panelName == Panel.Teachers)
            {
<<<<<<< HEAD
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();
                pnlStudents.Hide();
                pnlActivity.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();

                // show students
=======
                // show teachers
>>>>>>> Devon
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
            else if (panelName == Panel.Rooms)
            {
<<<<<<< HEAD
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeacher.Hide();
                pnlActivity.Hide();
                pnlStudents.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();

=======
>>>>>>> Devon
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
            else if (panelName == Panel.DrinksSupplies)
            {
<<<<<<< HEAD
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlActivity.Hide();
                pnlTeacher.Hide();
                pnlRooms.Hide();
                pnlRevenue.Hide();

=======
                //show Drink Supplies
>>>>>>> Devon
                pnlDrinksSupplies.Show();

                try
                {
                    DrinkSupplyService supplyService = new DrinkSupplyService();
                    List<Drink> drinksSupplies = supplyService.GetDrinksSupplies();

                    listViewDrinksSupplies.Items.Clear();

                    foreach (Drink supply in drinksSupplies)
                    {
                        ListViewItem supplyList = new ListViewItem(supply.Name.ToString());
                        //supplyList.SubItems.Add(supply.Name.ToString());
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
            else if (panelName == Panel.CashRegister)
            {
<<<<<<< HEAD
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlTeacher.Hide();
                pnlActivity.Hide();
                pnlStudents.Hide();
                pnlRooms.Hide();
                pnlDrinksSupplies.Hide();
=======
                //show cash register
                pnlCashRegister.Show();
>>>>>>> Devon

                // 
                try
                {
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();


                    // clear the listview before filling it again
                    studentListView.Items.Clear();

                    foreach (Student student in studentList)
                    {
                        ListViewItem li = new ListViewItem(student.Id.ToString());
                        li.SubItems.Add(student.FullName.ToString());
                        li.SubItems.Add(student.BirthDate.ToString("dd/MM/yyyy"));
                        studentListView.Items.Add(li);
                    }

                    // Drinks
                    DrinkService drinkService = new DrinkService();
                    List<Drink> drinkList = drinkService.GetDrinks();

                    // clear the listview before filling it again
                    drinkListView.Items.Clear();

                    foreach (Drink drink in drinkList)
                    {
                        ListViewItem li = new ListViewItem(drink.Id.ToString());
                        li.SubItems.Add(drink.Name);
                        li.SubItems.Add(drink.Price.ToString());
                        li.SubItems.Add(drink.VatId.ToString());
                        drinkListView.Items.Add(li);

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while calculating price: " + e.Message);
                }
            }
            else if (panelName == Panel.Revenue)
            {
                // show report
                pnlRevenue.Show();
            }
<<<<<<< HEAD
            else if (panelName == "Activities")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlTeacher.Hide();
                pnlRooms.Hide();
                pnlRevenue.Hide();
                pnlDrinksSupplies.Hide();

                //show Drink Supplies
                pnlActivity.Show();

                try
                {
                    ActivityService activityService = new ActivityService();
                    List<Activity> activities = activityService.GetActivity();

                    listViewActivity.Items.Clear();
=======
            else if (panelName == Panel.ActivityParticipants)
            {
                // show students
                pnlActivityParticipants.Show();

                try
                {
                    List<Activity> activities = activityService.GetActivity();

                    listViewActivitiesParticipants.Items.Clear();
>>>>>>> Devon

                    foreach (Activity activity in activities)
                    {
                        ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                        listViewItem.SubItems.Add(activity.ActivityDescription);
                        listViewItem.SubItems.Add(activity.ActivityStartDateTime.ToString());
                        listViewItem.SubItems.Add(activity.ActivityEndDateTime.ToString());

<<<<<<< HEAD
                        listViewActivity.Items.Add(listViewItem);
                    }

=======
                        listViewActivitiesParticipants.Items.Add(listViewItem);
                    }
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents();

                    // clear the combobox before filling it again
                    cbxAvailableParticipants.Items.Clear();

                    foreach (Student student in studentList)
                    {
                        cbxAvailableParticipants.Items.Add($"{student.FullName} - {student.Id}"); ;
                    }
>>>>>>> Devon
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

                    ListViewItem supplyList = new ListViewItem("X");
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

                    Drink drink = new Drink(0, drinkNameTextBox.Text, int.Parse(drinkSupplyTextBox.Text), int.Parse(drinkPriceTextBox.Text), vatId, 0);

                    service.AddDrinkSupply(drink);

                    MessageBox.Show($"Succesfully added: {drink.Name}!");
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
                    if (supply.Id == int.Parse(listViewDrinksSupplies.SelectedItems[0].SubItems[0].Text))
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
                    drink.Name = drinkNameTextBox.Text;
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
                        if (supply.Name == listViewDrinksSupplies.SelectedItems[0].SubItems[1].Text)
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
            showPanel(Panel.Dashboard);
        }
        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Students);
        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Rooms);
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Teachers);
        }
        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Revenue);
        }
        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.DrinksSupplies);
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                //Add 1 day, so that it also includes the to date
                lblSalesOutput.Text = revenueService.GetSales(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start.AddDays(1)).ToString();
                lblTurnoverOutput.Text = $"{revenueService.GetTurnover(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start.AddDays(1)).ToString()}$";
                lblCustomersOutput.Text = revenueService.GetCustomers(revenueStartDate.SelectionRange.Start, revenueEndDate.SelectionRange.Start.AddDays(1)).ToString();
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
<<<<<<< HEAD
        private void ActivityClear()
        {
            activityDescriptionTextbox.Clear();
            activityStartTextbox.Clear();
            activityEndTextbox.Clear();
        }
        private void activityAddButton_Click(object sender, EventArgs e)
        {
            try
            {
            ActivityService activityService = new ActivityService();
                List<Activity> list = activityService.GetActivity();

            if (string.IsNullOrEmpty(activityDescriptionTextbox.Text) || string.IsNullOrEmpty(activityStartTextbox.Text) || string.IsNullOrEmpty(activityEndTextbox.Text))
            {
                return;
            }
            else
            {
                if (listViewActivity.FindItemWithText(activityDescriptionTextbox.Text) != null)
                {
                    MessageBox.Show($"{activityDescriptionTextbox.Text} already exist");
                    ActivityClear();
                    return;
                }
                foreach (Activity a in list)
                {
                    DateTime dateTimeNow = DateTime.Now;
                    DateTime startDateTime = DateTime.Parse(activityStartTextbox.Text);
                    DateTime endDateTime = DateTime.Parse(activityEndTextbox.Text);

                    if (startDateTime >= endDateTime)
                    {
                        throw new Exception("End date time must be after start date time!");
                    }
                    else if (dateTimeNow >= startDateTime)
                    {
                        throw new Exception("You can not make an activity in the past.");
                    }
                }

                ListViewItem listViewItem = new ListViewItem(0.ToString());
                listViewItem.SubItems.Add(activityDescriptionTextbox.Text);
                listViewItem.SubItems.Add(activityStartTextbox.Text);
                listViewItem.SubItems.Add(activityEndTextbox.Text);

                listViewActivity.Items.Add(listViewItem);

                Activity activity = new Activity(0, activityDescriptionTextbox.Text, DateTime.Parse(activityStartTextbox.Text), DateTime.Parse(activityEndTextbox.Text));

                activityService.AddActivity(activity);

                MessageBox.Show($"Succesfully added: {activity.ActivityDescription}");
            }
        }
            catch (Exception Add)
            {
                MessageBox.Show("Something went wrong during add an activity" + Add.Message);
            }
            finally
            {
                ActivityClear();
}
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }
        

        private void updateActivityButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(e.ToString());
            try
            {
                if (listViewActivity.SelectedItems[0] == null)
                {
                    return;
                }
                if (string.IsNullOrEmpty(activityDescriptionTextbox.Text))
                {
                    MessageBox.Show("Please enter an activity name");
                }
                else
                {
                    Activity activity = new Activity(int.Parse(listViewActivity.SelectedItems[0].SubItems[0].Text), activityDescriptionTextbox.Text, DateTime.Parse(activityStartTextbox.Text), DateTime.Parse(activityEndTextbox.Text));


                    activity.ActivityId = int.Parse(listViewActivity.SelectedItems[0].SubItems[0].Text);
                    activity.ActivityDescription = activityDescriptionTextbox.Text;
                    activity.ActivityStartDateTime = DateTime.Parse(activityStartTextbox.Text);
                    activity.ActivityEndDateTime = DateTime.Parse(activityEndTextbox.Text);

                    ActivityService activityService = new ActivityService();
                    activityService.UpdateActivity(activity);

                    ActivityClear();
                    showPanel("Activities");

                    MessageBox.Show($"Succesfully updated: {activity.ActivityDescription}");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating activity failed: " + ex.Message);
            }
            finally
            {
                ActivityClear();
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
                    activityService.DeleteActivity(int.Parse(listViewActivity.SelectedItems[0].SubItems[0].Text));
                    List<Activity> activities = activityService.GetActivity();

                    listViewActivity.Items.Clear();

                    foreach (Activity activity in activities)
                    {
                        ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                        listViewItem.SubItems.Add(activity.ActivityDescription);
                        listViewItem.SubItems.Add(activity.ActivityStartDateTime.ToString());
                        listViewItem.SubItems.Add(activity.ActivityEndDateTime.ToString());

                        listViewActivity.Items.Add(listViewItem);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete activity: " + ex.Message);
                }
            }
            
        }

        private void listViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.listViewActivity.SelectedIndices;

            foreach (int index in indexes)
            {
                ListViewItem listViewItem = listViewActivity.SelectedItems[0];
                activityDescriptionTextbox.Text = listViewItem.SubItems[1].Text;
                activityStartTextbox.Text = listViewItem.SubItems[2].Text;
                activityEndTextbox.Text = listViewItem.SubItems[3].Text;
=======


        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.CashRegister);
        }

        private void checkOutButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                yourOrderListView.Items.Clear();
                orderService.AddOrder(int.Parse(studentListView.SelectedItems[0].SubItems[0].Text),
                        DateTime.Parse(studentListView.SelectedItems[0].SubItems[2].Text),
                        orderLines);
                MessageBox.Show("Your transaction has been succeeded!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your transaction has NOT been succeeded! " + ex.Message);
            }
        }

        private void addDrinkButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (amountTextbox.Text == "")
                {
                    throw new Exception("Please add amount of drinks. ");
                }
                ListViewItem li = new ListViewItem(drinkListView.SelectedItems[0].SubItems[1].Text);
                li.SubItems.Add((double.Parse(drinkListView.SelectedItems[0].SubItems[2].Text.ToString()) * double.Parse(amountTextbox.Text)).ToString());
                li.SubItems.Add(amountTextbox.Text);


                orderLines.Add(new OrderLine(int.Parse(amountTextbox.Text), new Drink(int.Parse(drinkListView.SelectedItems[0].SubItems[0].Text), int.Parse(drinkListView.SelectedItems[0].SubItems[3].Text) )));

                yourOrderListView.Items.Add(li);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order not successful: " + ex.Message);
            }
        }

        private void activityParticipantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel(Panel.ActivityParticipants);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxAvailableParticipants.SelectedIndex == -1) throw new Exception("First select a student to add this student!");
                if (listViewActivitiesParticipants.SelectedItems.Count == 0) throw new Exception("First select a activity to add this student!");

                activityService.AddStudent(int.Parse(listViewActivitiesParticipants.SelectedItems[0].SubItems[0].Text), int.Parse(cbxAvailableParticipants.SelectedItem.ToString().Split('-')[1].Trim()));
                if (listViewActivitiesParticipants.SelectedItems.Count > 0)
                {
                    List<Student> students = activityService.GetStudents(int.Parse(listViewActivitiesParticipants.SelectedItems[0].SubItems[0].Text));
                    listViewParticipants.Items.Clear();

                    foreach (Student student in students)
                    {
                        ListViewItem listViewItem = new ListViewItem(student.Id.ToString());
                        listViewItem.SubItems.Add(student.FullName);

                        listViewParticipants.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewParticipants.SelectedItems.Count == 0) throw new Exception("First select a student to remove this student!");

                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this student?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                
                        activityService.DeleteStudent(int.Parse(listViewActivitiesParticipants.SelectedItems[0].SubItems[0].Text), int.Parse(listViewParticipants.SelectedItems[0].SubItems[0].Text));
                        if (listViewActivitiesParticipants.SelectedItems.Count > 0)
                        {
                            List<Student> students = activityService.GetStudents(int.Parse(listViewActivitiesParticipants.SelectedItems[0].SubItems[0].Text));
                            listViewParticipants.Items.Clear();

                            foreach (Student student in students)
                            {
                                ListViewItem listViewItem = new ListViewItem(student.Id.ToString());
                                listViewItem.SubItems.Add(student.FullName);

                                listViewParticipants.Items.Add(listViewItem);
                            }
                        }

                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewActivitiesParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewActivitiesParticipants.SelectedItems.Count > 0) {
                    List<Student> students = activityService.GetStudents(int.Parse(listViewActivitiesParticipants.SelectedItems[0].SubItems[0].Text));
                    listViewParticipants.Items.Clear();

                    foreach (Student student in students)
                    {
                        ListViewItem listViewItem = new ListViewItem(student.Id.ToString());
                        listViewItem.SubItems.Add(student.FullName);

                        listViewParticipants.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
>>>>>>> Devon
            }
        }
    }
}

