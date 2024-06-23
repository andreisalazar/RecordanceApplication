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
    public partial class SectionsCourseTwo : Form
    {
        public SectionsCourseTwo()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        AddStudentsCourseTwoSectionOne addstudentscoursetwosectionone = new AddStudentsCourseTwoSectionOne();
        AddStudentsCourseTwoSectionTwo addstudentscoursetwosectiontwo = new AddStudentsCourseTwoSectionTwo();

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SectionsCourseTwo_Load(object sender, EventArgs e)
        {
            titleLabel.Text = PublicData.PublicCourseNameTwo
              + " - " + PublicData.PublicCourseCodeTwo;

            if (PublicData.courseTwoSectionOneNameList.Length > PublicData.usernameIndex
              && !string.IsNullOrEmpty(PublicData.courseTwoSectionOneNameList[PublicData.usernameIndex]))
            {
                PublicData.PublicCourseTwoSectionOne = PublicData.courseTwoSectionOneNameList[PublicData.usernameIndex].ToUpper();
                sectionOneCourseTwoTextBox.Text = PublicData.courseTwoSectionOneNameList[PublicData.usernameIndex].ToUpper();
                scheduleOneCourseTwoTextBox.Text = PublicData.courseTwoSectionOneSchedOneList[PublicData.usernameIndex].ToUpper();
                sectionOneCourseTwoTextBox.ReadOnly = true;
                scheduleOneCourseTwoTextBox.ReadOnly = true;
            }
            if (PublicData.courseTwoSectionTwoNameList.Length > PublicData.usernameIndex
          && !string.IsNullOrEmpty(PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex]))
            {
                PublicData.PublicCourseTwoSectionTwo = PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex].ToUpper();
                sectionTwoCourseTwoTextBox.Text = PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex].ToUpper();
                scheduleTwoCourseTwoTextBox.Text = PublicData.courseTwoSectionTwoSchedTwoList[PublicData.usernameIndex].ToUpper();
                sectionTwoCourseTwoTextBox.ReadOnly = true;
                scheduleTwoCourseTwoTextBox.ReadOnly = true;
            }
        }

        private void viewStudentsButtonOne_Click(object sender, EventArgs e)
        {
            if (sectionOneCourseTwoTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your section name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sectionOneCourseTwoTextBox.Focus();
            }
            else if (scheduleOneCourseTwoTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your schedule.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleOneCourseTwoTextBox.Focus();
            }
            else if (double.TryParse(scheduleOneCourseTwoTextBox.Text, out double scheduleSectionOne))
            {
                MessageBox.Show("Invalid input! Change your schedule in alphanumeric format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleOneCourseTwoTextBox.Focus();
                scheduleOneCourseTwoTextBox.Text = "";
            }
            else if (sectionOneCourseTwoTextBox.ReadOnly == false)
            {
                //Assign the public variables
                PublicData.PublicCourseTwoSectionOne = sectionOneCourseTwoTextBox.Text.ToUpper();
                PublicData.PublicCourseTwoSectionOneSchedOne = scheduleOneCourseTwoTextBox.Text.ToUpper();
                //Append the public variables
                File.AppendAllText(PublicData.courseTwoSectionOneNamesDB, sectionOneCourseTwoTextBox.Text.ToUpper() + Environment.NewLine);
                File.AppendAllText(PublicData.courseTwoSectionOneDBTXT, sectionOneCourseTwoTextBox.Text.ToUpper() + ".txt" + Environment.NewLine);
                File.AppendAllText(PublicData.courseTwoSectionOneSchedDB, scheduleOneCourseTwoTextBox.Text.ToUpper() + Environment.NewLine);
                sectionOneCourseTwoTextBox.ReadOnly = true;
                scheduleOneCourseTwoTextBox.ReadOnly = true;
            }
            else
            {
                PublicData.PublicCourseTwoSectionOne = sectionOneCourseTwoTextBox.Text.ToUpper();
                addstudentscoursetwosectionone.Show();
            }
        }

        private void viewStudentsButtonTwo_Click(object sender, EventArgs e)
        {
            if (sectionTwoCourseTwoTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your section name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sectionTwoCourseTwoTextBox.Focus();
            }
            else if (scheduleTwoCourseTwoTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your schedule.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleTwoCourseTwoTextBox.Focus();
            }
            else if (double.TryParse(scheduleTwoCourseTwoTextBox.Text, out double scheduleSectionOne))
            {
                MessageBox.Show("Invalid input! Change your schedule in alphanumeric format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleTwoCourseTwoTextBox.Focus();
                scheduleTwoCourseTwoTextBox.Text = "";
            }
            else if (sectionTwoCourseTwoTextBox.ReadOnly == false)
            {
                //Assign the public variables
                PublicData.PublicCourseTwoSectionTwo = sectionTwoCourseTwoTextBox.Text.ToUpper();
                PublicData.PublicCourseTwoSectionTwoSchedTwo = scheduleTwoCourseTwoTextBox.Text.ToUpper();

                //Append the oublic variables
                File.AppendAllText(PublicData.courseTwoSectionTwoNamesDB, sectionTwoCourseTwoTextBox.Text.ToUpper() + Environment.NewLine);
                File.AppendAllText(PublicData.courseTwoSectionTwoDBTXT, sectionTwoCourseTwoTextBox.Text.ToUpper() + ".txt" + Environment.NewLine);
                File.AppendAllText(PublicData.courseTwoSectionTwoSchedDB, scheduleTwoCourseTwoTextBox.Text.ToUpper() + Environment.NewLine);

                sectionTwoCourseTwoTextBox.ReadOnly = true;
                scheduleTwoCourseTwoTextBox.ReadOnly = true;
            }
            else
            {
                PublicData.PublicCourseTwoSectionTwo = sectionTwoCourseTwoTextBox.Text.ToUpper();
                addstudentscoursetwosectiontwo.Show();
            }
        }


    }
}
