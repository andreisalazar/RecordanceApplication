namespace RecordanceApp
{
    partial class CourseTwoSyllabusForm
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
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            finishedRadioButton = new RadioButton();
            ongoingRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            asynchronousRadioButton = new RadioButton();
            synchronousRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            facetofaceRadioButton = new RadioButton();
            onlineRadioButton = new RadioButton();
            weekTextBox = new TextBox();
            label4 = new Label();
            backButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            addButton = new Button();
            topicNameTextBox = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            titleLabel = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(482, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(691, 668);
            panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 639);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(weekTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(newButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(topicNameTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 668);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(finishedRadioButton);
            groupBox3.Controls.Add(ongoingRadioButton);
            groupBox3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(11, 362);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(419, 102);
            groupBox3.TabIndex = 69;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // finishedRadioButton
            // 
            finishedRadioButton.AutoSize = true;
            finishedRadioButton.Location = new Point(53, 48);
            finishedRadioButton.Name = "finishedRadioButton";
            finishedRadioButton.Size = new Size(85, 22);
            finishedRadioButton.TabIndex = 2;
            finishedRadioButton.TabStop = true;
            finishedRadioButton.Text = "Finished";
            finishedRadioButton.UseVisualStyleBackColor = true;
            finishedRadioButton.CheckedChanged += finishedRadioButton_CheckedChanged;
            // 
            // ongoingRadioButton
            // 
            ongoingRadioButton.AutoSize = true;
            ongoingRadioButton.Location = new Point(53, 24);
            ongoingRadioButton.Name = "ongoingRadioButton";
            ongoingRadioButton.Size = new Size(87, 22);
            ongoingRadioButton.TabIndex = 1;
            ongoingRadioButton.TabStop = true;
            ongoingRadioButton.Text = "Ongoing";
            ongoingRadioButton.UseVisualStyleBackColor = true;
            ongoingRadioButton.CheckedChanged += ongoingRadioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(asynchronousRadioButton);
            groupBox2.Controls.Add(synchronousRadioButton);
            groupBox2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 102);
            groupBox2.TabIndex = 68;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class Type";
            // 
            // asynchronousRadioButton
            // 
            asynchronousRadioButton.AutoSize = true;
            asynchronousRadioButton.Location = new Point(51, 52);
            asynchronousRadioButton.Name = "asynchronousRadioButton";
            asynchronousRadioButton.Size = new Size(124, 22);
            asynchronousRadioButton.TabIndex = 2;
            asynchronousRadioButton.TabStop = true;
            asynchronousRadioButton.Text = "Asynchronous";
            asynchronousRadioButton.UseVisualStyleBackColor = true;
            asynchronousRadioButton.CheckedChanged += asynchronousRadioButton_CheckedChanged;
            // 
            // synchronousRadioButton
            // 
            synchronousRadioButton.AutoSize = true;
            synchronousRadioButton.Location = new Point(52, 24);
            synchronousRadioButton.Name = "synchronousRadioButton";
            synchronousRadioButton.Size = new Size(116, 22);
            synchronousRadioButton.TabIndex = 1;
            synchronousRadioButton.TabStop = true;
            synchronousRadioButton.Text = "Synchronous";
            synchronousRadioButton.UseVisualStyleBackColor = true;
            synchronousRadioButton.CheckedChanged += synchronousRadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(facetofaceRadioButton);
            groupBox1.Controls.Add(onlineRadioButton);
            groupBox1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 102);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mode of Learning";
            // 
            // facetofaceRadioButton
            // 
            facetofaceRadioButton.AutoSize = true;
            facetofaceRadioButton.Location = new Point(51, 52);
            facetofaceRadioButton.Name = "facetofaceRadioButton";
            facetofaceRadioButton.Size = new Size(116, 22);
            facetofaceRadioButton.TabIndex = 1;
            facetofaceRadioButton.TabStop = true;
            facetofaceRadioButton.Text = "Face-to-Face";
            facetofaceRadioButton.UseVisualStyleBackColor = true;
            facetofaceRadioButton.CheckedChanged += facetofaceRadioButton_CheckedChanged;
            // 
            // onlineRadioButton
            // 
            onlineRadioButton.AutoSize = true;
            onlineRadioButton.Location = new Point(51, 24);
            onlineRadioButton.Name = "onlineRadioButton";
            onlineRadioButton.Size = new Size(74, 22);
            onlineRadioButton.TabIndex = 0;
            onlineRadioButton.TabStop = true;
            onlineRadioButton.Text = "Online";
            onlineRadioButton.UseVisualStyleBackColor = true;
            onlineRadioButton.CheckedChanged += onlineRadioButton_CheckedChanged;
            // 
            // weekTextBox
            // 
            weekTextBox.BorderStyle = BorderStyle.FixedSingle;
            weekTextBox.Location = new Point(12, 109);
            weekTextBox.Name = "weekTextBox";
            weekTextBox.Size = new Size(418, 27);
            weekTextBox.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 86);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 65;
            label4.Text = "Week:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(7, 609);
            backButton.Name = "backButton";
            backButton.Size = new Size(431, 43);
            backButton.TabIndex = 64;
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
            deleteButton.Location = new Point(231, 555);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(207, 43);
            deleteButton.TabIndex = 63;
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
            editButton.Location = new Point(231, 490);
            editButton.Name = "editButton";
            editButton.Size = new Size(207, 43);
            editButton.TabIndex = 62;
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
            newButton.Location = new Point(12, 555);
            newButton.Name = "newButton";
            newButton.Size = new Size(207, 43);
            newButton.TabIndex = 61;
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
            addButton.Location = new Point(12, 490);
            addButton.Name = "addButton";
            addButton.Size = new Size(207, 43);
            addButton.TabIndex = 60;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // topicNameTextBox
            // 
            topicNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            topicNameTextBox.Location = new Point(11, 54);
            topicNameTextBox.Name = "topicNameTextBox";
            topicNameTextBox.Size = new Size(418, 27);
            topicNameTextBox.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 29);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 55;
            label2.Text = "Topic Name:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(9, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 60);
            panel1.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(10, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(365, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Course Two - Syllabus:";
            // 
            // CourseTwoSyllabusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CourseTwoSyllabusForm";
            Text = "Recordance";
            Load += CourseTwoSyllabusForm_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox3;
        private RadioButton finishedRadioButton;
        private RadioButton ongoingRadioButton;
        private GroupBox groupBox2;
        private RadioButton asynchronousRadioButton;
        private RadioButton synchronousRadioButton;
        private GroupBox groupBox1;
        private RadioButton facetofaceRadioButton;
        private RadioButton onlineRadioButton;
        private TextBox weekTextBox;
        private Label label4;
        private Button backButton;
        private Button deleteButton;
        private Button editButton;
        private Button newButton;
        private Button addButton;
        private TextBox topicNameTextBox;
        private Label label2;
        private Panel panel1;
        private Label titleLabel;
    }
}