namespace RecordanceApp
{
    partial class RequirementsAndSyllabusCourseOne
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
            requirementTypeTextBox = new TextBox();
            label4 = new Label();
            backButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            addButton = new Button();
            finishedRadioButton = new RadioButton();
            onGoingRadioButton = new RadioButton();
            label3 = new Label();
            requirementNameTextBox = new TextBox();
            label2 = new Label();
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
            panel1.Location = new Point(12, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 69);
            panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(20, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(436, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Requirements - Course One";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(requirementTypeTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(newButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(finishedRadioButton);
            panel2.Controls.Add(onGoingRadioButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(requirementNameTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 650);
            panel2.TabIndex = 1;
            // 
            // requirementTypeTextBox
            // 
            requirementTypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            requirementTypeTextBox.Location = new Point(42, 241);
            requirementTypeTextBox.Name = "requirementTypeTextBox";
            requirementTypeTextBox.Size = new Size(352, 27);
            requirementTypeTextBox.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 216);
            label4.Name = "label4";
            label4.Size = new Size(165, 21);
            label4.TabIndex = 53;
            label4.Text = "Requirement Type:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(42, 501);
            backButton.Name = "backButton";
            backButton.Size = new Size(431, 43);
            backButton.TabIndex = 50;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Maroon;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(266, 447);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(207, 43);
            deleteButton.TabIndex = 49;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Maroon;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(266, 382);
            editButton.Name = "editButton";
            editButton.Size = new Size(207, 43);
            editButton.TabIndex = 48;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = Color.Maroon;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            newButton.ForeColor = SystemColors.ButtonHighlight;
            newButton.Location = new Point(42, 447);
            newButton.Name = "newButton";
            newButton.Size = new Size(207, 43);
            newButton.TabIndex = 46;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Maroon;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(40, 382);
            addButton.Name = "addButton";
            addButton.Size = new Size(207, 43);
            addButton.TabIndex = 38;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // finishedRadioButton
            // 
            finishedRadioButton.AutoSize = true;
            finishedRadioButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            finishedRadioButton.Location = new Point(42, 344);
            finishedRadioButton.Name = "finishedRadioButton";
            finishedRadioButton.Size = new Size(85, 22);
            finishedRadioButton.TabIndex = 34;
            finishedRadioButton.TabStop = true;
            finishedRadioButton.Text = "Finished";
            finishedRadioButton.UseVisualStyleBackColor = true;
            finishedRadioButton.CheckedChanged += finishedRadioButton_CheckedChanged;
            // 
            // onGoingRadioButton
            // 
            onGoingRadioButton.AutoSize = true;
            onGoingRadioButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            onGoingRadioButton.Location = new Point(42, 314);
            onGoingRadioButton.Name = "onGoingRadioButton";
            onGoingRadioButton.Size = new Size(87, 22);
            onGoingRadioButton.TabIndex = 33;
            onGoingRadioButton.TabStop = true;
            onGoingRadioButton.Text = "Ongoing";
            onGoingRadioButton.UseVisualStyleBackColor = true;
            onGoingRadioButton.CheckedChanged += onGoingRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 290);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 32;
            label3.Text = "Status:";
            // 
            // requirementNameTextBox
            // 
            requirementNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            requirementNameTextBox.Location = new Point(42, 171);
            requirementNameTextBox.Name = "requirementNameTextBox";
            requirementNameTextBox.Size = new Size(352, 27);
            requirementNameTextBox.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 146);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 0;
            label2.Text = "Requirement Name:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(522, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(651, 650);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(627, 614);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // RequirementsAndSyllabusCourseOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RequirementsAndSyllabusCourseOne";
            Text = "Recordance";
            Load += RequirementsAndSyllabusCourseOne_Load;
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
        private Panel panel3;
        private Label titleLabel;
        private Label label2;
        private RadioButton finishedRadioButton;
        private RadioButton onGoingRadioButton;
        private Label label3;
        private TextBox requirementNameTextBox;
        private Button addButton;
        private Button newButton;
        private Button editButton;
        private Button backButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private TextBox requirementTypeTextBox;
        private Label label4;
    }
}