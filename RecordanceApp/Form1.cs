namespace RecordanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        SignInForm signinform = new SignInForm();
        PublicData data = new PublicData();
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signinform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(PublicData.folder, "usernameDB.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "passwordDB.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "fullnameDB.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseNameOne.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseNameTwo.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseCodeOne.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseCodeTwo.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionOneTXT.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionTwoTXT.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionOneTXT.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionTwoTXT.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionOneNames.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionTwoNames.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionOneNames.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionTwoNames.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionOneSchedOne.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseOneSectionTwoSchedTwo.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionOneSchedOne.txt"))
                && !File.Exists(Path.Combine(PublicData.folder, "courseTwoSectionTwoSchedTwo.txt")))
            {
                var fileStreamOne = File.Create(Path.Combine(PublicData.folder, "usernameDB.txt"));
                var fileStreamTwo = File.Create(Path.Combine(PublicData.folder, "passwordDB.txt"));
                var fileStreamThree = File.Create(Path.Combine(PublicData.folder, "fullnameDB.txt"));
                var fileStreamFour = File.Create(Path.Combine(PublicData.folder, "courseNameOne.txt"));
                var fileStreamFive = File.Create(Path.Combine(PublicData.folder, "courseNameTwo.txt"));
                var fileStreamSix = File.Create(Path.Combine(PublicData.folder, "courseCodeOne.txt"));
                var fileStreamSeven = File.Create(Path.Combine(PublicData.folder, "courseCodeTwo.txt"));
                var fileStreamEight = File.Create(Path.Combine(PublicData.folder, "courseOneSectionOneTXT.txt"));
                var fileStreamNine = File.Create(Path.Combine(PublicData.folder, "courseOneSectionTwoTXT.txt"));
                var fileStreamTen = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionOneTXT.txt"));
                var fileStreamEleven = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionTwoTXT.txt"));
                var fileStreamTwelve = File.Create(Path.Combine(PublicData.folder, "courseOneSectionOneNames.txt"));
                var fileStreamThirteen = File.Create(Path.Combine(PublicData.folder, "courseOneSectionTwoNames.txt"));
                var fileStreamFourteen = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionOneNames.txt"));
                var fileStreamFifteen = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionTwoNames.txt"));
                var fileStreamSixteen = File.Create(Path.Combine(PublicData.folder, "courseOneSectionOneSched.txt"));
                var fileStreamSeventeen = File.Create(Path.Combine(PublicData.folder, "courseOneSectionTwoSched.txt"));
                var fileStreamEighteen = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionOneSched.txt"));
                var fileStreamNineteen = File.Create(Path.Combine(PublicData.folder, "courseTwoSectionTwoSched.txt"));

                PublicData.usernameDB = fileStreamOne.Name;
                PublicData.passwordDB = fileStreamTwo.Name;
                PublicData.fullnameDB = fileStreamThree.Name;
                PublicData.courseNameOneDB = fileStreamFour.Name;
                PublicData.courseNameTwoDB = fileStreamFive.Name;
                PublicData.courseCodeOneDB = fileStreamSix.Name;
                PublicData.courseCodeTwoDB = fileStreamSeven.Name;
                PublicData.courseOneSectionOneDBTXT = fileStreamEight.Name;
                PublicData.courseOneSectionTwoDBTXT = fileStreamNine.Name;
                PublicData.courseTwoSectionOneDBTXT = fileStreamTen.Name;
                PublicData.courseTwoSectionTwoDBTXT = fileStreamEleven.Name;
                PublicData.courseOneSectionOneNamesDB = fileStreamTwelve.Name;
                PublicData.courseOneSectionTwoNamesDB = fileStreamThirteen.Name;
                PublicData.courseTwoSectionOneNamesDB = fileStreamFourteen.Name;
                PublicData.courseTwoSectionTwoNamesDB = fileStreamFifteen.Name;
                PublicData.courseOneSectionOneSchedDB = fileStreamSixteen.Name;
                PublicData.courseOneSectionTwoSchedDB = fileStreamSeventeen.Name;
                PublicData.courseTwoSectionOneSchedDB = fileStreamEighteen.Name;
                PublicData.courseTwoSectionTwoSchedDB = fileStreamNineteen.Name;

                fileStreamOne.Close();
                fileStreamTwo.Close();
                fileStreamThree.Close();
                fileStreamFour.Close();
                fileStreamFive.Close();
                fileStreamSix.Close();
                fileStreamSeven.Close();
                fileStreamEight.Close();
                fileStreamNine.Close();
                fileStreamTen.Close();
                fileStreamEleven.Close();
                fileStreamTwelve.Close();
                fileStreamThirteen.Close();
                fileStreamFourteen.Close();
                fileStreamFifteen.Close();
                fileStreamSixteen.Close();
                fileStreamSeventeen.Close();
                fileStreamEighteen.Close();
                fileStreamNineteen.Close();
                readData();

               
            }


            //Assign the textfiles to the public variables
            PublicData.usernameDB = Path.Combine(PublicData.folder, "usernameDB.txt");
            PublicData.passwordDB = Path.Combine(PublicData.folder, "passwordDB.txt");
            PublicData.fullnameDB = Path.Combine(PublicData.folder, "fullnameDB.txt");
            PublicData.courseNameOneDB = Path.Combine(PublicData.folder, "courseNameOne.txt");
            PublicData.courseNameTwoDB = Path.Combine(PublicData.folder, "courseNameTwo.txt");
            PublicData.courseCodeOneDB = Path.Combine(PublicData.folder, "courseCodeOne.txt");
            PublicData.courseCodeTwoDB = Path.Combine(PublicData.folder, "courseCodeTwo.txt");
            PublicData.courseOneSectionOneDBTXT = Path.Combine(PublicData.folder, "courseOneSectionOneTXT.txt");
            PublicData.courseOneSectionTwoDBTXT = Path.Combine(PublicData.folder, "courseOneSectionTwoTXT.txt");
            PublicData.courseTwoSectionOneDBTXT = Path.Combine(PublicData.folder, "courseTwoSectionOneTXT.txt");
            PublicData.courseTwoSectionTwoDBTXT = Path.Combine(PublicData.folder, "courseTwoSectionTwoTXT.txt");
            PublicData.courseOneSectionOneNamesDB = Path.Combine(PublicData.folder, "courseOneSectionOneNames.txt");
            PublicData.courseOneSectionTwoNamesDB = Path.Combine(PublicData.folder, "courseOneSectionTwoNames.txt");
            PublicData.courseTwoSectionOneNamesDB = Path.Combine(PublicData.folder, "courseTwoSectionOneNames.txt");
            PublicData.courseTwoSectionTwoNamesDB = Path.Combine(PublicData.folder, "courseTwoSectionTwoNames.txt");
            PublicData.courseOneSectionOneSchedDB = Path.Combine(PublicData.folder, "courseOneSectionOneSched.txt");
            PublicData.courseOneSectionTwoSchedDB = Path.Combine(PublicData.folder, "courseOneSectionTwoSched.txt");
            PublicData.courseTwoSectionOneSchedDB = Path.Combine(PublicData.folder, "courseTwoSectionOneSched.txt");
            PublicData.courseTwoSectionTwoSchedDB = Path.Combine(PublicData.folder, "courseTwoSectionTwoSched.txt");

            readData();

        }

        public void readData()
        {
            //Read the variables to get data
            PublicData.usernameList = File.ReadAllLines(PublicData.usernameDB);
            PublicData.fullnameList = File.ReadAllLines(PublicData.fullnameDB);
            PublicData.passwordList = File.ReadAllLines(PublicData.passwordDB);

            //Course Details Lists
            PublicData.courseNameOneList = File.ReadAllLines(PublicData.courseNameOneDB);
            PublicData.courseCodeOneList = File.ReadAllLines(PublicData.courseCodeOneDB);
            PublicData.courseNameTwoList = File.ReadAllLines(PublicData.courseNameTwoDB);
            PublicData.courseCodeTwoList = File.ReadAllLines(PublicData.courseCodeTwoDB);

            //Course Section Lists
            PublicData.courseOneSectionOneNameList = File.ReadAllLines(PublicData.courseOneSectionOneNamesDB);
            PublicData.courseOneSectionTwoNameList = File.ReadAllLines(PublicData.courseOneSectionTwoNamesDB);
            PublicData.courseTwoSectionOneNameList = File.ReadAllLines(PublicData.courseTwoSectionOneNamesDB);
            PublicData.courseTwoSectionTwoNameList = File.ReadAllLines(PublicData.courseTwoSectionTwoNamesDB);

            //Textfile Array Lists
            PublicData.courseOneSectionOneTextFiles = File.ReadAllLines(PublicData.courseOneSectionOneDBTXT);
            PublicData.courseOneSectionTwoTextFiles = File.ReadAllLines(PublicData.courseOneSectionTwoDBTXT);

            PublicData.courseTwoSectionOneTextFiles = File.ReadAllLines(PublicData.courseTwoSectionOneDBTXT);
            PublicData.courseTwoSectionTwoTextFiles = File.ReadAllLines(PublicData.courseTwoSectionTwoDBTXT);

            //Schedule of Sections Lists
            PublicData.courseOneSectionOneSchedOneList = File.ReadAllLines(PublicData.courseOneSectionOneSchedDB);
            PublicData.courseOneSectionTwoSchedTwoList = File.ReadAllLines(PublicData.courseOneSectionTwoSchedDB);
            PublicData.courseTwoSectionOneSchedOneList = File.ReadAllLines(PublicData.courseTwoSectionOneSchedDB);
            PublicData.courseTwoSectionTwoSchedTwoList = File.ReadAllLines(PublicData.courseTwoSectionTwoSchedDB);
        }
    }
}
