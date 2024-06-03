namespace RecordanceApp
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            panel1 = new Panel();
            forgotpasswordButton = new Label();
            signupButton = new Label();
            label5 = new Label();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            label4 = new Label();
            usernameTextBox = new TextBox();
            label6 = new Label();
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
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(forgotpasswordButton);
            panel1.Controls.Add(signupButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signinButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 729);
            panel1.TabIndex = 0;
            // 
            // forgotpasswordButton
            // 
            forgotpasswordButton.AutoSize = true;
            forgotpasswordButton.Font = new Font("Georgia", 7.8F, FontStyle.Underline, GraphicsUnit.Point);
            forgotpasswordButton.Location = new Point(50, 447);
            forgotpasswordButton.Name = "forgotpasswordButton";
            forgotpasswordButton.Size = new Size(117, 16);
            forgotpasswordButton.TabIndex = 28;
            forgotpasswordButton.Text = "Forgot password?";
            forgotpasswordButton.Click += forgotpasswordButton_Click;
            // 
            // signupButton
            // 
            signupButton.AutoSize = true;
            signupButton.Font = new Font("Georgia", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            signupButton.Location = new Point(297, 538);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(74, 20);
            signupButton.TabIndex = 27;
            signupButton.Text = "Sign-up.";
            signupButton.Click += signupButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 538);
            label5.Name = "label5";
            label5.Size = new Size(253, 20);
            label5.TabIndex = 26;
            label5.Text = "Don't have an account yet? Click";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Maroon;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            signinButton.ForeColor = SystemColors.ButtonHighlight;
            signinButton.Location = new Point(47, 477);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(101, 43);
            signinButton.TabIndex = 25;
            signinButton.Text = "Sign-in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(50, 417);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(352, 27);
            passwordTextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 393);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 23;
            label4.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Location = new Point(49, 360);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(352, 27);
            usernameTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 339);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 21;
            label6.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 304);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 20;
            label3.Text = "Log in:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 227);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 19;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 171);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 18;
            label1.Text = "RecordAnce";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(471, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 730);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignInForm";
            Text = "SignInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label forgotpasswordButton;
        private Label signupButton;
        private Label label5;
        private Button signinButton;
        private TextBox passwordTextBox;
        private Label label4;
        private TextBox usernameTextBox;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}