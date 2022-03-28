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
            if (panel == Panel.Login)
            {
                pnlForgotPassword.Hide();
            }
            if (panel == Panel.ForgotPassword)
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
            pnlForgotPassword.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlForgotPassword.Hide();
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
    }
}