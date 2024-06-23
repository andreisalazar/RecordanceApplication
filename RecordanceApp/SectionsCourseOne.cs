namespace RecordanceApp
{
    public partial class SectionsCourseOne : Form
    {
        AddStudentsCourseOneSectionOne addstudentsCourseOneSectionOne = new AddStudentsCourseOneSectionOne();
        AddStudentsCourseOneSectionTwo addstudentsCourseOneSectionTwo = new AddStudentsCourseOneSectionTwo();
        public SectionsCourseOne()
        {
            InitializeComponent();
            this.ControlBox = false;
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
            else if (sectionOneCourseOneTextBox.ReadOnly == false)
            {
                //Assign the public variables
                PublicData.PublicCourseOneSectionOne = sectionOneCourseOneTextBox.Text.ToUpper();
                PublicData.PublicCourseOneSectionOneSched = scheduleOneCourseOneTextBox.Text.ToUpper();
                //Append the course name and schedule
                File.AppendAllText(PublicData.courseOneSectionOneNamesDB, sectionOneCourseOneTextBox.Text.ToUpper() + Environment.NewLine);
                File.AppendAllText(PublicData.courseOneSectionOneDBTXT, sectionOneCourseOneTextBox.Text.ToUpper() + ".txt" + Environment.NewLine);
                File.AppendAllText(PublicData.courseOneSectionOneSchedDB, scheduleOneCourseOneTextBox.Text.ToUpper() + Environment.NewLine);

                sectionOneCourseOneTextBox.ReadOnly = true;
                scheduleOneCourseOneTextBox.ReadOnly = true;
            }
            else
            {
                PublicData.PublicCourseOneSectionOne = sectionOneCourseOneTextBox.Text.ToUpper();
                addstudentsCourseOneSectionOne.Show();
            }
        }

        private void viewStudentsButtonSectionTwo_Click(object sender, EventArgs e)
        {
            if (sectionTwoCourseOneTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your section name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sectionTwoCourseOneTextBox.Focus();
            }
            else if (scheduleTwoCourseOneTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your schedule.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleTwoCourseOneTextBox.Focus();
            }
            else if (double.TryParse(scheduleTwoCourseOneTextBox.Text, out double scheduleSectionTwo))
            {
                MessageBox.Show("Invalid input! Change your schedule in alphanumeric format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                scheduleTwoCourseOneTextBox.Focus();
                scheduleTwoCourseOneTextBox.Text = "";
            }
            else if (sectionTwoCourseOneTextBox.ReadOnly == false)
            {
                //Assign the public variables
                PublicData.PublicCourseOneSectionTwo = sectionTwoCourseOneTextBox.Text.ToUpper();
                PublicData.PublicCourseOneSectionTwoSched = scheduleTwoCourseOneTextBox.Text.ToUpper();
                //Append the coursename and schedule
                File.AppendAllText(PublicData.courseOneSectionTwoNamesDB, sectionTwoCourseOneTextBox.Text.ToUpper() + Environment.NewLine);
                File.AppendAllText(PublicData.courseOneSectionTwoDBTXT, sectionTwoCourseOneTextBox.Text.ToUpper() + ".txt" + Environment.NewLine);
                File.AppendAllText(PublicData.courseOneSectionTwoSchedDB, scheduleTwoCourseOneTextBox.Text.ToUpper() + Environment.NewLine);
                sectionTwoCourseOneTextBox.ReadOnly = true;
                scheduleTwoCourseOneTextBox.ReadOnly = true;
            }
            else
            {
                PublicData.PublicCourseOneSectionTwo = sectionTwoCourseOneTextBox.Text.ToUpper();
                addstudentsCourseOneSectionTwo.Show();
            }
        }

        private void SectionsCourseOne_Load(object sender, EventArgs e)
        {
            titleLabel.Text = PublicData.PublicCourseNameOne
              + " - " + PublicData.PublicCourseCodeOne;

            if (PublicData.courseOneSectionOneNameList.Length > PublicData.usernameIndex
                && !string.IsNullOrEmpty(PublicData.courseOneSectionOneNameList[PublicData.usernameIndex]))
            {
                loadSectionOne();
            }
            if (PublicData.courseOneSectionTwoNameList.Length > PublicData.usernameIndex
          && !string.IsNullOrEmpty(PublicData.courseOneSectionTwoNameList[PublicData.usernameIndex]))
            {
                loadSectionTwo();
            }
        }


        public void loadSectionOne()
        {
            sectionOneCourseOneTextBox.Text = PublicData.courseOneSectionOneNameList[PublicData.usernameIndex].ToUpper();
            scheduleOneCourseOneTextBox.Text = PublicData.courseOneSectionOneSchedOneList[PublicData.usernameIndex].ToUpper();
            sectionOneCourseOneTextBox.ReadOnly = true;
            scheduleOneCourseOneTextBox.ReadOnly = true;

            PublicData.PublicCourseOneSectionOne = sectionOneCourseOneTextBox.Text;
        }

        public void loadSectionTwo()
        {
            PublicData.PublicCourseOneSectionTwo = PublicData.courseOneSectionTwoNameList[PublicData.usernameIndex].ToUpper();
            PublicData.PublicCourseOneSectionTwoSched = PublicData.courseOneSectionTwoSchedTwoList[PublicData.usernameIndex].ToUpper();

            sectionTwoCourseOneTextBox.Text = PublicData.courseOneSectionTwoNameList[PublicData.usernameIndex].ToUpper();
            scheduleTwoCourseOneTextBox.Text = PublicData.courseOneSectionTwoSchedTwoList[PublicData.usernameIndex].ToUpper();

            sectionTwoCourseOneTextBox.ReadOnly = true;
            scheduleTwoCourseOneTextBox.ReadOnly = true;

            PublicData.PublicCourseOneSectionTwo = sectionTwoCourseOneTextBox.Text;
        }
    }
}
