using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecordanceApp
{
    public class PublicData
    {

        //File Path  
        //public static string folder = @"C:\Users\pochx\Desktop\Recordance Application\RecordanceApp\Databases";
       public static string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RecordanceApp");
        static PublicData()
        {
            Directory.CreateDirectory(folder);
        }
       
        

        //Public variables
        public static string PublicUsername = "";
        public static string PublicFullname = "";

        //Variables for Course Names
        public static string PublicCourseNameOne = "";
        public static string PublicCourseNameTwo = "";

        //Variables for Course Codes
        public static string PublicCourseCodeOne = "";
        public static string PublicCourseCodeTwo = "";

        //Variables for Sections
        public static string PublicCourseOneSectionOne = "";
        public static string PublicCourseOneSectionTwo = "";
        public static string PublicCourseTwoSectionOne = "";
        public static string PublicCourseTwoSectionTwo = "";

        //Variables for Schedules
        public static string PublicCourseOneSectionOneSched = "";
        public static string PublicCourseOneSectionTwoSched = "";
        public static string PublicCourseTwoSectionOneSchedOne = "";
        public static string PublicCourseTwoSectionTwoSchedTwo = "";


        //Textfile databases for account details
        public static string usernameDB;
        public static string passwordDB;
        public static string fullnameDB;

        //Textfile databases for course names details
        public static string courseNameOneDB;
        public static string courseNameTwoDB;


        //Textfile databases for course codes details
        public static string courseCodeOneDB;
        public static string courseCodeTwoDB;


        //Textfile databases for section details (for textfile purposes)
        public static string courseOneSectionOneDBTXT;
        public static string courseOneSectionTwoDBTXT;

        public static string courseTwoSectionOneDBTXT;
        public static string courseTwoSectionTwoDBTXT;

        //Textfile databases for section details (for display purposes)
        public static string courseOneSectionOneNamesDB;
        public static string courseOneSectionTwoNamesDB;

        public static string courseTwoSectionOneNamesDB;
        public static string courseTwoSectionTwoNamesDB;

        //Textfile databases for section schedule details (for display purposes)
        public static string courseOneSectionOneSchedDB;
        public static string courseOneSectionTwoSchedDB;

        public static string courseTwoSectionOneSchedDB;
        public static string courseTwoSectionTwoSchedDB;

        //Lists
        //Account information lists
        public static string[] usernameList;
        public static string[] fullnameList;
        public static string[] passwordList;

        //Course Details Lists
        public static string[] courseNameOneList;
        public static string[] courseCodeOneList;
        public static string[] courseNameTwoList;
        public static string[] courseCodeTwoList;

        //Course Section Lists
        public static string[] courseOneSectionOneNameList;
        public static string[] courseOneSectionTwoNameList;
        public static string[] courseTwoSectionOneNameList;
        public static string[] courseTwoSectionTwoNameList;

        //Textfile Array Lists
        public static string[] courseOneSectionOneTextFiles;
        public static string[] courseOneSectionTwoTextFiles;

        public static string[] courseTwoSectionOneTextFiles;
        public static string[] courseTwoSectionTwoTextFiles;

        //Schedule of Sections Lists
        public static string[] courseOneSectionOneSchedOneList;
        public static string[] courseOneSectionTwoSchedTwoList;
        public static string[] courseTwoSectionOneSchedOneList;
        public static string[] courseTwoSectionTwoSchedTwoList;

        

        //Username Index
        public static int usernameIndex;


        //Database for Student Name List based on Username Index
        public static string studentNamesListCourseOneSectionOneDB = "";
        public static string studentNamesListCourseOneSectionTwoDB = "";

        public static string studentNamesListCourseTwoSectionOneDB = "";
        public static string studentNamesListCourseTwoSectionTwoDB = "";

        //Database for Student Number List based on Username Index
        public static string studentNumberListCourseOneSectionOneDB = "";
        public static string studentNumberListCourseOneSectionTwoDB = "";
        public static string studentNumberListCourseTwoSectionOneDB = "";
        public static string studentNumberListCourseTwoSectionTwoDB = "";

        //Database for Requirements Names based on Username Index
        public static string courseOneRequirementNameDB = "";
        public static string courseTwoRequirementNameDB = "";

        //Database for Requirement Status based on Username Index
        public static string courseOneReqStatusDB = "";
        public static string courseTwoReqStatusDB = "";

        //Database for Requirement Type based on Username Index
        public static string courseOneReqTypeDB = "";
        public static string courseTwoReqTypeDB = "";

        //Database for Syllabus Topic Names 
        public static string courseOneSyllabusNames = "";
        public static string courseTwoSyllabusNames = "";

        //Database for Syllabus Week, Mode of Learning, Class Type and Status
        public static string courseOneSyllabusDetails = "";
        public static string courseTwoSyllabusDetails = "";

        //Database for Quizzes
        //Course One Section One
        public static string quizOneCourseOneSectionOne = "";
        public static string quizTwoCourseOneSectionOne = "";
        public static string quizThreeCourseOneSectionOne = "";
        public static string quizAverageCourseOneSectionOne = "";

        //Course One Section Two
        public static string quizOneCourseOneSectionTwo = "";
        public static string quizTwoCourseOneSectionTwo = "";
        public static string quizThreeCourseOneSectionTwo = "";
        public static string quizAverageCourseOneSectionTwo = "";

        //Course Two Section One
        public static string quizOneCourseTwoSectionOne = "";
        public static string quizTwoCourseTwoSectionOne = "";
        public static string quizThreeCourseTwoSectionOne = "";
        public static string quizAverageCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string quizOneCourseTwoSectionTwo = "";
        public static string quizTwoCourseTwoSectionTwo = "";
        public static string quizThreeCourseTwoSectionTwo = "";
        public static string quizAverageCourseTwoSectionTwo = "";

        //Database for Activites
        //Course One Section One
        public static string activityOneCourseOneSectionOne = "";
        public static string activityTwoCourseOneSectionOne = "";
        public static string activityThreeCourseOneSectionOne = "";
        public static string actAverageCourseOneSectionOne = "";

        //Course One Section Two
        public static string activityOneCourseOneSectionTwo = "";
        public static string activityTwoCourseOneSectionTwo = "";
        public static string activityThreeCourseOneSectionTwo = "";
        public static string activityAverageCourseOneSectionTwo = "";

        //Course Two Section One 
        public static string activityOneCourseTwoSectionOne = "";
        public static string activityTwoCourseTwoSectionOne = "";
        public static string activityThreeCourseTwoSectionOne = "";
        public static string activityAverageCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string activityOneCourseTwoSectionTwo = "";
        public static string activityTwoCourseTwoSectionTwo = "";
        public static string activityThreeCourseTwoSectionTwo = "";
        public static string activityAverageCourseTwoSectionTwo = "";


        //Database for Exams
        //Course One Section One
        public static string midtermExamCourseOneSectionOne = "";
        public static string finalExamCourseOneSectionOne = "";
        public static string examAverageCourseOneSectionOne = "";

        //Course One Section Two
        public static string midtermExamCourseOneSectionTwo = "";
        public static string finalExamCourseOneSectionTwo = "";
        public static string examAverageCourseOneSectionTwo = "";

        //Course Two Section One
        public static string midtermExamCourseTwoSectionOne = "";
        public static string finalExamCourseTwoSectionOne = "";
        public static string examAverageCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string midtermExamCourseTwoSectionTwo = "";
        public static string finalExamCourseTwoSectionTwo = "";
        public static string examAverageCourseTwoSectionTwo = "";

        //Database for Attendance
        //Course One Section One
        public static string presentCourseOneSectionOne = "";
        public static string absentCourseOneSectionOne = "";

        //Course One Section Two
        public static string presentCourseOneSectionTwo = "";
        public static string absentCourseOneSectionTwo = "";

        //Course Two Section One
        public static string presentCourseTwoSectionOne = "";
        public static string absentCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string presentCourseTwoSectionTwo = "";
        public static string absentCourseTwoSectionTwo = "";


        //Database for Final Grade
        //Course One Section One
        public static string finalGradeCourseOneSectionOne = "";

        //Course One Section Two
        public static string finalGradeCourseOneSectionTwo = "";

        //Course Two Section One
        public static string finalGradeCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string finalGradeCourseTwoSectionTwo = "";

        //Database for Final Grade (Letter)
        //Course One Section One
        public static string finalGradeInLetterCourseOneSectionOne = "";

        //Course One Section Two
        public static string finalGradeInLetterCourseOneSectionTwo = "";

        //Course Two Section One
        public static string finalGradeInLetterCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string finalGradeInLetterCourseTwoSectionTwo = "";

        //Database for Final Grade (Pass or Fail)
        //Course One Section One
        public static string finalGradeInStatusCourseOneSectionOne = "";

        //Course One Section Two
        public static string finalGradeInStatusCourseOneSectionTwo = "";

        //Course Two Section One
        public static string finalGradeInStatusCourseTwoSectionOne = "";

        //Course Two Section One
        public static string finalGradeInStatusCourseTwoSectionTwo = "";

        //Database for Comments
        //Course One Section One
        public static string commentsCourseOneSectionOne = "";

        //Course One Section Two
        public static string commentsCourseOneSectionTwo = "";

        //Course Two Section One
        public static string commentsCourseTwoSectionOne = "";

        //Course Two Section Two
        public static string commentsCourseTwoSectionTwo = "";
    }
}
