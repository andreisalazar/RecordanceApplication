using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecordanceApp
{
    public static class PublicData
    {

        //File Path
        public static string folder = @"C:\Users\pochx\Desktop\Recordance Application\RecordanceApp\Databases";


        //Public variables
        public static string PublicUsername = "";
        public static string PublicFullname = "";

        //Variables for Course Names
        public static string PublicCourseNameOne = "";
        public static string PublicCourseNameTwo = "";
        public static string PublicCourseNameThree = "";

        //Variables for Course Codes
        public static string PublicCourseCodeOne = "";
        public static string PublicCourseCodeTwo = "";
        public static string PublicCourseCodeThree = "";

        //Variables for Sections
        public static string PublicCourseOneSectionOne = "";
        public static string PublicCourseOneSectionTwo = "";
        public static string PublicCourseTwoSectionOne = "";
        public static string PublicCourseTwoSectionTwo = "";
      

        //Textfile databases for account details
        public static string usernameDB =  Path.Combine(folder, "usernameDB.txt");
        public static string passwordDB = Path.Combine(folder, "passwordDB.txt");
        public static string fullnameDB = Path.Combine(folder, "fullnameDB.txt");

        //Textfile databases for course names details
        public static string courseNameOneDB = Path.Combine(folder, "courseNameOne.txt");
        public static string courseNameTwoDB = Path.Combine(folder, "courseNameTwo.txt");


        //Textfile databases for course codes details
        public static string courseCodeOneDB = Path.Combine(folder, "courseCodeOne.txt");
        public static string courseCodeTwoDB = Path.Combine(folder, "courseCodeTwo.txt");


        //Textfile databases for section details
        public static string courseOneSectionOneDB = Path.Combine(folder, "courseOneSectionOne.txt");
        public static string courseOneSectionTwoDB = Path.Combine(folder, "courseTwoSectionTwo.txt");

        public static string courseTwoSectionOneDB = Path.Combine(folder, "courseTwoSectionOne.txt");
        public static string courseTwoSectionTwoDB = Path.Combine(folder, "courseTwoSectionTwo.txt");

        //Lists
        public static string[] usernameList = File.ReadAllLines(usernameDB);
        public static string[] fullnameList = File.ReadAllLines(fullnameDB);
        public static string[] passwordList = File.ReadAllLines(passwordDB);

        public static string[] courseNameOneList = File.ReadAllLines(courseNameOneDB);
        public static string[] courseCodeOneList = File.ReadAllLines(courseCodeOneDB);
        public static string[] courseNameTwoList = File.ReadAllLines(courseNameTwoDB);
        public static string[] courseCodeTwoList = File.ReadAllLines(courseNameTwoDB);

        //Textfile Array
        public static string[] courseOneSectionOneTextFiles = File.ReadAllLines(courseTwoSectionOneDB);
        public static string[] courseOneSectionTwoTextFiles;

        public static string[] courseTwoSectionOneTextFiles;
        public static string[] courseTwoSectionTwoTextFiles;

        //Username Index
        public static int usernameIndex;
       
    }
}
