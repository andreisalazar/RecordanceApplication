namespace RecordanceApp
{
    partial class GradeComputationCourseOneSectionTwo
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
            backButton = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            titleLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(15, 698);
            backButton.Name = "backButton";
            backButton.Size = new Size(88, 43);
            backButton.TabIndex = 46;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(15, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1158, 513);
            panel2.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 129);
            panel1.TabIndex = 44;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(22, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(666, 62);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Course One - Section Two:";
            // 
            // GradeComputationCourseOneSectionTwo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(backButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GradeComputationCourseOneSectionTwo";
            Text = "GradeComputationCourseOneSectionTwo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Panel panel2;
        private Panel panel1;
        private Label titleLabel;
    }
}