using System;

namespace StudentUnassigned
{
    class Program
    {
        //Dummy variables
        private static string studentFirstName = "XXXXX",
            studentLastName = "XXXXX",
            studentBirthday = "00/00/00",
            teacherFirstName = "YYYYY",
            teacherLastName = "YYYYY",
            course = "Dummy",
            uprogram = "VeryDummy",
            degree = "Master's Dummy";
        private static DateTime birthday;

        static void GetStudentInformation()
        {
            string tempBirthday;       
            Console.WriteLine("Enter the student's first name: ");
            studentFirstName = Console.ReadLine();
            
            Console.WriteLine("Enter the student's last name: ");
            studentLastName = Console.ReadLine();

            Console.WriteLine("Enter the student's birthday Year(xxxx): ");
            tempBirthday = Console.ReadLine();
            
            try
            {
                birthday = Convert.ToDateTime(tempBirthday);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date.");
            }
            catch (Exception)
            {
                Console.WriteLine("Getting the student's info has failed.");
            }
        }

        static void GetUniversityInformation()
        {
            Console.WriteLine("Enter the Teacher's first name: ");
            teacherFirstName = Console.ReadLine();

            Console.WriteLine("Enter the Teacher's last name: ");
            teacherLastName = Console.ReadLine();

            Console.WriteLine("Enter the course number(/letters): ");
            course = Console.ReadLine();

            Console.WriteLine("Enter the uprogram: ");
            uprogram = Console.ReadLine();

            Console.WriteLine("Enter the expected degree: ");
            degree = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void PrintDegreeDetails(string degree, string uprogram, string course)
        {
            Console.WriteLine("{0} requires: {1}", degree, uprogram);
            Console.WriteLine("{0} requires: {1}", uprogram, course);
        }

        static void PrintTeacherDetails(string first, string last, string course)
        {
            Console.WriteLine("{0} {1} teaches {2}", first, last, course);
        }

        static void GetValidateBirthday(DateTime bday)
        {
            int result = 0;
            DateTime validDate = new DateTime(1800, 1, 1);
            DateTime todayDate = DateTime.Today;
            result = DateTime.Compare(todayDate, validDate);

            if (result >= 0)
            {
                Console.WriteLine("You are too old for technology.");
            }
        }

        static void Main(string[] args)
        {
            DateTime validDate = new DateTime(1880, 1, 1);
            GetStudentInformation();
            //GetUniversityInformation();

            Console.WriteLine("\n\n");

            //PrintStudentDetails(studentFirstName,studentLastName,studentBirthday);
            //PrintTeacherDetails(teacherFirstName,teacherLastName,course);
            //PrintDegreeDetails(degree, uprogram, course);
            GetValidateBirthday(birthday);

            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
