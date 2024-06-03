namespace RecordanceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            startButton = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(124, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 509);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 275);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Maroon;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = SystemColors.ButtonHighlight;
            startButton.Location = new Point(376, 392);
            startButton.Name = "startButton";
            startButton.Size = new Size(207, 55);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(389, 368);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 1;
            label2.Text = "Class Monitoring App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 313);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 0;
            label1.Text = "RecordAnce";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Recordance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button startButton;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}