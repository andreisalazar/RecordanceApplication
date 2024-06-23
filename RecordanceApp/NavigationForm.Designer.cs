namespace RecordanceApp
{
    partial class NavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationForm));
            panel2 = new Panel();
            welcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            viewSyllabusButtonTwo = new Button();
            viewSyllabusAndReqsButtonTwo = new Button();
            viewsectionbuttonTwo = new Button();
            label3 = new Label();
            coursecodeTwo = new TextBox();
            label4 = new Label();
            coursenameTwo = new TextBox();
            panel3 = new Panel();
            viewSyllabusButtonOne = new Button();
            viewSyllabusAndReqButtonOne = new Button();
            viewsectionbuttonOne = new Button();
            label2 = new Label();
            coursecodeOne = new TextBox();
            label7 = new Label();
            coursenameOne = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(welcomeLabel);
            panel2.Location = new Point(11, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 74);
            panel2.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(21, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(175, 40);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, ";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 624);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 84);
            label1.Name = "label1";
            label1.Size = new Size(241, 42);
            label1.TabIndex = 29;
            label1.Text = "Your courses:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(viewSyllabusButtonTwo);
            panel1.Controls.Add(viewSyllabusAndReqsButtonTwo);
            panel1.Controls.Add(viewsectionbuttonTwo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(coursecodeTwo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(coursenameTwo);
            panel1.Location = new Point(350, 445);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 280);
            panel1.TabIndex = 30;
            // 
            // viewSyllabusButtonTwo
            // 
            viewSyllabusButtonTwo.BackColor = Color.Maroon;
            viewSyllabusButtonTwo.FlatStyle = FlatStyle.Flat;
            viewSyllabusButtonTwo.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewSyllabusButtonTwo.ForeColor = SystemColors.ButtonHighlight;
            viewSyllabusButtonTwo.Location = new Point(573, 170);
            viewSyllabusButtonTwo.Name = "viewSyllabusButtonTwo";
            viewSyllabusButtonTwo.Size = new Size(185, 43);
            viewSyllabusButtonTwo.TabIndex = 35;
            viewSyllabusButtonTwo.Text = "View Syllabus";
            viewSyllabusButtonTwo.UseVisualStyleBackColor = false;
            viewSyllabusButtonTwo.Click += viewSyllabusButtonTwo_Click;
            // 
            // viewSyllabusAndReqsButtonTwo
            // 
            viewSyllabusAndReqsButtonTwo.BackColor = Color.Maroon;
            viewSyllabusAndReqsButtonTwo.FlatStyle = FlatStyle.Flat;
            viewSyllabusAndReqsButtonTwo.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewSyllabusAndReqsButtonTwo.ForeColor = SystemColors.ButtonHighlight;
            viewSyllabusAndReqsButtonTwo.Location = new Point(332, 170);
            viewSyllabusAndReqsButtonTwo.Name = "viewSyllabusAndReqsButtonTwo";
            viewSyllabusAndReqsButtonTwo.Size = new Size(226, 43);
            viewSyllabusAndReqsButtonTwo.TabIndex = 34;
            viewSyllabusAndReqsButtonTwo.Text = "View Requirements";
            viewSyllabusAndReqsButtonTwo.UseVisualStyleBackColor = false;
            viewSyllabusAndReqsButtonTwo.Click += viewSyllabusAndReqsButtonTwo_Click;
            // 
            // viewsectionbuttonTwo
            // 
            viewsectionbuttonTwo.BackColor = Color.Maroon;
            viewsectionbuttonTwo.FlatStyle = FlatStyle.Flat;
            viewsectionbuttonTwo.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewsectionbuttonTwo.ForeColor = SystemColors.ButtonHighlight;
            viewsectionbuttonTwo.Location = new Point(146, 170);
            viewsectionbuttonTwo.Name = "viewsectionbuttonTwo";
            viewsectionbuttonTwo.Size = new Size(174, 43);
            viewsectionbuttonTwo.TabIndex = 32;
            viewsectionbuttonTwo.Text = "View Sections";
            viewsectionbuttonTwo.UseVisualStyleBackColor = false;
            viewsectionbuttonTwo.Click += viewsectionbuttonTwo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 116);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 31;
            label3.Text = "Course Code:";
            // 
            // coursecodeTwo
            // 
            coursecodeTwo.BorderStyle = BorderStyle.FixedSingle;
            coursecodeTwo.Location = new Point(144, 113);
            coursecodeTwo.Name = "coursecodeTwo";
            coursecodeTwo.Size = new Size(614, 27);
            coursecodeTwo.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 66);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 29;
            label4.Text = "Course Name:";
            // 
            // coursenameTwo
            // 
            coursenameTwo.BorderStyle = BorderStyle.FixedSingle;
            coursenameTwo.Location = new Point(146, 63);
            coursenameTwo.Name = "coursenameTwo";
            coursenameTwo.Size = new Size(612, 27);
            coursenameTwo.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(viewSyllabusButtonOne);
            panel3.Controls.Add(viewSyllabusAndReqButtonOne);
            panel3.Controls.Add(viewsectionbuttonOne);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(coursecodeOne);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(coursenameOne);
            panel3.Location = new Point(350, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 280);
            panel3.TabIndex = 32;
            // 
            // viewSyllabusButtonOne
            // 
            viewSyllabusButtonOne.BackColor = Color.Maroon;
            viewSyllabusButtonOne.FlatStyle = FlatStyle.Flat;
            viewSyllabusButtonOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewSyllabusButtonOne.ForeColor = SystemColors.ButtonHighlight;
            viewSyllabusButtonOne.Location = new Point(585, 186);
            viewSyllabusButtonOne.Name = "viewSyllabusButtonOne";
            viewSyllabusButtonOne.Size = new Size(185, 43);
            viewSyllabusButtonOne.TabIndex = 34;
            viewSyllabusButtonOne.Text = "View Syllabus";
            viewSyllabusButtonOne.UseVisualStyleBackColor = false;
            viewSyllabusButtonOne.Click += viewSyllabusButtonOne_Click;
            // 
            // viewSyllabusAndReqButtonOne
            // 
            viewSyllabusAndReqButtonOne.BackColor = Color.Maroon;
            viewSyllabusAndReqButtonOne.FlatStyle = FlatStyle.Flat;
            viewSyllabusAndReqButtonOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewSyllabusAndReqButtonOne.ForeColor = SystemColors.ButtonHighlight;
            viewSyllabusAndReqButtonOne.Location = new Point(344, 186);
            viewSyllabusAndReqButtonOne.Name = "viewSyllabusAndReqButtonOne";
            viewSyllabusAndReqButtonOne.Size = new Size(226, 43);
            viewSyllabusAndReqButtonOne.TabIndex = 33;
            viewSyllabusAndReqButtonOne.Text = "View Requirements";
            viewSyllabusAndReqButtonOne.UseVisualStyleBackColor = false;
            viewSyllabusAndReqButtonOne.Click += viewSyllabusAndReqButtonOne_Click;
            // 
            // viewsectionbuttonOne
            // 
            viewsectionbuttonOne.BackColor = Color.Maroon;
            viewsectionbuttonOne.FlatStyle = FlatStyle.Flat;
            viewsectionbuttonOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewsectionbuttonOne.ForeColor = SystemColors.ButtonHighlight;
            viewsectionbuttonOne.Location = new Point(158, 186);
            viewsectionbuttonOne.Name = "viewsectionbuttonOne";
            viewsectionbuttonOne.Size = new Size(174, 43);
            viewsectionbuttonOne.TabIndex = 32;
            viewsectionbuttonOne.Text = "View Sections";
            viewsectionbuttonOne.UseVisualStyleBackColor = false;
            viewsectionbuttonOne.Click += viewsectionbuttonOne_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 138);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 31;
            label2.Text = "Course Code:";
            // 
            // coursecodeOne
            // 
            coursecodeOne.BorderStyle = BorderStyle.FixedSingle;
            coursecodeOne.Location = new Point(156, 135);
            coursecodeOne.Name = "coursecodeOne";
            coursecodeOne.Size = new Size(614, 27);
            coursecodeOne.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 88);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 29;
            label7.Text = "Course Name:";
            // 
            // coursenameOne
            // 
            coursenameOne.BorderStyle = BorderStyle.FixedSingle;
            coursenameOne.Location = new Point(158, 85);
            coursenameOne.Name = "coursenameOne";
            coursenameOne.Size = new Size(612, 27);
            coursenameOne.TabIndex = 28;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "NavigationForm";
            Text = "Recordance";
            Load += NavigationForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label welcomeLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button viewsectionbuttonTwo;
        private Label label3;
        private TextBox coursecodeTwo;
        private Label label4;
        private TextBox coursenameTwo;
        private Panel panel3;
        private Label label2;
        private TextBox coursecodeOne;
        private Label label7;
        private TextBox coursenameOne;
        private Button viewsectionbuttonOne;
        private Button viewSyllabusAndReqsButtonTwo;
        private Button viewSyllabusAndReqButtonOne;
        private Button viewSyllabusButtonTwo;
        private Button viewSyllabusButtonOne;
    }
}