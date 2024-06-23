using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordanceApp
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        NavigationForm navigationform = new NavigationForm();

        private void changepasswordButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                // Empty Username
                MessageBox.Show("Kindly enter your username."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
            }
            else if (usernameTextBox.Text.Length > 50)
            {
                // Too long or short username
                MessageBox.Show("Username should be at least 6 to 50 characters only."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }
            else if (usernameTextBox.Text.Contains(" "))
            {
                // Username has a white space
                MessageBox.Show("Username should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();

            }
            else if (
                (usernameTextBox.Text.Contains("@"))
                || (usernameTextBox.Text.Contains("/"))
                || (usernameTextBox.Text.Contains("."))
                || (usernameTextBox.Text.Contains("&"))
                || (usernameTextBox.Text.Contains("*"))
                || (usernameTextBox.Text.Contains("!"))
                || (usernameTextBox.Text.Contains("#"))
                || (usernameTextBox.Text.Contains("$"))
                || (usernameTextBox.Text.Contains("%"))
                || (usernameTextBox.Text.Contains("^"))
                || (usernameTextBox.Text.Contains("("))
                || (usernameTextBox.Text.Contains(")"))
                || (usernameTextBox.Text.Contains("-"))
                || (usernameTextBox.Text.Contains("+"))
                || (usernameTextBox.Text.Contains("="))
                )
            {
                // Username has unneccessary or prohibited characters
                MessageBox.Show("Username should be a combination of alphanumeric" +
                    " characters and digits from 0 to 9."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                usernameTextBox.SelectAll();
            }

            /* New password */

            else if (newpasswordTextBox.Text == "")
            {
                // Empty password
                MessageBox.Show("Kindly enter your new password."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpasswordTextBox.Focus();
            }
            else if (newpasswordTextBox.Text.Length < 8)
            {
                // Too short password or too long password
                MessageBox.Show(" New password should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpasswordTextBox.Focus();
                newpasswordTextBox.SelectAll();
            }
            else if (newpasswordTextBox.Text.Contains(" "))
            {
                // Password contains white space
                MessageBox.Show("New password should not contain a whitespace character."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpasswordTextBox.Focus();
                newpasswordTextBox.SelectAll();
            }

            /*  Confirm password */

            else if (confirmpasswordTextBox.Text == "")
            {
                // Empty password
                MessageBox.Show("Kindly confirm your password."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmpasswordTextBox.Focus();
            }
            else if (confirmpasswordTextBox.Text != newpasswordTextBox.Text)
            {
                MessageBox.Show("Passwords does not match. Please try again."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmpasswordTextBox.Focus();
                confirmpasswordTextBox.Focus();
                confirmpasswordTextBox.SelectAll();
            }
            else
            {
                proceedToSignIn();
            }


            void proceedToSignIn()
            {

                string[] password = File.ReadAllLines(PublicData.passwordDB);
                string[] usernameList = File.ReadAllLines(PublicData.usernameDB);
                int usernameIndex;
                if (usernameList.Contains(usernameTextBox.Text))
                {
                    usernameIndex = Array.IndexOf(usernameList, usernameTextBox.Text);
                    if (password.Contains(password[usernameIndex]))
                    {
                        password[usernameIndex] = confirmpasswordTextBox.Text;
                        File.WriteAllLines(PublicData.passwordDB, password);
                        MessageBox.Show("Password is successfully changed.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Username not found. Please try again."
                  , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }

            }

        }

    }
}
