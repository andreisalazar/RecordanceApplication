using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordanceApp
{
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();

        }

        public static string[] usernameList = File.ReadAllLines(PublicData.usernameDB);
        public static string[] passwordList = File.ReadAllLines(PublicData.passwordDB);
        public static string[] fullnameList = File.ReadAllLines(PublicData.fullnameDB);

        private void NavigationForm_Load(object sender, EventArgs e)
        {
            Panel coursesContainerPanel = new Panel();
            coursesContainerPanel.Size = new Size(930, 589);
            coursesContainerPanel.Location = new Point(240, 152);
            coursesContainerPanel.BackColor = Color.WhiteSmoke;
            coursesContainerPanel.AutoScroll = true;
            Label titlelabel = new Label();
            titlelabel.Location = new Point(8, 7);

            Label coursesContainerlabel = new Label();
            coursesContainerlabel.Location = new Point(270, 170);
            coursesContainerlabel.Text = "Your courses: ";
            coursesContainerlabel.Font = new Font("Arial Black", 18, FontStyle.Bold);
            coursesContainerlabel.AutoSize = true;
            coursesContainerlabel.BackColor = Color.WhiteSmoke;


            Panel addCoursePanel = new Panel();
            addCoursePanel.Location = new Point(29, 130);
            addCoursePanel.Size = new Size(871, 135);
            Label addCourseLabel = new Label();
            addCourseLabel.Text = "Course name: ";
            addCourseLabel.Font = new Font("Georgia", 11, FontStyle.Regular);
            addCourseLabel.AutoSize = true;
            addCourseLabel.BackColor = Color.WhiteSmoke;
            TextBox addCourseTextBox = new TextBox();
            addCourseTextBox.Size = new Size(352, 27);
            addCourseTextBox.Location = new Point(27, 66);
            Button addCourseButton = new Button();
            addCourseButton.Size = new Size(162, 43);
            addCourseButton.Location = new Point(673, 43);
            addCourseButton.FlatStyle = FlatStyle.Flat;
            addCourseButton.BackColor = Color.Maroon;
            addCourseButton.ForeColor = Color.White;



            welcomeLabel.Text = "Welcome, " + PublicData.PublicFullname + "!";

            this.Controls.Add(titlelabel);
            this.Controls.Add(coursesContainerlabel);

            this.Controls.Add(addCourseLabel);
            this.Controls.Add(addCourseTextBox);
            this.Controls.Add(addCoursePanel);

            this.Controls.Add(coursesContainerPanel);

        }


    }
}
