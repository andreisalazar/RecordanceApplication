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
    public partial class GradeComputationCourseTwoSectionOne : Form
    {
        DataTable table = new DataTable();
        int index;

        public GradeComputationCourseTwoSectionOne()
        {
            InitializeComponent();
        }

        private void GradeComputationCourseTwoSectionOne_Load(object sender, EventArgs e)
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
                !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizOne-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Quiz Two
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Quiz Three
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizThree-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Quiz Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Act One
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActOne-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Act Two
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Act Three
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActThree-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Act Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Midterm Exam
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Midterm-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Final Exam
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Finals-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Exam Average
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ExamAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Present
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Present-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Absent
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Absent-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Final Grade
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGrade-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Final Grade In Letter
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInLetter-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Final Grade In Status
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInStatus-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                //Comments
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Comments-" + PublicData.PublicCourseTwoSectionOne + ".txt"))
                )
            {
                //Quiz One
                var fileStreamOne = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-QuizOne-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-QuizTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Quiz Three
                var fileStreamThree = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-QuizThree-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Quiz Average
                var fileStreamFour = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-QuizAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Act One
                var fileStreamFive = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-ActOne-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Act Two
                var fileStreamSix = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-ActTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Act Three
                var fileStreamSeven = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-ActThree-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Act Average
                var fileStreamEight = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-ActAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Midterms
                var fileStreamNine = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-Midterm-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Finals
                var fileStreamTen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-Finals-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Exam Average
                var fileStreamEleven = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-ExamAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Present
                var fileStreamTwelve = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-Present-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Absent
                var fileStreamThirteen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-Absent-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Final Grade
                var fileStreamFourteen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-FinalGrade-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Final Grade in Letter
                var fileStreamFifteen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInLetter-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Final Grade In Status
                var fileStreamSixteen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInStatus-" + PublicData.PublicCourseTwoSectionOne + ".txt"));
                //Comments
                var fileStreamSeventeen = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername
                    + "-" + PublicData.PublicCourseNameTwo + "-Comments-" + PublicData.PublicCourseTwoSectionOne + ".txt"));

                //Assign the text files
                PublicData.quizOneCourseTwoSectionOne = fileStreamOne.Name;
                PublicData.quizTwoCourseTwoSectionOne = fileStreamTwo.Name;
                PublicData.quizThreeCourseTwoSectionOne = fileStreamThree.Name;
                PublicData.quizAverageCourseTwoSectionOne = fileStreamFour.Name;

                PublicData.activityOneCourseTwoSectionOne = fileStreamFive.Name;
                PublicData.activityTwoCourseTwoSectionOne = fileStreamSix.Name;
                PublicData.activityThreeCourseTwoSectionOne = fileStreamSeven.Name;
                PublicData.activityAverageCourseTwoSectionOne = fileStreamEight.Name;

                PublicData.midtermExamCourseTwoSectionOne = fileStreamNine.Name;
                PublicData.finalExamCourseTwoSectionOne = fileStreamTen.Name;
                PublicData.examAverageCourseTwoSectionOne = fileStreamEleven.Name;
                PublicData.presentCourseTwoSectionOne = fileStreamTwelve.Name;
                PublicData.absentCourseTwoSectionOne = fileStreamThirteen.Name;

                PublicData.finalGradeCourseTwoSectionOne = fileStreamFourteen.Name;
                PublicData.finalGradeInLetterCourseTwoSectionOne = fileStreamFifteen.Name;
                PublicData.finalGradeInStatusCourseTwoSectionOne = fileStreamSixteen.Name;

                PublicData.commentsCourseTwoSectionOne = fileStreamSeventeen.Name;

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

            PublicData.quizOneCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizOne-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.quizTwoCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.quizThreeCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizThree-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.quizAverageCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-QuizAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt");

            PublicData.activityOneCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActOne-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.activityTwoCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActTwo-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.activityThreeCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActThree-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.activityAverageCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ActAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt");


            PublicData.midtermExamCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Midterm-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.finalExamCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Finals-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.examAverageCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-ExamAverage-" + PublicData.PublicCourseTwoSectionOne + ".txt");

            PublicData.presentCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Present-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.absentCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Absent-" + PublicData.PublicCourseTwoSectionOne + ".txt");

            PublicData.finalGradeCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGrade-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.finalGradeInLetterCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInLetter-" + PublicData.PublicCourseTwoSectionOne + ".txt");
            PublicData.finalGradeInStatusCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-FinalGradeInStatus-" + PublicData.PublicCourseTwoSectionOne + ".txt");

            PublicData.commentsCourseTwoSectionOne = Path.Combine(PublicData.folder, PublicData.PublicUsername
                + "-" + PublicData.PublicCourseNameTwo + "-Comments-" + PublicData.PublicCourseTwoSectionOne + ".txt");

            loadStudentData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveGrade();
            this.Hide();
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
            string[] nameArray = File.ReadAllLines(PublicData.studentNamesListCourseTwoSectionOneDB);
            string[] studentNumberArray = File.ReadAllLines(PublicData.studentNumberListCourseTwoSectionOneDB);

            string[] quizzOneArray = File.ReadAllLines(PublicData.quizOneCourseTwoSectionOne);
            string[] quizzTwoArray = File.ReadAllLines(PublicData.quizTwoCourseTwoSectionOne);
            string[] quizzThreeArray = File.ReadAllLines(PublicData.quizThreeCourseTwoSectionOne);
            string[] quizzAverageArray = File.ReadAllLines(PublicData.quizAverageCourseTwoSectionOne);

            string[] actOneArray = File.ReadAllLines(PublicData.activityOneCourseTwoSectionOne);
            string[] actTwoArray = File.ReadAllLines(PublicData.activityTwoCourseTwoSectionOne);
            string[] actThreeArray = File.ReadAllLines(PublicData.activityThreeCourseTwoSectionOne);
            string[] actAverageArray = File.ReadAllLines(PublicData.activityAverageCourseTwoSectionOne);

            string[] midtermArray = File.ReadAllLines(PublicData.midtermExamCourseTwoSectionOne);
            string[] finalsArray = File.ReadAllLines(PublicData.finalExamCourseTwoSectionOne);
            string[] examAverageArray = File.ReadAllLines(PublicData.examAverageCourseTwoSectionOne);

            string[] finalGradeArray = File.ReadAllLines(PublicData.finalGradeCourseTwoSectionOne);
            string[] finalGradeInLetter = File.ReadAllLines(PublicData.finalGradeInLetterCourseTwoSectionOne);
            string[] finalGradeInStatus = File.ReadAllLines(PublicData.finalGradeInStatusCourseTwoSectionOne);

            string[] presentArray = File.ReadAllLines(PublicData.presentCourseTwoSectionOne);
            string[] absentArray = File.ReadAllLines(PublicData.absentCourseTwoSectionOne);

            string[] commentArray = File.ReadAllLines(PublicData.commentsCourseTwoSectionOne);

            MessageBox.Show("Name Array Length (Before):" + nameArray.Length.ToString());
            MessageBox.Show("Quiz One Array Length (Before):" + quizzOneArray.Length.ToString());


            //Put values in the textfile of components to avoid array out of bounds error
            if (quizzOneArray.Length == 0 || quizzOneArray.Length < nameArray.Length)
            {
                for (int i = 0; i < nameArray.Length; i++)
                {
                    File.AppendAllText(PublicData.quizOneCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizTwoCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizThreeCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.quizAverageCourseTwoSectionOne, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.activityOneCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityTwoCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityThreeCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.activityAverageCourseTwoSectionOne, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.midtermExamCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalExamCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.examAverageCourseTwoSectionOne, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.presentCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.absentCourseTwoSectionOne, "0" + Environment.NewLine);

                    File.AppendAllText(PublicData.finalGradeCourseTwoSectionOne, "0" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalGradeInLetterCourseTwoSectionOne, "F" + Environment.NewLine);
                    File.AppendAllText(PublicData.finalGradeInStatusCourseTwoSectionOne, "FAIL" + Environment.NewLine);

                    File.AppendAllText(PublicData.commentsCourseTwoSectionOne, "Write something.." + Environment.NewLine);
                }
            }

            //Read the lines again

            quizzOneArray = File.ReadAllLines(PublicData.quizOneCourseTwoSectionOne);
            quizzTwoArray = File.ReadAllLines(PublicData.quizTwoCourseTwoSectionOne);
            quizzThreeArray = File.ReadAllLines(PublicData.quizThreeCourseTwoSectionOne);
            quizzAverageArray = File.ReadAllLines(PublicData.quizAverageCourseTwoSectionOne);

            actOneArray = File.ReadAllLines(PublicData.activityOneCourseTwoSectionOne);
            actTwoArray = File.ReadAllLines(PublicData.activityTwoCourseTwoSectionOne);
            actThreeArray = File.ReadAllLines(PublicData.activityThreeCourseTwoSectionOne);
            actAverageArray = File.ReadAllLines(PublicData.activityAverageCourseTwoSectionOne);

            midtermArray = File.ReadAllLines(PublicData.midtermExamCourseTwoSectionOne);
            finalsArray = File.ReadAllLines(PublicData.finalExamCourseTwoSectionOne);
            examAverageArray = File.ReadAllLines(PublicData.examAverageCourseTwoSectionOne);

            finalGradeArray = File.ReadAllLines(PublicData.finalGradeCourseTwoSectionOne);
            finalGradeInLetter = File.ReadAllLines(PublicData.finalGradeInLetterCourseTwoSectionOne);
            finalGradeInStatus = File.ReadAllLines(PublicData.finalGradeInStatusCourseTwoSectionOne);

            presentArray = File.ReadAllLines(PublicData.presentCourseTwoSectionOne);
            absentArray = File.ReadAllLines(PublicData.absentCourseTwoSectionOne);
            commentArray = File.ReadAllLines(PublicData.commentsCourseTwoSectionOne);


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

            File.WriteAllLines(PublicData.quizOneCourseTwoSectionOne, quizOneList);
            File.WriteAllLines(PublicData.quizTwoCourseTwoSectionOne, quizTwoList);
            File.WriteAllLines(PublicData.quizThreeCourseTwoSectionOne, quizThreeList);
            File.WriteAllLines(PublicData.quizAverageCourseTwoSectionOne, quizPercentage);

            File.WriteAllLines(PublicData.activityOneCourseTwoSectionOne, actOneList);
            File.WriteAllLines(PublicData.activityTwoCourseTwoSectionOne, actTwoList);
            File.WriteAllLines(PublicData.activityThreeCourseTwoSectionOne, actThreeList);
            File.WriteAllLines(PublicData.activityAverageCourseTwoSectionOne, actPercentage);

            File.WriteAllLines(PublicData.midtermExamCourseTwoSectionOne, midtermList);
            File.WriteAllLines(PublicData.finalExamCourseTwoSectionOne, finalsList);
            File.WriteAllLines(PublicData.examAverageCourseTwoSectionOne, examPercentage);

            File.WriteAllLines(PublicData.presentCourseTwoSectionOne, presentList);
            File.WriteAllLines(PublicData.absentCourseTwoSectionOne, absentList);
            File.WriteAllLines(PublicData.commentsCourseTwoSectionOne, commentList);
            File.WriteAllLines(PublicData.finalGradeCourseTwoSectionOne, finalGradeList);
            File.WriteAllLines(PublicData.finalGradeInLetterCourseTwoSectionOne, finalGradeInLetterList);
            File.WriteAllLines(PublicData.finalGradeInStatusCourseTwoSectionOne, finalGradeInStatusList);
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
