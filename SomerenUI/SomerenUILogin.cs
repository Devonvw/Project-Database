using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;

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

        private void showPanel(Panel panel)
        {
            pnlForgotPassword.Hide();
            pnlRegister.Hide();

            if (panel == Panel.Login)
            {
                pnlForgotPassword.Hide();
                pnlRegister.Hide();
            }
            else if (panel == Panel.ForgotPassword)
            {
                try
                {
                    lblSecretQuestion.Text = userService.GetSecretQuestion(usernameTextbox.Text);

                    pnlForgotPassword.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (panel == Panel.Register)
            {
                pnlRegister.Show();
            }
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

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usernameTextbox.Text)) showPanel(Panel.ForgotPassword);
            else MessageBox.Show("Please fill in your username");
        }

        private void SomerenUILogin_Load(object sender, EventArgs e)
        {
            showPanel(Panel.Login);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Login);
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbxNewPassword.Text) || !String.IsNullOrEmpty(secretAnswerTextbox.Text))
                {
                    userService.ChangeForgotPassword(usernameTextbox.Text, secretAnswerTextbox.Text, tbxNewPassword.Text);
                    showPanel(Panel.Login);
                }
                else MessageBox.Show("Please fill in all requirements");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Register);
        }

        private void registernewUserButton_Click(object sender, EventArgs e)
        {
            userService = new UserService();
            string userName;
            string passWord;
            string adminStatus;
            string secretQuestion;
            string secretAnswer;

            userName = registerUsernameTextbox.Text;
            passWord = registerPasswordTextbox.Text;
            adminStatus = "user";
            secretQuestion = secretQuestionRegisterTextbox.Text;
            secretAnswer = secretAnswerRegisterTextbox.Text;


            string licenseKey = "XsZAb-tgz3PsD-qYh69un-WQCEx";
            try
            {
                if (!String.IsNullOrEmpty(registerUsernameTextbox.Text) && (!String.IsNullOrEmpty(registerPasswordTextbox.Text)) && (!String.IsNullOrEmpty(secretQuestionRegisterTextbox.Text)) && (!String.IsNullOrEmpty(secretAnswerRegisterTextbox.Text)) && (!String.IsNullOrEmpty(licenseKeyTextbox.Text)))
                {
                    if (licenseKeyTextbox.Text == licenseKey)
                    {
                        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                        Match match = regex.Match(registerUsernameTextbox.Text);

                        if (match.Success)
                        {
                            userService.AddUser(userName, passWord, adminStatus, secretQuestion, secretAnswer);
                            this.Hide();
                            SomerenUILogin somerenUILogin = new SomerenUILogin();
                            somerenUILogin.Show();

                            MessageBox.Show("Succesfully registered!");
                        }
                        else
                        {
                            MessageBox.Show("invalid email");
                        }
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

        private void cancelRegisterButton_Click(object sender, EventArgs e)
        {
            showPanel(Panel.Login);
        }
    }
}