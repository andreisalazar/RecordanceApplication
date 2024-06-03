using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordanceApp
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        ForgotPasswordForm forgotpasswordform = new ForgotPasswordForm();
        SignUpForm signupform = new SignUpForm();
        NavigationForm navigationform = new NavigationForm();

      
        public static string[] usernameList = File.ReadAllLines(PublicData.usernameDB);
        public static string[] passwordList = File.ReadAllLines(PublicData.passwordDB);
        public static  string[] fullnameList = File.ReadAllLines(PublicData.fullnameDB);
  

        private void forgotpasswordButton_Click(object sender, EventArgs e)
        {
            forgotpasswordform.ShowDialog();
        }

        public void signinButton_Click(object sender, EventArgs e)
        {
           int usernameIndex = Array.IndexOf(usernameList, usernameTextBox.Text);

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your username.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
            }
            else if (!usernameList.Contains(usernameTextBox.Text)
                || usernameIndex == -1)
            {
                // If the prompted username is not found on the username text file
                MessageBox.Show("Account not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
                passwordTextBox.Text = "";
            }
            else if (passwordList[usernameIndex] == passwordTextBox.Text)
            {
                // If the index of the password list is similar to the index of the text found, then the password
                // and username matches

                PublicData.PublicUsername = usernameList[usernameIndex];
                PublicData.PublicFullname = fullnameList[usernameIndex];
                MessageBox.Show("Public Fullname (SignInForm):" + PublicData.PublicFullname);
                proceedToNavigationForm();
            }
            else if ((passwordList[usernameIndex] != passwordTextBox.Text) || (passwordTextBox.Text == "")
)
            {
                MessageBox.Show("An error occured. The password might be incorrect password or empty." + passwordList[usernameIndex].ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                passwordTextBox.SelectAll();
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupform.ShowDialog();
        }

        public void proceedToNavigationForm()
        {
            this.Hide();
            navigationform.ShowDialog();
        }
    }
}
