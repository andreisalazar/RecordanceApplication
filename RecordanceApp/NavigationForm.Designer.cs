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
            viewsectionbuttonTwo = new Button();
            label3 = new Label();
            coursecodeTwo = new TextBox();
            label4 = new Label();
            coursenameTwo = new TextBox();
            panel4 = new Panel();
            viewsectionbuttonThree = new Button();
            label5 = new Label();
            coursecodeThree = new TextBox();
            label6 = new Label();
            coursenameThree = new TextBox();
            panel3 = new Panel();
            viewsectionbuttonOne = new Button();
            label2 = new Label();
            coursecodeOne = new TextBox();
            label7 = new Label();
            coursenameOne = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(welcomeLabel);
            panel2.Location = new Point(11, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 132);
            panel2.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(3, 25);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(375, 85);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 570);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 155);
            label1.Name = "label1";
            label1.Size = new Size(241, 42);
            label1.TabIndex = 29;
            label1.Text = "Your courses:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(viewsectionbuttonTwo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(coursecodeTwo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(coursenameTwo);
            panel1.Location = new Point(345, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 134);
            panel1.TabIndex = 30;
            // 
            // viewsectionbuttonTwo
            // 
            viewsectionbuttonTwo.BackColor = Color.Maroon;
            viewsectionbuttonTwo.FlatStyle = FlatStyle.Flat;
            viewsectionbuttonTwo.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewsectionbuttonTwo.ForeColor = SystemColors.ButtonHighlight;
            viewsectionbuttonTwo.Location = new Point(593, 47);
            viewsectionbuttonTwo.Name = "viewsectionbuttonTwo";
            viewsectionbuttonTwo.Size = new Size(156, 43);
            viewsectionbuttonTwo.TabIndex = 32;
            viewsectionbuttonTwo.Text = "View Sections";
            viewsectionbuttonTwo.UseVisualStyleBackColor = false;
            viewsectionbuttonTwo.Click += viewsectionbuttonTwo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 82);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 31;
            label3.Text = "Course Code:";
            // 
            // coursecodeTwo
            // 
            coursecodeTwo.BorderStyle = BorderStyle.FixedSingle;
            coursecodeTwo.Location = new Point(146, 79);
            coursecodeTwo.Name = "coursecodeTwo";
            coursecodeTwo.Size = new Size(352, 27);
            coursecodeTwo.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 32);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 29;
            label4.Text = "Course Name:";
            // 
            // coursenameTwo
            // 
            coursenameTwo.BorderStyle = BorderStyle.FixedSingle;
            coursenameTwo.Location = new Point(148, 29);
            coursenameTwo.Name = "coursenameTwo";
            coursenameTwo.Size = new Size(352, 27);
            coursenameTwo.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(viewsectionbuttonThree);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(coursecodeThree);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(coursenameThree);
            panel4.Location = new Point(345, 562);
            panel4.Name = "panel4";
            panel4.Size = new Size(825, 134);
            panel4.TabIndex = 31;
            // 
            // viewsectionbuttonThree
            // 
            viewsectionbuttonThree.BackColor = Color.Maroon;
            viewsectionbuttonThree.FlatStyle = FlatStyle.Flat;
            viewsectionbuttonThree.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewsectionbuttonThree.ForeColor = SystemColors.ButtonHighlight;
            viewsectionbuttonThree.Location = new Point(593, 39);
            viewsectionbuttonThree.Name = "viewsectionbuttonThree";
            viewsectionbuttonThree.Size = new Size(156, 43);
            viewsectionbuttonThree.TabIndex = 37;
            viewsectionbuttonThree.Text = "View Sections";
            viewsectionbuttonThree.UseVisualStyleBackColor = false;
            viewsectionbuttonThree.Click += viewsectionbuttonThree_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 77);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 36;
            label5.Text = "Course Code:";
            // 
            // coursecodeThree
            // 
            coursecodeThree.BorderStyle = BorderStyle.FixedSingle;
            coursecodeThree.Location = new Point(146, 74);
            coursecodeThree.Name = "coursecodeThree";
            coursecodeThree.Size = new Size(352, 27);
            coursecodeThree.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 27);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 34;
            label6.Text = "Course Name:";
            // 
            // coursenameThree
            // 
            coursenameThree.BorderStyle = BorderStyle.FixedSingle;
            coursenameThree.Location = new Point(148, 24);
            coursenameThree.Name = "coursenameThree";
            coursenameThree.Size = new Size(352, 27);
            coursenameThree.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(viewsectionbuttonOne);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(coursecodeOne);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(coursenameOne);
            panel3.Location = new Point(345, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 134);
            panel3.TabIndex = 32;
            // 
            // viewsectionbuttonOne
            // 
            viewsectionbuttonOne.BackColor = Color.Maroon;
            viewsectionbuttonOne.FlatStyle = FlatStyle.Flat;
            viewsectionbuttonOne.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            viewsectionbuttonOne.ForeColor = SystemColors.ButtonHighlight;
            viewsectionbuttonOne.Location = new Point(593, 51);
            viewsectionbuttonOne.Name = "viewsectionbuttonOne";
            viewsectionbuttonOne.Size = new Size(156, 43);
            viewsectionbuttonOne.TabIndex = 32;
            viewsectionbuttonOne.Text = "View Sections";
            viewsectionbuttonOne.UseVisualStyleBackColor = false;
            viewsectionbuttonOne.Click += viewsectionbuttonOne_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 82);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 31;
            label2.Text = "Course Code:";
            // 
            // coursecodeOne
            // 
            coursecodeOne.BorderStyle = BorderStyle.FixedSingle;
            coursecodeOne.Location = new Point(146, 79);
            coursecodeOne.Name = "coursecodeOne";
            coursecodeOne.Size = new Size(352, 27);
            coursecodeOne.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 32);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 29;
            label7.Text = "Course Name:";
            // 
            // coursenameOne
            // 
            coursenameOne.BorderStyle = BorderStyle.FixedSingle;
            coursenameOne.Location = new Point(148, 29);
            coursenameOne.Name = "coursenameOne";
            coursenameOne.Size = new Size(352, 27);
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
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "NavigationForm";
            Text = "Navigation Form";
            Load += NavigationForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel4;
        private Button button3;
        private Button viewsectionbuttonTwo;
        private Label label3;
        private TextBox coursecodeTwo;
        private Label label4;
        private TextBox coursenameTwo;
        private Button viewsectionbuttonThree;
        private Label label5;
        private TextBox coursecodeThree;
        private Label label6;
        private TextBox coursenameThree;
        private Panel panel3;
        private Label label2;
        private TextBox coursecodeOne;
        private Label label7;
        private TextBox coursenameOne;
        private Button viewsectionbuttonOne;
    }
}