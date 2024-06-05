using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordanceApp
{
    public partial class SectionsCourseOne : Form
    {
        AddStudentsCourseOneSectionOne addstudentsCourseOneSectionOne = new AddStudentsCourseOneSectionOne();
        AddStudentsCourseOneSectionTwo addstudentsCourseOneSectionTwo = new AddStudentsCourseOneSectionTwo();
        public SectionsCourseOne()
        {
            InitializeComponent();
            titleLabel.Text = PublicData.courseNameOneList[PublicData.usernameIndex]
                + " - " + PublicData.courseCodeOneList[PublicData.usernameIndex];
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewStudentsButtonSectionOne_Click(object sender, EventArgs e)
        {
            if (sectionOneCourseOneTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your section name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sectionOneCourseOneTextBox.Focus();
            }
            else if (scheduleOneCourseOneTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your schedule.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleOneCourseOneTextBox.Focus();    
            }
            else if (double.TryParse(scheduleOneCourseOneTextBox.Text, out double scheduleSectionOne))
            {
                MessageBox.Show("Invalid input! Change your schedule in alphanumeric format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleOneCourseOneTextBox.Focus();
                scheduleOneCourseOneTextBox.Text = "";
            }
            else
            {
                addstudentsCourseOneSectionOne.Show();
                PublicData.PublicCourseOneSectionOne = sectionOneCourseOneTextBox.Text;
                //Append the text in the Course One Section One DB 
                createATextFile(PublicData.courseOneSectionOneDB,PublicData.PublicCourseOneSectionOne);
            }
        }

        private void viewStudentsButtonSectionTwo_Click(object sender, EventArgs e)
        {
            addstudentsCourseOneSectionTwo.Show();
        }

        public void createATextFile(string file, string text)
        {
            File.AppendAllText(file, text + ".txt");
            MessageBox.Show(text + ".txt" + " is succesfully created!");
        }
    }
}
