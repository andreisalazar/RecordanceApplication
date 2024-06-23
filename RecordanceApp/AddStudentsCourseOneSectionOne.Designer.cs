namespace RecordanceApp
{
    partial class AddStudentsCourseOneSectionOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            titleLabel = new Label();
            panel2 = new Panel();
            label3 = new Label();
            newButton = new Button();
            backButton = new Button();
            gradeComputationButton = new Button();
            irregularStudentRadioButton = new RadioButton();
            regularStudentRadioButton = new RadioButton();
            editButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            middleNameTextBox = new TextBox();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            label1 = new Label();
            firstNameTextBox = new TextBox();
            label5 = new Label();
            studentNumberTextBox = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(7, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 63);
            panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(5, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(410, 40);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Course One : Section One";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(newButton);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(gradeComputationButton);
            panel2.Controls.Add(irregularStudentRadioButton);
            panel2.Controls.Add(regularStudentRadioButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(middleNameTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(firstNameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(studentNumberTextBox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(7, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 659);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 107);
            label3.Name = "label3";
            label3.Size = new Size(183, 27);
            label3.TabIndex = 45;
            label3.Text = "Add a student:";
            // 
            // newButton
            // 
            newButton.BackColor = Color.Maroon;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newButton.ForeColor = SystemColors.ButtonHighlight;
            newButton.Location = new Point(138, 485);
            newButton.Name = "newButton";
            newButton.Size = new Size(82, 43);
            newButton.TabIndex = 44;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(51, 593);
            backButton.Name = "backButton";
            backButton.Size = new Size(343, 43);
            backButton.TabIndex = 43;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // gradeComputationButton
            // 
            gradeComputationButton.BackColor = Color.Maroon;
            gradeComputationButton.FlatStyle = FlatStyle.Flat;
            gradeComputationButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gradeComputationButton.ForeColor = SystemColors.ButtonHighlight;
            gradeComputationButton.Location = new Point(51, 544);
            gradeComputationButton.Name = "gradeComputationButton";
            gradeComputationButton.Size = new Size(343, 43);
            gradeComputationButton.TabIndex = 42;
            gradeComputationButton.Text = "Grade Computation";
            gradeComputationButton.UseVisualStyleBackColor = false;
            gradeComputationButton.Click += gradeComputationButton_Click;
            // 
            // irregularStudentRadioButton
            // 
            irregularStudentRadioButton.AutoSize = true;
            irregularStudentRadioButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            irregularStudentRadioButton.Location = new Point(57, 433);
            irregularStudentRadioButton.Name = "irregularStudentRadioButton";
            irregularStudentRadioButton.Size = new Size(145, 22);
            irregularStudentRadioButton.TabIndex = 41;
            irregularStudentRadioButton.TabStop = true;
            irregularStudentRadioButton.Text = "Irregular Student";
            irregularStudentRadioButton.UseVisualStyleBackColor = true;
            irregularStudentRadioButton.CheckedChanged += irregularStudentRadioButton_CheckedChanged;
            // 
            // regularStudentRadioButton
            // 
            regularStudentRadioButton.AutoSize = true;
            regularStudentRadioButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regularStudentRadioButton.Location = new Point(57, 403);
            regularStudentRadioButton.Name = "regularStudentRadioButton";
            regularStudentRadioButton.Size = new Size(137, 22);
            regularStudentRadioButton.TabIndex = 40;
            regularStudentRadioButton.TabStop = true;
            regularStudentRadioButton.Text = "Regular Student";
            regularStudentRadioButton.UseVisualStyleBackColor = true;
            regularStudentRadioButton.CheckedChanged += regularStudentRadioButton_CheckedChanged;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Maroon;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(313, 485);
            editButton.Name = "editButton";
            editButton.Size = new Size(81, 43);
            editButton.TabIndex = 39;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Maroon;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(226, 485);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(81, 43);
            deleteButton.TabIndex = 38;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Maroon;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(50, 485);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 43);
            addButton.TabIndex = 37;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            middleNameTextBox.Location = new Point(51, 289);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(352, 27);
            middleNameTextBox.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 265);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 35;
            label2.Text = "Middle Name:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(51, 343);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(352, 27);
            lastNameTextBox.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 319);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 33;
            label1.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(51, 235);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(352, 27);
            firstNameTextBox.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 211);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 31;
            label5.Text = "First Name:";
            // 
            // studentNumberTextBox
            // 
            studentNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentNumberTextBox.Location = new Point(51, 181);
            studentNumberTextBox.Name = "studentNumberTextBox";
            studentNumberTextBox.Size = new Size(352, 27);
            studentNumberTextBox.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 157);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 29;
            label4.Text = "Student Number:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(475, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(698, 659);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(663, 616);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // AddStudentsCourseOneSectionOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudentsCourseOneSectionOne";
            Text = "Recordance";
            Load += AddStudentsCourseOneSectionOne_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox middleNameTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label1;
        private TextBox firstNameTextBox;
        private Label label5;
        private TextBox studentNumberTextBox;
        private Label label4;
        private RadioButton irregularStudentRadioButton;
        private RadioButton regularStudentRadioButton;
        private Button editButton;
        private Button deleteButton;
        private Button addButton;
        private Panel panel3;
        private Label titleLabel;
        private Button gradeComputationButton;
        private Button backButton;
        private DataGridView dataGridView1;
        private Button newButton;
        private Label label3;
    }
}