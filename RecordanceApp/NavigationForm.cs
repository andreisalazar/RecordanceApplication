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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();

        }

        public static string[] usernameList = File.ReadAllLines(PublicData.usernameDB);
        public static string[] passwordList = File.ReadAllLines(PublicData.passwordDB);
        public static string[] fullnameList = File.ReadAllLines(PublicData.fullnameDB);

        private void NavigationForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + PublicData.PublicFullname + "!";
        }

        private void viewsectionbuttonOne_Click(object sender, EventArgs e)
        {
            if (coursenameOne.Text == "")
            {
                // Empty coursename
                MessageBox.Show("Kindly enter your course name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameOne.Focus();
            }
            else if (coursecodeOne.Text == "")
            {
                // Empty coursecode
                MessageBox.Show("Kindly enter your course code."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursecodeOne.Focus();
            }
            else if (double.TryParse(coursenameOne.Text, out double coursenameOneParsed))
            {
                // Invalid format of course name (e.g. number)
                MessageBox.Show("Course name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameOne.Text = "";
            }
            else if (coursenameOne.Text.Length < 8 || coursenameOne.Text.Length > 50)
            {
                // Too short course name or too long course name
                MessageBox.Show("Course name should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameOne.Focus();
                coursenameOne.SelectAll();
            }
            else
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();

                coursenameOne.Text = PublicData.PublicCourseNameOne;
                coursenameOne.ReadOnly = true;

                coursecodeOne.Text = PublicData.PublicCourseCodeOne;
                coursecodeOne.ReadOnly = true;
            }
        }

        private void viewsectionbuttonTwo_Click(object sender, EventArgs e)
        {
            if (coursenameTwo.Text == "")
            {
                // Empty coursename
                MessageBox.Show("Kindly enter your course name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameTwo.Focus();
            }
            else if (coursecodeTwo.Text == "")
            {
                // Empty coursecode
                MessageBox.Show("Kindly enter your course code."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursecodeTwo.Focus();
            }
            else if (double.TryParse(coursenameTwo.Text, out double coursenameTwoParsed))
            {
                // Invalid format of course name (e.g. number)
                MessageBox.Show("Course name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameTwo.Text = "";
            }
            else if (coursenameTwo.Text.Length < 8 || coursenameTwo.Text.Length > 50)
            {
                // Too short course name or too long course name
                MessageBox.Show("Course name should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameTwo.Focus();
                coursenameTwo.SelectAll();
            }
            else
            {

                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();

                coursenameTwo.Text = PublicData.PublicCourseNameTwo;
                coursenameTwo.ReadOnly = true;

                coursecodeTwo.Text = PublicData.PublicCourseCodeTwo;
                coursecodeTwo.ReadOnly = true;
            }
        }

        private void viewsectionbuttonThree_Click(object sender, EventArgs e)
        {
            if (coursenameThree.Text == "")
            {
                // Empty coursename
                MessageBox.Show("Kindly enter your course name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameThree.Focus();
            }
            else if (coursecodeOne.Text == "")
            {
                // Empty coursecode
                MessageBox.Show("Kindly enter your course code."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursecodeThree.Focus();
            }
            else if (double.TryParse(coursenameThree.Text, out double coursenameThreeParsed))
            {
                // Invalid format of course name (e.g. number)
                MessageBox.Show("Course name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameThree.Text = "";
            }
            else if (coursenameThree.Text.Length < 8 || coursenameThree.Text.Length > 50)
            {
                // Too short course name or too long course name
                MessageBox.Show("Course name should be 8 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursenameThree.Focus();
                coursenameThree.SelectAll();
            }
            else
            {
                PublicData.PublicCourseNameThree = coursenameThree.Text.ToUpper();
                PublicData.PublicCourseCodeThree = coursecodeThree.Text.ToUpper();

                coursenameThree.Text = PublicData.PublicCourseNameThree;
                coursenameThree.ReadOnly = true;

                coursecodeThree.Text = PublicData.PublicCourseCodeThree;
                coursecodeThree.ReadOnly = true;
            }
        }
    }
}
