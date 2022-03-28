using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class SomerenUILogin : Form
    {
        UserService userService;

        public SomerenUILogin()
        {
            userService = new UserService();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usernameTextbox.Text) || !String.IsNullOrEmpty(passwordTextbox.Text))
            {
                if (!userService.ValidUser(usernameTextbox.Text, passwordTextbox.Text))
                {
                    MessageBox.Show("Incorrect username or password");
                }
                else
                {
                    this.Hide();
                    SomerenUI form = new SomerenUI(userService.GetStatus(usernameTextbox.Text));
                    form.ShowDialog();
                }
            }
            else MessageBox.Show("Please fill in all requirements");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            pnlRegister.Show();
        }

        private void registernewUserButton_Click(object sender, EventArgs e)
        {
            userService = new UserService();
            User newUser = new User();

            newUser.UserName = registerUsernameTextbox.Text;
            newUser.PassWord = registerPasswordTextbox.Text;
            newUser.AdminStatus = "user";
            newUser.SecretQuestion = secretQuestionRegisterTextbox.Text;
            newUser.SecretAnswer = secretAnswerRegisterTextbox.Text;


            string licenseKey = "XsZAb-tgz3PsD-qYh69un-WQCEx";
            try
            {
                if (!String.IsNullOrEmpty(registerUsernameTextbox.Text) && (!String.IsNullOrEmpty(registerPasswordTextbox.Text)) && (!String.IsNullOrEmpty(secretQuestionRegisterTextbox.Text)) && (!String.IsNullOrEmpty(secretAnswerRegisterTextbox.Text)) && (!String.IsNullOrEmpty(licenseKeyTextbox.Text)))
                {
                    if (licenseKeyTextbox.Text == licenseKey)
                    {
                        userService.AddUser(newUser);
                        this.Hide();
                        SomerenUILogin somerenUILogin = new SomerenUILogin();
                        somerenUILogin.Show();

                        MessageBox.Show("Succesfully registered!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid license key");
                    }
                }
                else MessageBox.Show("Please fill in all requirements");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while registering new user. " + ex.Message);
            }
        }

        private void SomerenUILogin_Load(object sender, EventArgs e)
        {
            pnlRegister.Hide();
        }
    }
}
