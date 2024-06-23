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
using System.IO;

namespace RecordanceApp
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            this.ControlBox = false;
        }

        ForgotPasswordForm forgotpasswordform = new ForgotPasswordForm();
        SignUpForm signupform = new SignUpForm();
        NavigationForm navigationform = new NavigationForm();

        private void forgotpasswordButton_Click(object sender, EventArgs e)
        {
            forgotpasswordform.ShowDialog();
        }

        public void signinButton_Click(object sender, EventArgs e)
        {
            PublicData.usernameList = File.ReadAllLines(PublicData.usernameDB);
            PublicData.passwordList = File.ReadAllLines(PublicData.passwordDB);
            PublicData.fullnameList = File.ReadAllLines(PublicData.fullnameDB);

            PublicData.usernameIndex = Array.IndexOf(PublicData.usernameList, usernameTextBox.Text);

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your username.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
            }
            else if (!PublicData.usernameList.Contains(usernameTextBox.Text)
                || PublicData.usernameIndex == -1)
            {
                // If the prompted username is not found on the username text file
                MessageBox.Show("Account not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
                passwordTextBox.Text = "";
            }
            else if (PublicData.passwordList[PublicData.usernameIndex] == passwordTextBox.Text)
            {
                // If the index of the password list is similar to the index of the text found, then the password
                // and username matches
                PublicData.PublicUsername = PublicData.usernameList[PublicData.usernameIndex];
                PublicData.PublicFullname = PublicData.fullnameList[PublicData.usernameIndex];

                MessageBox.Show("Username List" + PublicData.usernameList[PublicData.usernameIndex]);
                MessageBox.Show("Public Username (SignInForm):" + PublicData.PublicUsername);
                MessageBox.Show("Public Un Index (SignInForm):" + PublicData.usernameIndex);
                proceedToNavigationForm();
            }

            else if ((PublicData.passwordList[PublicData.usernameIndex] != passwordTextBox.Text) || (passwordTextBox.Text == "")
)
            {
                MessageBox.Show("An error occured. The password might be incorrect password or empty." + PublicData.passwordList[PublicData.usernameIndex].ToString(),
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

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
