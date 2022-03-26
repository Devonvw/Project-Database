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
    public partial class SomerenUILogin : Form
    {
        const string userName = "Alan";
        const string password = "123456abc";
        public SomerenUILogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usernameTextbox.Text) || !String.IsNullOrEmpty(passwordTextbox.Text))
            {
                if (usernameTextbox.Text != userName || passwordTextbox.Text != password)
                {
                    MessageBox.Show("Please enter correct Username and Password");
                }
                else
                {
                    this.Hide();
                    SomerenUI form = new SomerenUI();
                    form.ShowDialog();
                }
            }
            else MessageBox.Show("Please enter correct Username and Password");
        }
    }
}
