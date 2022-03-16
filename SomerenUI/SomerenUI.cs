﻿using SomerenLogic;
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
                //pnlLectures.Hide();
                //pnlActivities.Hide();
                //pnlRoom.Hide();

                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlDrinksSupplies.Hide();
                //pnlLectures.Hide();
                //pnlActivities.Hide();
                //pnlRoom.Hide();

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
                //pnlLectures.Hide();
                //pnlActivities.Hide();
                //pnlRoom.Hide();
                pnlDrinksSupplies.Show();

                try
                {
                    //List with Drinks directly from DB
                    DrinkSupplyService supplyService = new DrinkSupplyService();
                    List<DrinkSupply> drinksSupplies = supplyService.GetDrinksSupplies();

                    listViewDrinksSupplies.Items.Clear();

                    foreach (DrinkSupply supply in drinksSupplies)
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
        }

        //Bool Used to give each added drink a VAT TYPE (1 OR 2)
        public bool drinkIsAlcohol;
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
                    int ID = service.GenerateId();
                    int amountSold = 0;

                    ListViewItem supplyList = new ListViewItem(ID.ToString());
                    supplyList.SubItems.Add(drinkNameTextBox.Text);
                    supplyList.SubItems.Add(drinkSupplyTextBox.Text);
                    supplyList.SubItems.Add($"{drinkPriceTextBox.Text} token(s)");
                    supplyList.SubItems.Add(amountSold.ToString());

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

                    DrinkSupply drink = new DrinkSupply(ID, drinkNameTextBox.Text, int.Parse(drinkSupplyTextBox.Text), int.Parse(drinkPriceTextBox.Text), vatId, amountSold);

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
                List<DrinkSupply> drinksSupplies = supplyService.GetDrinksSupplies();
                DrinkSupply drink = null;

                foreach (DrinkSupply supply in drinksSupplies)
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
                    List<DrinkSupply> drinksSupplies = supplyService.GetDrinksSupplies();

                    foreach (DrinkSupply supply in drinksSupplies)
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
        private void drinksSuppliesStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }
    }
}
