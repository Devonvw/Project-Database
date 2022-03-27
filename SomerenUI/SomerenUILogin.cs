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
            HashAndSalt hashPassword = new HashAndSalt();
            string salt = hashPassword.CreateSalt(64);
            string hashedPasword = hashPassword.GenerateHash(registerPasswordTextbox.Text, salt);

            newUser.UserName = usernameTextbox.Text;
            newUser.PassWord = hashedPasword;
            newUser.Salt = salt;


            string licenseKey = "XsZAb - tgz3PsD - qYh69un - WQCEx";
            try
            {
                if (licenseKeyTextbox.Text == licenseKey)
                {
                    userService.AddUser(newUser);
                    this.Hide();
                    SomerenUILogin somerenUILogin = new SomerenUILogin();
                    somerenUILogin.Show();
                }
                else
                {
                    throw new Exception("Invalid license key...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while register new user: " + ex.Message);
            }
        }
    }
}
