namespace RecordanceApp
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            panel1 = new Panel();
            backButton = new Button();
            changepasswordButton = new Button();
            confirmpasswordTextBox = new TextBox();
            label5 = new Label();
            newpasswordTextBox = new TextBox();
            label4 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(changepasswordButton);
            panel1.Controls.Add(confirmpasswordTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(newpasswordTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 434);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Maroon;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ButtonHighlight;
            backButton.Location = new Point(240, 351);
            backButton.Name = "backButton";
            backButton.Size = new Size(84, 43);
            backButton.TabIndex = 28;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // changepasswordButton
            // 
            changepasswordButton.BackColor = Color.Maroon;
            changepasswordButton.FlatStyle = FlatStyle.Flat;
            changepasswordButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            changepasswordButton.ForeColor = SystemColors.ButtonHighlight;
            changepasswordButton.Location = new Point(27, 351);
            changepasswordButton.Name = "changepasswordButton";
            changepasswordButton.Size = new Size(194, 43);
            changepasswordButton.TabIndex = 27;
            changepasswordButton.Text = "Change password";
            changepasswordButton.UseVisualStyleBackColor = false;
            changepasswordButton.Click += changepasswordButton_Click;
            // 
            // confirmpasswordTextBox
            // 
            confirmpasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmpasswordTextBox.Location = new Point(27, 274);
            confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            confirmpasswordTextBox.Size = new Size(294, 27);
            confirmpasswordTextBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 247);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 25;
            label5.Text = "Confirm password:";
            // 
            // newpasswordTextBox
            // 
            newpasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            newpasswordTextBox.Location = new Point(27, 209);
            newpasswordTextBox.Name = "newpasswordTextBox";
            newpasswordTextBox.Size = new Size(294, 27);
            newpasswordTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 187);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 23;
            label4.Text = "New password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(27, 152);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(294, 27);
            usernameTextBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 21;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 83);
            label2.Name = "label2";
            label2.Size = new Size(151, 18);
            label2.TabIndex = 20;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(271, 52);
            label1.TabIndex = 19;
            label1.Text = "RecordAnce";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(366, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 433);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 340);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgotPasswordForm";
            Text = "Recordance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button backButton;
        private Button changepasswordButton;
        private TextBox confirmpasswordTextBox;
        private Label label5;
        private TextBox newpasswordTextBox;
        private Label label4;
        private TextBox usernameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}