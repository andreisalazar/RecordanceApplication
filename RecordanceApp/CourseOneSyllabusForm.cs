﻿using System;
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
    public partial class CourseOneSyllabusForm : Form
    {
        DataTable table = new DataTable();
        int index;
        string status = string.Empty;
        string modeOfLearning = string.Empty;
        string classType = string.Empty;
        public CourseOneSyllabusForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void CourseOneSyllabusForm_Load(object sender, EventArgs e)
        {
            //Display the Title
          
            titleLabel.Text = "Syllabus-" + PublicData.PublicCourseNameOne;

            //Add Columns to the table
            dataGridView1.ReadOnly = true;
            table.Columns.Add("Topic Name", Type.GetType("System.String"));
            table.Columns.Add("Week", Type.GetType("System.String"));
            table.Columns.Add("Mode of Learning", Type.GetType("System.String"));
            table.Columns.Add("Class Type", Type.GetType("System.String"));
            table.Columns.Add("Status", Type.GetType("System.String"));

            dataGridView1.DataSource = table;

            //Check if the file exists
            if (!File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusNames-" +
                PublicData.PublicCourseNameOne + ".txt"))
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusDetails-" + PublicData.PublicCourseNameOne + ".txt")))
            {
                //Create the file
                var fileStreamOne = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusNames-" +
                PublicData.PublicCourseNameOne + ".txt"));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusDetails-" + PublicData.PublicCourseNameOne + ".txt"));

                //Assign it to the public variables
                PublicData.courseOneSyllabusNames = fileStreamOne.Name;
                PublicData.courseOneSyllabusDetails = fileStreamTwo.Name;

                //Close the file
                fileStreamOne.Close();
                fileStreamTwo.Close();

            }

            PublicData.courseOneSyllabusNames = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusNames-" + PublicData.PublicCourseNameOne + ".txt");
            PublicData.courseOneSyllabusDetails = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-SyllabusDetails-" + PublicData.PublicCourseNameOne + ".txt");
            //Load the files
            loadTopicData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveTopicData();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (topicNameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the topic name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topicNameTextBox.Focus();
            }
            else if (double.TryParse(topicNameTextBox.Text, out double parsedTopicName))
            {
                MessageBox.Show("Topic name cannot be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topicNameTextBox.Focus();
                topicNameTextBox.Text = "";
            }
            else if (weekTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the topic week.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                weekTextBox.Focus();
            }
            else if (double.TryParse(topicNameTextBox.Text, out double parsedWeek))
            {
                MessageBox.Show("Week cannot be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topicNameTextBox.Focus();
                topicNameTextBox.Text = "";
            }

            else if (!onlineRadioButton.Checked && !facetofaceRadioButton.Checked)
            {
                MessageBox.Show("Kindly select a mode of learning.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!synchronousRadioButton.Checked && !asynchronousRadioButton.Checked)
            {
                MessageBox.Show("Kindly select a class type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ongoingRadioButton.Checked && !finishedRadioButton.Checked)
            {
                MessageBox.Show("Kindly select a topic status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                addTopic();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editTopic();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newTopic();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteTopic();
        }


        public void addTopic()
        {
            table.Rows.Add(topicNameTextBox.Text, weekTextBox.Text, modeOfLearning, classType, status);
        }

        public void editTopic()
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells["Topic Name"].Value = topicNameTextBox.Text;
            newData.Cells["Week"].Value = weekTextBox.Text;
            newData.Cells["Mode of Learning"].Value = modeOfLearning;
            newData.Cells["Status"].Value = status;
            newData.Cells["Class Type"].Value = classType;
        }

        public void deleteTopic()
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        public void newTopic()
        {
            topicNameTextBox.Text = string.Empty;
            weekTextBox.Text = string.Empty;
            onlineRadioButton.Checked = false;
            facetofaceRadioButton.Checked = false;
            synchronousRadioButton.Checked = false;
            asynchronousRadioButton.Checked = false;
            ongoingRadioButton.Checked = false;
            finishedRadioButton.Checked = false;

        }

        public void saveTopicData()
        {
            List<string> topicNamesList = new List<string>();
            List<string> topicDetailsList = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    //Get the value
                    string topicName = row.Cells["Topic Name"].Value.ToString();
                    string status = row.Cells["Status"].Value.ToString();
                    string modeOfLearning = row.Cells["Mode of Learning"].Value.ToString();
                    string classType = row.Cells["Class Type"].Value.ToString();
                    string week = row.Cells["Week"].Value.ToString();

                    //Add it to the list
                    topicNamesList.Add(topicName);
                    topicDetailsList.Add(week + " " + modeOfLearning + " " + classType + " " + status);
                }
            }

            //Write it in the text file
            File.WriteAllLines(PublicData.courseOneSyllabusNames, topicNamesList);
            File.WriteAllLines(PublicData.courseOneSyllabusDetails, topicDetailsList);
            MessageBox.Show("Student data saved successfully!");
        }

        public void loadTopicData()
        {
            if (File.Exists(PublicData.courseOneSyllabusNames) && File.Exists(PublicData.courseOneSyllabusDetails))
            {
                string[] topicNameArray = File.ReadAllLines(PublicData.courseOneSyllabusNames);
                string[] topicDetailsArray = File.ReadAllLines(PublicData.courseOneSyllabusDetails);

                for (int i = 0; i < Math.Min(topicDetailsArray.Length, topicNameArray.Length); i++)
                {
                    string[] details = topicDetailsArray[i].Split(' ');

                    if (details.Length == 4)
                    {
                        table.Rows.Add(topicNameArray[i], details[0], details[1], details[2], details[3]);
                    }
                }
            }

        }

        private void onlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modeOfLearning = onlineRadioButton.Text;
        }

        private void facetofaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modeOfLearning = facetofaceRadioButton.Text;
        }

        private void synchronousRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            classType = synchronousRadioButton.Text;
        }

        private void asynchronousRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            classType = asynchronousRadioButton.Text;
        }

        private void ongoingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            status = ongoingRadioButton.Text;
        }

        private void finishedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            status = finishedRadioButton.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            topicNameTextBox.Text = row.Cells["Topic Name"].Value.ToString();
            weekTextBox.Text = row.Cells["Week"].Value.ToString();
            if (row.Cells["Status"].Value == "Ongoing")
            {
                ongoingRadioButton.Checked = true;
                finishedRadioButton.Checked = false;
            }
            else
            {
                ongoingRadioButton.Checked = false;
                finishedRadioButton.Checked = true;
            }
            if (row.Cells["Mode of Learning"].Value == "Online")
            {
                onlineRadioButton.Checked = true;
                facetofaceRadioButton.Checked = false;
            }
            else
            {
                onlineRadioButton.Checked = false;
                facetofaceRadioButton.Checked = true;
            }
            if (row.Cells["Class Type"].Value == "Asynchronous")
            {
                asynchronousRadioButton.Checked = true;
                synchronousRadioButton.Checked = false;
            }
            else
            {
                asynchronousRadioButton.Checked = false;
                synchronousRadioButton.Checked = true;
            }
        }
    }
}
