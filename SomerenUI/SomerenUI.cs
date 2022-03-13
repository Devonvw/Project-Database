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
                pnlDrinksSupplies.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlDrinksSupplies.Hide();

                // show students
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
            else if(panelName == "Drinks Supplies")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlDrinksSupplies.Show();

                try
                {
                    DrinkSupplyService supplyService = new DrinkSupplyService();
                    List<DrinkSupply> drinksSupplies = supplyService.GetDrinksSupplies();

                    listViewDrinksSupplies.Items.Clear();

                    foreach (DrinkSupply supply in drinksSupplies)
                    {
                        ListViewItem supplyList = new ListViewItem(supply.DrinkName.ToString());
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
        }
        private void drinkAddButton_Click(object sender, EventArgs e)
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

                ListViewItem supplyList = new ListViewItem(drinkNameTextBox.Text);
                supplyList.SubItems.Add(drinkSupplyTextBox.Text);
                supplyList.SubItems.Add($"{drinkPriceTextBox.Text} token(s)");
                supplyList.SubItems.Add("0");

                string warning;

                if (int.Parse(drinkSupplyTextBox.Text) < 10)
                {
                    warning = "Stock nearly depleted";
                }
                else warning = "Stock sufficient";

                supplyList.SubItems.Add(warning);

                listViewDrinksSupplies.Items.Add(supplyList);
                drinkNameTextBox.Clear();
                drinkPriceTextBox.Clear();
                drinkSupplyTextBox.Clear();
            }
        }
        private void drinkUpdateButton_Click(object sender, EventArgs e)
        {
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
                listViewDrinksSupplies.SelectedItems[0].SubItems[0].Text = drinkNameTextBox.Text;
            }
            if (!string.IsNullOrEmpty(drinkSupplyTextBox.Text))
            {
                listViewDrinksSupplies.SelectedItems[0].SubItems[1].Text = drinkSupplyTextBox.Text;

                string warning;

                if (int.Parse(drinkSupplyTextBox.Text) < 10)
                {
                    warning = "Stock nearly depleted";
                }
                else warning = "Stock sufficient";

                listViewDrinksSupplies.SelectedItems[0].SubItems[4].Text = warning;
                
            }
            if (!string.IsNullOrEmpty(drinkPriceTextBox.Text))
            {
                listViewDrinksSupplies.SelectedItems[0].SubItems[2].Text = $"{drinkPriceTextBox.Text} token(s)";
            }

            drinkNameTextBox.Clear();
            drinkPriceTextBox.Clear();
            drinkSupplyTextBox.Clear();

            List<DrinkSupply> drink = new List<DrinkSupply>();
        }
        private void drinkDeleteButton_Click(object sender, EventArgs e)
        {
            if (listViewDrinksSupplies.Items.Count > 0)
            {
                listViewDrinksSupplies.Items.Remove(listViewDrinksSupplies.SelectedItems[0]);
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

        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks Supplies");
        }

        private void listViewDrinksSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
