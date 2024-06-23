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
            this.ControlBox = false;
        }

        //Instantiate the forms
        SectionsCourseOne sectionsformcourseOne = new SectionsCourseOne();
        SectionsCourseTwo sectionsformCourseTwo = new SectionsCourseTwo();
        RequirementsAndSyllabusCourseOne rsCourseOne = new RequirementsAndSyllabusCourseOne();
        RequirementsAndSyllabusCourseTwo rsCourseTwo = new RequirementsAndSyllabusCourseTwo();

        CourseOneSyllabusForm syllabusCourseOne = new CourseOneSyllabusForm();
        CourseTwoSyllabusForm syllabusCourseTwo = new CourseTwoSyllabusForm();

        private void NavigationForm_Load(object sender, EventArgs e)
        {

            welcomeLabel.Text = "Welcome, " + PublicData.PublicFullname + "!";

            coursenameOne.ReadOnly = false;
            coursenameTwo.ReadOnly = false;


            if (PublicData.usernameIndex != -1)
            {
                //If there is a content, then display it
                if (PublicData.courseNameOneList.Length > PublicData.usernameIndex &&
                    !string.IsNullOrEmpty(PublicData.courseNameOneList[PublicData.usernameIndex]))
                {
                    coursenameOne.Text = PublicData.courseNameOneList[PublicData.usernameIndex];
                    coursecodeOne.Text = PublicData.courseCodeOneList[PublicData.usernameIndex];
                    coursenameOne.ReadOnly = true;
                    coursecodeOne.ReadOnly = true;
                }
                //If there is a content, then display it
                if (PublicData.courseNameTwoList.Length > PublicData.usernameIndex &&
                    !string.IsNullOrEmpty(PublicData.courseNameTwoList[PublicData.usernameIndex]))
                {
                    coursenameTwo.Text = PublicData.courseNameTwoList[PublicData.usernameIndex];
                    coursecodeTwo.Text = PublicData.courseCodeTwoList[PublicData.usernameIndex];
                    coursenameTwo.ReadOnly = true;
                    coursecodeTwo.ReadOnly = true;
                }
            }

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
            else if (!coursenameOne.ReadOnly && !coursecodeOne.ReadOnly)
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();

                coursenameOne.Text = PublicData.PublicCourseNameOne;
                coursenameOne.ReadOnly = true;

                coursecodeOne.Text = PublicData.PublicCourseCodeOne;
                coursecodeOne.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameOneDB, PublicData.PublicCourseNameOne +
                    Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeOneDB, PublicData.PublicCourseCodeOne +
                    Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name One: " + coursenameOne + Environment.NewLine +
                   "Course Code One: " + PublicData.PublicCourseCodeOne + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();
                sectionsformcourseOne.Show();
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
            else if (!coursenameTwo.ReadOnly && !coursecodeTwo.ReadOnly)
            {
                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();

                coursenameTwo.Text = PublicData.PublicCourseNameTwo;
                coursenameTwo.ReadOnly = true;

                coursecodeTwo.Text = PublicData.PublicCourseCodeTwo;
                coursecodeTwo.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameTwoDB, PublicData.PublicCourseNameTwo +
                            Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeTwoDB, PublicData.PublicCourseCodeTwo +
                            Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name Two: " + coursenameTwo + Environment.NewLine +
                           "Course Code Two: " + PublicData.PublicCourseCodeTwo + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();
                sectionsformCourseTwo.Show();
            }

        }

        private void viewSyllabusAndReqButtonOne_Click(object sender, EventArgs e)
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
            else if (!coursenameOne.ReadOnly && !coursecodeOne.ReadOnly)
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();

                coursenameOne.Text = PublicData.PublicCourseNameOne;
                coursenameOne.ReadOnly = true;

                coursecodeOne.Text = PublicData.PublicCourseCodeOne;
                coursecodeOne.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameOneDB, PublicData.PublicCourseNameOne +
                    Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeOneDB, PublicData.PublicCourseCodeOne +
                    Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name One: " + coursenameOne + Environment.NewLine +
                   "Course Code One: " + PublicData.PublicCourseCodeOne + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();
                rsCourseOne.Show();
            }
        }

        private void viewSyllabusAndReqsButtonTwo_Click(object sender, EventArgs e)
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
            else if (!coursenameTwo.ReadOnly && !coursecodeTwo.ReadOnly)
            {
                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();

                coursenameTwo.Text = PublicData.PublicCourseNameTwo;
                coursenameTwo.ReadOnly = true;

                coursecodeTwo.Text = PublicData.PublicCourseCodeTwo;
                coursecodeTwo.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameTwoDB, PublicData.PublicCourseNameTwo +
                            Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeTwoDB, PublicData.PublicCourseCodeTwo +
                            Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name Two: " + coursenameTwo + Environment.NewLine +
                           "Course Code Two: " + PublicData.PublicCourseCodeTwo + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();
                rsCourseTwo.Show();
            }
        }

        private void viewSyllabusButtonOne_Click(object sender, EventArgs e)
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
            else if (!coursenameOne.ReadOnly && !coursecodeOne.ReadOnly)
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();

                coursenameOne.Text = PublicData.PublicCourseNameOne;
                coursenameOne.ReadOnly = true;

                coursecodeOne.Text = PublicData.PublicCourseCodeOne;
                coursecodeOne.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameOneDB, PublicData.PublicCourseNameOne +
                    Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeOneDB, PublicData.PublicCourseCodeOne +
                    Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name One: " + coursenameOne + Environment.NewLine +
                   "Course Code One: " + PublicData.PublicCourseCodeOne + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();
                syllabusCourseOne.Show();
            }
        }

        private void viewSyllabusButtonTwo_Click(object sender, EventArgs e)
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
            else if (!coursenameTwo.ReadOnly && !coursecodeTwo.ReadOnly)
            {
                PublicData.PublicCourseNameTwo = coursenameTwo.Text.ToUpper();
                PublicData.PublicCourseCodeTwo = coursecodeTwo.Text.ToUpper();

                coursenameTwo.Text = PublicData.PublicCourseNameTwo;
                coursenameTwo.ReadOnly = true;

                coursecodeTwo.Text = PublicData.PublicCourseCodeTwo;
                coursecodeTwo.ReadOnly = true;

                //Append the course name
                File.AppendAllText(PublicData.courseNameTwoDB, PublicData.PublicCourseNameTwo +
                            Environment.NewLine);
                //Append the course code
                File.AppendAllText(PublicData.courseCodeTwoDB, PublicData.PublicCourseCodeTwo +
                            Environment.NewLine);
                //Notify the user
                MessageBox.Show("Course Name Two: " + coursenameTwo + Environment.NewLine +
                           "Course Code Two: " + PublicData.PublicCourseCodeTwo + "is successfully added!");
            }
            else
            {
                PublicData.PublicCourseNameOne = coursenameOne.Text.ToUpper();
                PublicData.PublicCourseCodeOne = coursecodeOne.Text.ToUpper();
                syllabusCourseTwo.Show();
            }
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
