using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordanceApp
{
    public partial class GradeComputationCourseTwoSectionTwo : Form
    {
        DataTable table = new DataTable();
        int index;

        public GradeComputationCourseTwoSectionTwo()
        {
            InitializeComponent();
        }

        private void GradeComputationCourseTwoSectionTwo_Load(object sender, EventArgs e)
        {
            titleLabel.Text = PublicData.PublicCourseTwoSectionOne;
            studentNameTextBox.ReadOnly = true;
            studentNumberTextBox.ReadOnly = true;

            //Add columns
            table.Columns.Add("Student Number");
            table.Columns.Add("Name");
            table.Columns.Add("Quiz 1");
            table.Columns.Add("Quiz 2");
            table.Columns.Add("Quiz 3");
            table.Columns.Add("Quiz Percentage");
            table.Columns.Add("Activity 1");
            table.Columns.Add("Activity 2");
            table.Columns.Add("Activity 3");
            table.Columns.Add("Activity Percentage");
            table.Columns.Add("Midterm");
            table.Columns.Add("Finals");
            table.Columns.Add("Examination Percentage");
            table.Columns.Add("Present");
            table.Columns.Add("Absent");
            table.Columns.Add("Final Grade");
            table.Columns.Add("Final Grade(Letter)");
            table.Columns.Add("Final Grade(Pass/Fail)");
            table.Columns.Add("Comments");

            dataGridView1.DataSource = table;
            //Create a file if the file does not exist
            if (//Quiz One
                !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Quiz Two
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Quiz Three
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Quiz Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Act One
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Act Two
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Act Three
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Act Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Midterm Exam
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Midterm-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Final Exam
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Finals-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Exam Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ExamAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Present
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Present-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Absent
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Absent-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Final Grade
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGrade-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Final Grade In Letter
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInLetter-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Final Grade In Status
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInStatus-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                //Comments
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Comments-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"))
                )
            {
                //Quiz One
                var fileStreamOne = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Quiz Three
                var fileStreamThree = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Quiz Average
                var fileStreamFour = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Act One
                var fileStreamFive = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Act Two
                var fileStreamSix = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Act Three
                var fileStreamSeven = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Act Average
                var fileStreamEight = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Midterms
                var fileStreamNine = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Midterm-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Finals
                var fileStreamTen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Finals-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Exam Average
                var fileStreamEleven = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ExamAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Present
                var fileStreamTwelve = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Present-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Absent
                var fileStreamThirteen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Absent-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Final Grade
                var fileStreamFourteen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGrade-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Final Grade in Letter
                var fileStreamFifteen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInLetter-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Final Grade In Status
                var fileStreamSixteen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInStatus-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));
                //Comments
                var fileStreamSeventeen = File.Create(Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                    + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Comments-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt"));

                //Assign the text files
                PublicData.quizOneCourseTwoSectionTwo = fileStreamOne.Name;
                PublicData.quizTwoCourseTwoSectionTwo = fileStreamTwo.Name;
                PublicData.quizThreeCourseTwoSectionTwo = fileStreamThree.Name;
                PublicData.quizAverageCourseTwoSectionTwo = fileStreamFour.Name;

                PublicData.activityOneCourseTwoSectionTwo = fileStreamFive.Name;
                PublicData.activityTwoCourseTwoSectionTwo = fileStreamSix.Name;
                PublicData.activityThreeCourseTwoSectionTwo = fileStreamSeven.Name;
                PublicData.activityAverageCourseTwoSectionTwo = fileStreamEight.Name;

                PublicData.midtermExamCourseTwoSectionTwo = fileStreamNine.Name;
                PublicData.finalExamCourseTwoSectionTwo = fileStreamTen.Name;
                PublicData.examAverageCourseTwoSectionTwo = fileStreamEleven.Name;
                PublicData.presentCourseTwoSectionTwo = fileStreamTwelve.Name;
                PublicData.absentCourseTwoSectionTwo = fileStreamThirteen.Name;

                PublicData.finalGradeCourseTwoSectionTwo = fileStreamFourteen.Name;
                PublicData.finalGradeInLetterCourseTwoSectionTwo = fileStreamFifteen.Name;
                PublicData.finalGradeInStatusCourseTwoSectionTwo = fileStreamSixteen.Name;

                PublicData.commentsCourseTwoSectionTwo = fileStreamSeventeen.Name;

                fileStreamOne.Close();
                fileStreamTwo.Close();
                fileStreamThree.Close();
                fileStreamFour.Close();
                fileStreamFive.Close();
                fileStreamSix.Close();
                fileStreamSeven.Close();
                fileStreamEight.Close();
                fileStreamNine.Close();
                fileStreamTen.Close();
                fileStreamEleven.Close();
                fileStreamTwelve.Close();
                fileStreamThirteen.Close();
                fileStreamFourteen.Close();
                fileStreamFifteen.Close();
                fileStreamSixteen.Close();
                fileStreamSeventeen.Close();
            }

            PublicData.quizOneCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
               + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.quizTwoCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.quizThreeCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.quizAverageCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-QuizAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");

            PublicData.activityOneCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActOne-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.activityTwoCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActTwo-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.activityThreeCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActThree-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.activityAverageCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ActAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            //Midterms

            PublicData.midtermExamCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Midterm-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.finalExamCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Finals-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.examAverageCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-ExamAverage-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");

            PublicData.presentCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Present-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.absentCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Absent-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");

            PublicData.finalGradeCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGrade-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.finalGradeInLetterCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInLetter-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");
            PublicData.finalGradeInStatusCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-FinalGradeInStatus-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");

            PublicData.commentsCourseTwoSectionTwo = Path.Combine(PublicData.folder, PublicData.usernameList[PublicData.usernameIndex]
                + "-" + PublicData.courseNameTwoList[PublicData.usernameIndex] + "-Comments-" + PublicData.courseTwoSectionTwoNameList[PublicData.usernameIndex] + ".txt");

            loadStudentData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveGrade();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            studentNameTextBox.Text = row.Cells["Name"].Value.ToString();
            studentNumberTextBox.Text = row.Cells["Student Number"].Value.ToString();

            quizOne.Text = row.Cells["Quiz 1"].Value.ToString();
            quizTwo.Text = row.Cells["Quiz 2"].Value.ToString();
            quizThree.Text = row.Cells["Quiz 3"].Value.ToString();

            activityOneTextBox.Text = row.Cells["Activity 1"].Value.ToString();
            activityTwoTextBox.Text = row.Cells["Activity 2"].Value.ToString();
            activityThreeTextBox.Text = row.Cells["Activity 3"].Value.ToString();

            midtermTextBox.Text = row.Cells["Midterm"].Value.ToString();
            finalTextBox.Text = row.Cells["Finals"].Value.ToString();

            presentTextBox.Text = row.Cells["Present"].Value.ToString();
            absentTextBox.Text = row.Cells["Absent"].Value.ToString();
            commentTextBox.Text = row.Cells["Comments"].Value.ToString();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            //Empty
            if (quizOne.Text == "")
            {
                MessageBox.Show("Kindly enter the first quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizOne.Focus();
            }
            else if (quizTwo.Text == "")
            {
                MessageBox.Show("Kindly enter the second quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizTwo.Focus();
            }
            else if (quizThree.Text == "")
            {
                MessageBox.Show("Kindly enter the third quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizThree.Focus();
            }
            else if (activityOneTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the first activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityOneTextBox.Focus();
            }
            else if (activityTwoTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the second activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityTwoTextBox.Focus();
            }
            else if (activityThreeTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the third activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityThreeTextBox.Focus();
            }
            else if (midtermTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the midterm exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                midtermTextBox.Focus();
            }
            else if (finalTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the final exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finalTextBox.Focus();
            }
            //Less than Zero
            else if (Convert.ToDouble(quizOne.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizOne.Focus();
            }
            else if (Convert.ToDouble(quizTwo.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizTwo.Focus();
            }
            else if (Convert.ToDouble(quizThree.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizThree.Focus();
            }
            else if (Convert.ToDouble(activityOneTextBox.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityOneTextBox.Focus();
                activityOneTextBox.SelectAll();
            }
            else if (Convert.ToDouble(activityTwoTextBox.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityTwoTextBox.Focus();
                activityTwoTextBox.SelectAll();
            }
            else if (Convert.ToDouble(activityThreeTextBox.Text) < 0)
            {
                MessageBox.Show("Score cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityThreeTextBox.Focus();
                activityThreeTextBox.SelectAll();
            }
            //Greater than 20 score(Quizzes)
            else if (Convert.ToDouble(quizOne.Text) > 20)
            {
                MessageBox.Show("Score cannot be greater than 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizOne.Focus();
                quizOne.SelectAll();
            }
            else if (Convert.ToDouble(quizTwo.Text) > 20)
            {
                MessageBox.Show("Score cannot be greater than 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizTwo.Focus();
                quizTwo.SelectAll();
            }
            else if (Convert.ToDouble(quizThree.Text) > 20)
            {
                MessageBox.Show("Kindly enter the third quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizThree.Focus();
                quizThree.SelectAll();
            }
            //Greater than 100 Score (Activities)
            else if (Convert.ToDouble(activityOneTextBox.Text) > 100)
            {
                MessageBox.Show("Score cannot be greater than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityOneTextBox.Focus();
                activityOneTextBox.SelectAll();
            }
            else if (Convert.ToDouble(activityTwoTextBox.Text) > 100)
            {
                MessageBox.Show("Score cannot be greater than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityTwoTextBox.Focus();
                activityTwoTextBox.SelectAll();
            }
            else if (Convert.ToDouble(activityThreeTextBox.Text) > 100)
            {
                MessageBox.Show("Score cannot be greater than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityThreeTextBox.Focus();
                activityThreeTextBox.SelectAll();
            }
            //Greater than 100 Score (Exams)
            else if (Convert.ToDouble(midtermTextBox.Text) > 100)
            {
                MessageBox.Show("Score cannot be greater than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                midtermTextBox.Focus();
                midtermTextBox.SelectAll();
            }
            else if (Convert.ToDouble(finalTextBox.Text) > 100)
            {
                MessageBox.Show("Score cannot be greater than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finalTextBox.Focus();
                finalTextBox.SelectAll();
            }
            //String input
            else if (!double.TryParse(quizOne.Text, out double parsedQuizOne))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizOne.Focus();
                quizOne.SelectAll();
            }
            else if (!double.TryParse(quizTwo.Text, out double parsedQuizTwo))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizTwo.Focus();
                quizTwo.SelectAll();
            }
            else if (!double.TryParse(quizThree.Text, out double parsedQuizThree))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quizThree.Focus();
                quizThree.SelectAll();
            }
            else if (!double.TryParse(activityOneTextBox.Text, out double parsedActOne))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityOneTextBox.Focus();
                activityOneTextBox.SelectAll();
            }
            else if (!double.TryParse(activityTwoTextBox.Text, out double parsedActTwo))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityTwoTextBox.Focus();
                activityTwoTextBox.SelectAll();
            }
            else if (!double.TryParse(activityOneTextBox.Text, out double parsedActThree))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activityThreeTextBox.Focus();
                activityThreeTextBox.SelectAll();
            }
            else if (!double.TryParse(midtermTextBox.Text, out double parsedMidterm))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                midtermTextBox.Focus();
                midtermTextBox.SelectAll();
            }
            else if (!double.TryParse(finalTextBox.Text, out double parsedFinals))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                finalTextBox.Focus();
                finalTextBox.SelectAll();
            }
            else if (!double.TryParse(presentTextBox.Text, out double parsedPresent))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                presentTextBox.Focus();
                presentTextBox.SelectAll();
            }
            else if (!double.TryParse(absentTextBox.Text, out double parsedAbsent))
            {
                MessageBox.Show("Invalid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                absentTextBox.Focus();
                absentTextBox.SelectAll();
            }
            else
            {
                editScore();
            }

        }

        public void editScore()
        {
            Double.TryParse(quizOne.Text, out double parsedQuizOne);
            Double.TryParse(quizTwo.Text, out double parsedQuizTwo);
            Double.TryParse(quizThree.Text, out double parsedQuizThree);
            const double quizNoOfItems = 60;
            double quizTotal = parsedQuizOne + parsedQuizTwo + parsedQuizThree;
            double quizAverage = computeAverage(quizTotal, quizNoOfItems);
            double quizPercentage = computePercentage(quizAverage, .30);

            Double.TryParse(activityOneTextBox.Text, out double parsedActivityOne);
            Double.TryParse(activityTwoTextBox.Text, out double parsedActivityTwo);
            Double.TryParse(activityThreeTextBox.Text, out double parsedActivityThree);
            const double activityNoOfItems = 300;
            double activityTotal = parsedActivityOne + parsedActivityTwo + parsedActivityThree;
            double activityAverage = computeAverage(activityTotal, activityNoOfItems);
            double activityPercentage = computePercentage(activityAverage, .30);

            Double.TryParse(midtermTextBox.Text, out double parsedMidterm);
            Double.TryParse(finalTextBox.Text, out double parsedFinal);
            const double examNoOfItems = 200;
            double examTotal = parsedMidterm + parsedFinal;
            double examAverage = computeAverage(examTotal, examNoOfItems);
            double examPercentage = computePercentage(examAverage, .40);

            double finalGrade = computeFinalGrade(quizPercentage, activityPercentage, examPercentage);
            DataGridViewRow newData = dataGridView1.Rows[index];

            newData.Cells["Quiz 1"].Value = quizOne.Text;
            newData.Cells["Quiz 2"].Value = quizTwo.Text;
            newData.Cells["Quiz 3"].Value = quizThree.Text;

            newData.Cells["Quiz Percentage"].Value = quizPercentage.ToString("F") + "%";
            newData.Cells["Activity Percentage"].Value = activityPercentage.ToString("F") + "%";
            newData.Cells["Examination Percentage"].Value = examPercentage.ToString("F") + "%";
            newData.Cells["Final Grade"].Value = finalGrade.ToString("F") + "%";


            newData.Cells["Activity 1"].Value = activityOneTextBox.Text;
            newData.Cells["Activity 2"].Value = activityTwoTextBox.Text;
            newData.Cells["Activity 3"].Value = activityThreeTextBox.Text;

            newData.Cells["Midterm"].Value = midtermTextBox.Text;
            newData.Cells["Finals"].Value = finalTextBox.Text;

            newData.Cells["Present"].Value = presentTextBox.Text;
            newData.Cells["Absent"].Value = absentTextBox.Text;
            newData.Cells["Comments"].Value = commentTextBox.Text;


            if (finalGrade >= 97 && finalGrade <= 100)
            {
                newData.Cells["Final Grade(Letter)"].Value = "A+";
            }
            else if (finalGrade >= 93 && finalGrade < 96)
            {
                newData.Cells["Final Grade(Letter)"].Value = "A";
            }
            else if (finalGrade >= 90 && finalGrade < 92)
            {
                newData.Cells["Final Grade(Letter)"].Value = "A-";
            }
            else if (finalGrade >= 87 && finalGrade < 89)
            {
                newData.Cells["Final Grade(Letter)"].Value = "B+";
            }
            else if (finalGrade >= 83 && finalGrade < 86)
            {
                newData.Cells["Final Grade(Letter)"].Value = "B";
            }
            else if (finalGrade >= 80 && finalGrade < 82)
            {
                newData.Cells["Final Grade(Letter)"].Value = "B-";
            }
            else if (finalGrade >= 77 && finalGrade < 79)
            {
                newData.Cells["Final Grade(Letter)"].Value = "C+";
            }
            else if (finalGrade >= 73 && finalGrade < 76)
            {
                newData.Cells["Final Grade(Letter)"].Value = "C";
            }
            else if (finalGrade >= 70 && finalGrade < 72)
            {
                newData.Cells["Final Grade(Letter)"].Value = "C-";
            }
            else if (finalGrade >= 67 && finalGrade < 69)
            {
                newData.Cells["Final Grade(Letter)"].Value = "D";
            }
            else if (finalGrade >= 63 && finalGrade < 66)
            {
                newData.Cells["Final Grade(Letter)"].Value = "D-";
            }
            else if (finalGrade >= 60 && finalGrade < 62)
            {
                newData.Cells["Final Grade(Letter)"].Value = "F+";
            }

            if (finalGrade < 75)
            {
                newData.Cells["Final Grade(Pass/Fail)"].Value = "FAIL";
            }
            else if (finalGrade > 74)
            {
                newData.Cells["Final Grade(Pass/Fail)"].Value = "PASS";
            }

        }

        public void loadStudentData()
        {
            //Read the values in the textfile
            string[] nameArray = File.ReadAllLines(PublicData.studentNamesListCourseTwoSectionTwoDB);
            string[] studentNumberArray = File.ReadAllLines(PublicData.studentNumberListCourseTwoSectionTwoDB);

            string[] quizzOneArray = File.ReadAllLines(PublicData.quizOneCourseTwoSectionTwo);
            string[] quizzTwoArray = File.ReadAllLines(PublicData.quizTwoCourseTwoSectionTwo);
            string[] quizzThreeArray = File.ReadAllLines(PublicData.quizThreeCourseTwoSectionTwo);
            string[] quizzAverageArray = File.ReadAllLines(PublicData.quizAverageCourseTwoSectionTwo);

            string[] actOneArray = File.ReadAllLines(PublicData.activityOneCourseTwoSectionTwo);
            string[] actTwoArray = File.ReadAllLines(PublicData.activityTwoCourseTwoSectionTwo);
            string[] actThreeArray = File.ReadAllLines(PublicData.activityThreeCourseTwoSectionTwo);
            string[] actAverageArray = File.ReadAllLines(PublicData.activityAverageCourseTwoSectionTwo);

            string[] midtermArray = File.ReadAllLines(PublicData.midtermExamCourseTwoSectionTwo);
            string[] finalsArray = File.ReadAllLines(PublicData.finalExamCourseTwoSectionTwo);
            string[] examAverageArray = File.ReadAllLines(PublicData.examAverageCourseTwoSectionTwo);

            string[] finalGradeArray = File.ReadAllLines(PublicData.finalGradeCourseTwoSectionTwo);
            string[] finalGradeInLetter = File.ReadAllLines(PublicData.finalGradeInLetterCourseTwoSectionTwo);
            string[] finalGradeInStatus = File.ReadAllLines(PublicData.finalGradeInStatusCourseTwoSectionTwo);

            string[] presentArray = File.ReadAllLines(PublicData.presentCourseTwoSectionTwo);
            string[] absentArray = File.ReadAllLines(PublicData.absentCourseTwoSectionTwo);

            string[] commentArray = File.ReadAllLines(PublicData.commentsCourseTwoSectionTwo);

            MessageBox.Show("Name Array Length (Before):" + nameArray.Length.ToString());
            MessageBox.Show("Quiz One Array Length (Before):" + quizzOneArray.Length.ToString());


            //Put values in the textfile of components to avoid array out of bounds error
            if (quizzOneArray.Length == 0 || quizzOneArray.Length < nameArray.Length)
            {
                for (int i = 0; i < nameArray.Length; i++)
                {
                    File.AppendAllText(PublicData.quizOneCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizTwoCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizThreeCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizAverageCourseTwoSectionTwo, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.activityOneCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityTwoCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityThreeCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityAverageCourseTwoSectionTwo, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.midtermExamCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalExamCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.examAverageCourseTwoSectionTwo, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.presentCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.absentCourseTwoSectionTwo, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.finalGradeCourseTwoSectionTwo, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalGradeInLetterCourseTwoSectionTwo, "F" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalGradeInStatusCourseTwoSectionTwo, "FAIL" + Environment.NewLine);

                    File.AppendAllText(PublicData.commentsCourseTwoSectionTwo, "Write something.." + Environment.NewLine);
                }
            }

            //Read the lines again

            quizzOneArray = File.ReadAllLines(PublicData.quizOneCourseTwoSectionTwo);
            quizzTwoArray = File.ReadAllLines(PublicData.quizTwoCourseTwoSectionTwo);
            quizzThreeArray = File.ReadAllLines(PublicData.quizThreeCourseTwoSectionTwo);
            quizzAverageArray = File.ReadAllLines(PublicData.quizAverageCourseTwoSectionTwo);

            actOneArray = File.ReadAllLines(PublicData.activityOneCourseTwoSectionTwo);
            actTwoArray = File.ReadAllLines(PublicData.activityTwoCourseTwoSectionTwo);
            actThreeArray = File.ReadAllLines(PublicData.activityThreeCourseTwoSectionTwo);
            actAverageArray = File.ReadAllLines(PublicData.activityAverageCourseTwoSectionTwo);

            midtermArray = File.ReadAllLines(PublicData.midtermExamCourseTwoSectionTwo);
            finalsArray = File.ReadAllLines(PublicData.finalExamCourseTwoSectionTwo);
            examAverageArray = File.ReadAllLines(PublicData.examAverageCourseTwoSectionTwo);

            finalGradeArray = File.ReadAllLines(PublicData.finalGradeCourseTwoSectionTwo);
            finalGradeInLetter = File.ReadAllLines(PublicData.finalGradeInLetterCourseTwoSectionTwo);
            finalGradeInStatus = File.ReadAllLines(PublicData.finalGradeInStatusCourseTwoSectionTwo);

            presentArray = File.ReadAllLines(PublicData.presentCourseTwoSectionTwo);
            absentArray = File.ReadAllLines(PublicData.absentCourseTwoSectionTwo);
            commentArray = File.ReadAllLines(PublicData.commentsCourseTwoSectionTwo);


            //Display the rows
            for (int i = 0; i < nameArray.Length; i++)
            {
                table.Rows.Add(studentNumberArray[i], nameArray[i],
                    quizzOneArray[i], quizzTwoArray[i], quizzThreeArray[i], quizzAverageArray[i],
                     actOneArray[i], actTwoArray[i], actThreeArray[i], actAverageArray[i],
                     midtermArray[i], finalsArray[i], examAverageArray[i],
                     presentArray[i], absentArray[i],
                    finalGradeArray[i], finalGradeInLetter[i], finalGradeInStatus[i], commentArray[i]);
            }


        }

        public void saveGrade()
        {
            List<string> quizOneList = new List<string>();
            List<string> quizTwoList = new List<string>();
            List<string> quizThreeList = new List<string>();
            List<string> quizPercentage = new List<string>();

            List<string> actOneList = new List<string>();
            List<string> actTwoList = new List<string>();
            List<string> actThreeList = new List<string>();
            List<string> actPercentage = new List<string>();

            List<string> midtermList = new List<string>();
            List<string> finalsList = new List<string>();
            List<string> examPercentage = new List<string>();

            List<string> presentList = new List<string>();
            List<string> absentList = new List<string>();
            List<string> commentList = new List<string>();
            List<string> finalGradeList = new List<string>();
            List<string> finalGradeInLetterList = new List<string>();
            List<string> finalGradeInStatusList = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string quizOne = row.Cells["Quiz 1"].Value.ToString();
                    string quizTwo = row.Cells["Quiz 2"].Value.ToString();
                    string quizThree = row.Cells["Quiz 3"].Value.ToString();
                    string quizAverage = row.Cells["Quiz Percentage"].Value.ToString();


                    string actOne = row.Cells["Activity 1"].Value.ToString();
                    string actTwo = row.Cells["Activity 2"].Value.ToString();
                    string actThree = row.Cells["Activity 3"].Value.ToString();
                    string activityAverage = row.Cells["Activity Percentage"].Value.ToString();

                    string midterm = row.Cells["Midterm"].Value.ToString();
                    string finals = row.Cells["Finals"].Value.ToString();
                    string examAverage = row.Cells["Examination Percentage"].Value.ToString();

                    string present = row.Cells["Present"].Value.ToString();
                    string absent = row.Cells["Absent"].Value.ToString();
                    string comment = row.Cells["Comments"].Value.ToString();
                    string finalGrade = row.Cells["Final Grade"].Value.ToString();
                    string finalGradeInLetter = row.Cells["Final Grade(Letter)"].Value.ToString();
                    string finalGradeInStatus = row.Cells["Final Grade(Pass/Fail)"].Value.ToString();


                    quizOneList.Add(quizOne);
                    quizTwoList.Add(quizTwo);
                    quizThreeList.Add(quizThree);
                    quizPercentage.Add(quizAverage);

                    actOneList.Add(actOne);
                    actTwoList.Add(actTwo);
                    actThreeList.Add(actThree);
                    actPercentage.Add(activityAverage);

                    midtermList.Add(midterm);
                    finalsList.Add(finals);
                    examPercentage.Add(examAverage);

                    presentList.Add(present);
                    absentList.Add(absent);
                    commentList.Add(comment);

                    finalGradeList.Add(finalGrade);
                    finalGradeInLetterList.Add(finalGradeInLetter);
                    finalGradeInStatusList.Add(finalGradeInStatus);
                }
            }

            File.WriteAllLines(PublicData.quizOneCourseTwoSectionTwo, quizOneList);
            File.WriteAllLines(PublicData.quizTwoCourseTwoSectionTwo, quizTwoList);
            File.WriteAllLines(PublicData.quizThreeCourseTwoSectionTwo, quizThreeList);
            File.WriteAllLines(PublicData.quizAverageCourseTwoSectionTwo, quizPercentage);

            File.WriteAllLines(PublicData.activityOneCourseTwoSectionTwo, actOneList);
            File.WriteAllLines(PublicData.activityTwoCourseTwoSectionTwo, actTwoList);
            File.WriteAllLines(PublicData.activityThreeCourseTwoSectionTwo, actThreeList);
            File.WriteAllLines(PublicData.activityAverageCourseTwoSectionTwo, actPercentage);

            File.WriteAllLines(PublicData.midtermExamCourseTwoSectionTwo, midtermList);
            File.WriteAllLines(PublicData.finalExamCourseTwoSectionTwo, finalsList);
            File.WriteAllLines(PublicData.examAverageCourseTwoSectionTwo, examPercentage);

            File.WriteAllLines(PublicData.presentCourseTwoSectionTwo, presentList);
            File.WriteAllLines(PublicData.absentCourseTwoSectionTwo, absentList);
            File.WriteAllLines(PublicData.commentsCourseTwoSectionTwo, commentList);
            File.WriteAllLines(PublicData.finalGradeCourseTwoSectionTwo, finalGradeList);
            File.WriteAllLines(PublicData.finalGradeInLetterCourseTwoSectionTwo, finalGradeInLetterList);
            File.WriteAllLines(PublicData.finalGradeInStatusCourseTwoSectionTwo, finalGradeInStatusList);
            MessageBox.Show("Student data saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public double computeAverage(double totalScore, double totalNoOfItems)
        {
            double aveScore = (((totalScore / totalNoOfItems) * 50) + 50);

            return aveScore;
        }

        public double computePercentage(double aveScore, double constantPercentage)
        {
            double percentage = aveScore * constantPercentage;
            return percentage;
        }

        public double computeFinalGrade(double quizPercentage, double activityPercentage, double examPercentage)
        {
            double finalGrade = quizPercentage + activityPercentage + examPercentage;
            return finalGrade;
        }
    }
}

