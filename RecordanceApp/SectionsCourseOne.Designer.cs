namespace RecordanceApp
{
    partial class SectionsCourseOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionsCourseOne));
            panel1 = new Panel();
            titleLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            coursecodeOne = new TextBox();
            label7 = new Label();
            coursenameOne = new TextBox();
            viewStudentsButtonSectionOne = new Button();
            backButton = new Button();
            gradeComputationButtonSectionOne = new Button();
            gradeComputationButtonSectionTwo = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 129);
            panel1.TabIndex = 30;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(22, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(576, 62);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Course One - Sections:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(gradeComputationButtonSectionOne);
            panel2.Controls.Add(viewStudentsButtonSectionOne);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(coursecodeOne);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(coursenameOne);
            panel2.Location = new Point(12, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 208);
            panel2.TabIndex = 31;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(gradeComputationButtonSectionTwo);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(12, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 208);
            panel3.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(673, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 573);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 35;
            label2.Text = "Schedule:";
            // 
            // coursecodeOne
            // 
            coursecodeOne.BorderStyle = BorderStyle.FixedSingle;
            coursecodeOne.Location = new Point(155, 85);
            coursecodeOne.Name = "coursecodeOne";
            coursecodeOne.Size = new Size(455, 27);
            coursecodeOne.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 38);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 33;
            label7.Text = "Section Name:";
            // 
            // coursenameOne
            // 
            coursenameOne.BorderStyle = BorderStyle.FixedSingle;
            coursenameOne.Location = new Point(157, 35);
            coursenameOne.Name = "coursenameOne";
            coursenameOne.Size = new Size(453, 27);
            coursenameOne.TabIndex = 32;
            // 
            // viewStudentsButtonSectionOne
            // 
            viewStudentsButtonSectionOne.BackColor = Color.Maroon;
            viewStudentsButtonSectionOne.FlatStyle = FlatStyle.Flat;
            viewStudentsButtonSectionOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewStudentsButtonSectionOne.ForeColor = SystemColors.ButtonHighlight;
            viewStudentsButtonSectionOne.Location = new Point(157, 144);
            viewStudentsButtonSectionOne.Name = "viewStudentsButtonSectionOne";
            viewStudentsButtonSectionOne.Size = new Size(175, 43);
            viewStudentsButtonSectionOne.TabIndex = 36;
            viewStudentsButtonSectionOne.Text = "View Students";
            viewStudentsButtonSectionOne.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(12, 682);
            backButton.Name = "backButton";
            backButton.Size = new Size(88, 43);
            backButton.TabIndex = 37;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // gradeComputationButtonSectionOne
            // 
            gradeComputationButtonSectionOne.BackColor = Color.Maroon;
            gradeComputationButtonSectionOne.FlatStyle = FlatStyle.Flat;
            gradeComputationButtonSectionOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gradeComputationButtonSectionOne.ForeColor = SystemColors.ButtonHighlight;
            gradeComputationButtonSectionOne.Location = new Point(391, 144);
            gradeComputationButtonSectionOne.Name = "gradeComputationButtonSectionOne";
            gradeComputationButtonSectionOne.Size = new Size(219, 43);
            gradeComputationButtonSectionOne.TabIndex = 37;
            gradeComputationButtonSectionOne.Text = "Grade Computation";
            gradeComputationButtonSectionOne.UseVisualStyleBackColor = false;
            // 
            // gradeComputationButtonSectionTwo
            // 
            gradeComputationButtonSectionTwo.BackColor = Color.Maroon;
            gradeComputationButtonSectionTwo.FlatStyle = FlatStyle.Flat;
            gradeComputationButtonSectionTwo.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gradeComputationButtonSectionTwo.ForeColor = SystemColors.ButtonHighlight;
            gradeComputationButtonSectionTwo.Location = new Point(399, 137);
            gradeComputationButtonSectionTwo.Name = "gradeComputationButtonSectionTwo";
            gradeComputationButtonSectionTwo.Size = new Size(219, 43);
            gradeComputationButtonSectionTwo.TabIndex = 43;
            gradeComputationButtonSectionTwo.Text = "Grade Computation";
            gradeComputationButtonSectionTwo.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(165, 137);
            button4.Name = "button4";
            button4.Size = new Size(175, 43);
            button4.TabIndex = 42;
            button4.Text = "View Students";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 81);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 41;
            label1.Text = "Schedule:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(163, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 27);
            textBox1.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 31);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 39;
            label3.Text = "Section Name:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(165, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(453, 27);
            textBox2.TabIndex = 38;
            // 
            // SectionsCourseOne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SectionsCourseOne";
            Text = "SectionsCourseOne";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox coursecodeOne;
        private Label label7;
        private TextBox coursenameOne;
        private Button gradeComputationButtonSectionOne;
        private Button viewStudentsButtonSectionOne;
        private Button backButton;
        private Button gradeComputationButtonSectionTwo;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}