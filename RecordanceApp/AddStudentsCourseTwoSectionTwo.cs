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
    public partial class AddStudentsCourseTwoSectionTwo : Form
    {
        DataTable table = new DataTable();
        string studentStatus = "";
        int index;

        public AddStudentsCourseTwoSectionTwo()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void AddStudentsCourseTwoSectionTwo_Load(object sender, EventArgs e)
        {
            titleLabel.Text = PublicData.PublicCourseTwoSectionTwo;

            //Add the columns to the data grid view object:
            table.Columns.Add("Student Number", Type.GetType("System.String"));
            table.Columns.Add("Student Status", Type.GetType("System.String"));
            table.Columns.Add("First Name", Type.GetType("System.String"));
            table.Columns.Add("Last Name", Type.GetType("System.String"));
            table.Columns.Add("Middle Name", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = false;

            //Create a text file if the text file does not exist
            if (!File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Names-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt"))
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Number-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt")))
            {
                //Create files
                var fileStreamOne = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Names-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt"));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Number-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt"));

                //Assign the files
                PublicData.studentNamesListCourseTwoSectionTwoDB = fileStreamOne.Name;
                PublicData.studentNumberListCourseTwoSectionTwoDB = fileStreamTwo.Name;

                //Close the files
                fileStreamOne.Close();
                fileStreamTwo.Close();
            }
            //Assign the files
            PublicData.studentNamesListCourseTwoSectionTwoDB = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Names-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt");
            PublicData.studentNumberListCourseTwoSectionTwoDB = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-Student Number-" + PublicData.PublicCourseNameTwo + "-" + PublicData.PublicCourseTwoSectionTwo + ".txt");
            //Load the files
            loadDataFromFiles();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveStudentData();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (studentNumberTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the student number", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentNumberTextBox.Focus();
            }
            //Empty First Name
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your first name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            //First Name Length Validation
            else if (firstNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("First name should be 2 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
                firstNameTextBox.SelectAll();
            }
            //Number First Name Validation
            else if (double.TryParse(firstNameTextBox.Text, out double firstnameParsed))
            {
                MessageBox.Show("First name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Text = "";
            }
            /* Middle name Validation */
            //Empty middle name
            else if (middleNameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the middle name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                middleNameTextBox.Focus();
            }
            //Middle Name Length Validation
            else if (middleNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Middle name should be 2 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                middleNameTextBox.Focus();
                middleNameTextBox.SelectAll();
            }
            //Middle Name Number Validation
            else if (double.TryParse(middleNameTextBox.Text, out double middlenameParsed))
            {
                MessageBox.Show("Middle name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                middleNameTextBox.Text = "";
            }
            /* Lastname Validation */
            //Empty last name
            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter your last name."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Focus();
            }
            //Last Name Length Validation
            else if (lastNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Last name should be 2 characters long."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Focus();
                lastNameTextBox.SelectAll();
            }
            //Last Name as Number
            else if (double.TryParse(lastNameTextBox.Text, out double lastnameParsed))
            {
                MessageBox.Show("Last name cannot be a number."
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Text = "";
            }
            else if (!regularStudentRadioButton.Checked && !irregularStudentRadioButton.Checked)
            {
                MessageBox.Show("Please update the student status."
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                regularStudentRadioButton.Focus();
            }
            else
            {
                addStudent();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteStudent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editStudent();
        }

        private void gradeComputationButton_Click(object sender, EventArgs e)
        {
            saveStudentData();
            this.Hide();
          
            GradeComputationCourseTwoSectionTwo gcCourseTwoSectionTwo = new GradeComputationCourseTwoSectionTwo();
            gcCourseTwoSectionTwo.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newStudent();
        }

        public void addStudent()
        {
            if (irregularStudentRadioButton.Checked)
            {
                studentStatus = irregularStudentRadioButton.Text;
            }
            if (regularStudentRadioButton.Checked)
            {
                studentStatus = regularStudentRadioButton.Text;
            }

            //Add the values to the row
            table.Rows.Add(studentNumberTextBox.Text, studentStatus, lastNameTextBox.Text,
                firstNameTextBox.Text, middleNameTextBox.Text);
        }

        public void deleteStudent()
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        public void editStudent()
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells["Student Number"].Value = studentNumberTextBox.Text;
            newData.Cells["Last Name"].Value = lastNameTextBox.Text;
            newData.Cells["First Name"].Value = firstNameTextBox.Text;
            newData.Cells["Middle Name"].Value = middleNameTextBox.Text;
            newData.Cells["Status"].Value = studentStatus;
        }

        public void newStudent()
        {
            studentNumberTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        public void loadDataFromFiles()
        {
            string[] studentNameArray = File.ReadAllLines(PublicData.studentNamesListCourseTwoSectionTwoDB);
            string[] studentNumberArray = File.ReadAllLines(PublicData.studentNumberListCourseTwoSectionTwoDB);

            for (int i = 0; i < Math.Min(studentNameArray.Length, studentNumberArray.Length); i++)
            {
                string[] nameParts = studentNameArray[i].Split(' ');
                string studentInfo = studentNumberArray[i]; // Get the student information string
                string[] infoParts = studentInfo.Split(' '); // Split the student information string
                string studentNumber = infoParts[0]; // Get the student number from the first part
                string status = infoParts.Length > 1 ? infoParts[1] : ""; // Get the status if available


                string lastName = nameParts.Length > 2 ? nameParts[0] : "";
                string firstName = nameParts.Length > 0 ? nameParts[1] : "";
                string middleName = nameParts.Length > 1 ? nameParts[2] : "";

                table.Rows.Add(studentNumber, status, lastName, firstName, middleName);
            }
        }

        public void saveStudentData()
        {
            List<string> studentNamesList = new List<string>();
            List<string> studentNumbersList = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    //Get the value
                    string studentNumber = row.Cells["Student Number"].Value.ToString();
                    string status = row.Cells["Student Status"].Value.ToString();
                    string lastName = row.Cells["Last Name"].Value.ToString();
                    string firstName = row.Cells["First Name"].Value.ToString();
                    string middleName = row.Cells["Middle Name"].Value.ToString();

                    //Add it to the list
                    studentNamesList.Add(lastName + " " + firstName + " " + middleName);
                    studentNumbersList.Add(studentNumber + " " + status);
                }
            }

            //Write it in the text file
            File.WriteAllLines(PublicData.studentNamesListCourseTwoSectionTwoDB, studentNamesList);
            File.WriteAllLines(PublicData.studentNumberListCourseTwoSectionTwoDB, studentNumbersList);
            MessageBox.Show("Student data saved successfully!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            //Get the value of the row and display it to the textboxes
            studentNumberTextBox.Text = row.Cells["Student Number"].Value.ToString();
            firstNameTextBox.Text = row.Cells["First Name"].Value.ToString();
            middleNameTextBox.Text = row.Cells["Middle Name"].Value.ToString();
            lastNameTextBox.Text = row.Cells["Last Name"].Value.ToString();

        }

        private void regularStudentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentStatus = regularStudentRadioButton.Text;
        }

        private void irregularStudentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            studentStatus = irregularStudentRadioButton.Text;
        }
    }
}
