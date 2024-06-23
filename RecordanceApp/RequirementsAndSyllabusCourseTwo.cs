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
    public partial class RequirementsAndSyllabusCourseTwo : Form
    {
        public RequirementsAndSyllabusCourseTwo()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        DataTable table = new DataTable();
        string requirementStatus;
        int index;

        private void RequirementsAndSyllabusCourseTwo_Load(object sender, EventArgs e)
        {

           
            titleLabel.Text = "Requirements - " + PublicData.PublicCourseNameTwo;

            dataGridView1.ReadOnly = true;

            table.Columns.Add("Requirement Name", Type.GetType("System.String"));
            table.Columns.Add("Type", Type.GetType("System.String"));
            table.Columns.Add("Status", Type.GetType("System.String"));

            dataGridView1.DataSource = table;

            //Check if the file exists
            if (!File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Names" + ".txt"))
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Type" + ".txt"))
                && !File.Exists(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Status" + ".txt")))
            {
                //Create the files
                var fileStreamOne = File.Create((Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Names" + ".txt")));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Type" + ".txt"));
                var fileStreamThree = File.Create(Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Status" + ".txt"));

                //Assign the Public Variables
                PublicData.courseTwoRequirementNameDB = fileStreamOne.Name;
                PublicData.courseTwoReqStatusDB = fileStreamTwo.Name;
                PublicData.courseTwoReqTypeDB = fileStreamThree.Name;

                fileStreamOne.Close();
                fileStreamTwo.Close();
                fileStreamThree.Close();
            }

            //Assign the Public Variables
            PublicData.courseTwoRequirementNameDB = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Names" + ".txt");
            PublicData.courseTwoReqStatusDB = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Type" + ".txt");
            PublicData.courseTwoReqTypeDB = Path.Combine(PublicData.folder, PublicData.PublicUsername + "-" + PublicData.PublicCourseNameTwo + "-Requirement Status" + ".txt");

            loadRequirementData();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            saveRequirementData();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (requirementNameTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the requirement name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                requirementNameTextBox.Focus();
            }
            else if (double.TryParse(requirementNameTextBox.Text, out double reqNameParsed))
            {
                MessageBox.Show("Requirement name cannot be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                requirementNameTextBox.Focus();
            }
            else if (requirementTypeTextBox.Text == "")
            {
                MessageBox.Show("Kindly enter the requirement type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                requirementTypeTextBox.Focus();
            }
            else if (double.TryParse(requirementNameTextBox.Text, out double reqTypeParsed))
            {
                MessageBox.Show("Requirement type cannot be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                requirementTypeTextBox.Focus();
            }
            else if (!finishedRadioButton.Checked && !onGoingRadioButton.Checked)
            {
                MessageBox.Show("Kindly select the requirement status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                onGoingRadioButton.Focus();
            }
            else
            {
                addRequirement();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editRequirement();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newRequirement();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRequirement();
        }

        public void addRequirement()
        {
            table.Rows.Add(requirementNameTextBox.Text, requirementTypeTextBox.Text, requirementStatus);
        }

        public void editRequirement()
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells["Requirement Name"].Value = requirementNameTextBox.Text;
            newData.Cells["Type"].Value = requirementTypeTextBox.Text;
            newData.Cells["Status"].Value = requirementStatus;
        }

        public void newRequirement()
        {
            requirementNameTextBox.Text = string.Empty;
            requirementTypeTextBox.Text = string.Empty;
            onGoingRadioButton.Checked = false;
            finishedRadioButton.Checked = false;
        }

        public void deleteRequirement()
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void onGoingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            requirementStatus = onGoingRadioButton.Text;
        }

        private void finishedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            requirementStatus = finishedRadioButton.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            requirementNameTextBox.Text = row.Cells["Requirement Name"].Value.ToString();
            requirementTypeTextBox.Text = row.Cells["Type"].Value.ToString();

            if (row.Cells["Status"].Value == "On going")
            {
                onGoingRadioButton.Checked = true;
                finishedRadioButton.Checked = false;
            }
            else
            {
                onGoingRadioButton.Checked = false;
                finishedRadioButton.Checked = true;
            }
        }

        public void saveRequirementData()
        {
            List<string> requirementNameList = new List<string>();
            List<string> requirementTypeList = new List<string>();
            List<string> requirementStatusList = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string requirementName = row.Cells["Requirement Name"].Value.ToString();
                    string requirementType = row.Cells["Type"].Value.ToString();
                    string requirementStatus = row.Cells["Status"].Value.ToString();

                    requirementNameList.Add(requirementName);
                    requirementTypeList.Add(requirementType);
                    requirementStatusList.Add(requirementStatus);
                }
            }

            File.WriteAllLines(PublicData.courseTwoRequirementNameDB, requirementNameList);
            File.WriteAllLines(PublicData.courseTwoReqTypeDB, requirementTypeList);
            File.WriteAllLines(PublicData.courseTwoReqStatusDB, requirementStatusList);
            MessageBox.Show("Requirement data saved successfully!");
        }

        public void loadRequirementData()
        {

            string[] courseTwoRequirementNameArray = File.ReadAllLines(PublicData.courseTwoRequirementNameDB);
            string[] courseTwoRequirementStatusArray = File.ReadAllLines(PublicData.courseTwoReqStatusDB);
            string[] courseTwoRequirementTypeArray = File.ReadAllLines(PublicData.courseTwoReqTypeDB);

            for (int i = 0; i < Math.Min(courseTwoRequirementNameArray.Length, courseTwoRequirementStatusArray.Length); i++)
            {
                table.Rows.Add(courseTwoRequirementNameArray[i], courseTwoRequirementTypeArray[i], courseTwoRequirementStatusArray[i]);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
