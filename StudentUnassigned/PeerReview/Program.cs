using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReview
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetUprogramInformation();
            GetDegreeInformation();

            ValidateStudentBirthday();

            Console.ReadLine();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's course");
            string course = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, course);
        }

        static void PrintTeacherDetails(string first, string last, string course)
        {
            Console.WriteLine("{0} {1} teaches: {2}", first, last, course);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of the course hours");
            string hours = Console.ReadLine();
            Console.WriteLine("Enter the course type");
            string type = Console.ReadLine();

            PrintCourseDetails(name, hours, type);

        }

        static void PrintCourseDetails(string name, string hours, string type)
        {
            Console.WriteLine("{0} ( {1} ) takes: {2} hours", name, type, hours);
        }

        static void GetUprogramInformation()
        {
            Console.WriteLine("Enter the uprogram name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a department of the uprogram");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the uprogram type");
            string type = Console.ReadLine();

            PrintUprogramDetails(name, department, type);
        }

        static void PrintUprogramDetails(string name, string department, string type)
        {
            Console.WriteLine("{0} ( {1} ) : {2}", name, department, type);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a department of the degree");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the degree type");
            string type = Console.ReadLine();

            PrintDegreeDetails(name, department, type);
        }

        static void PrintDegreeDetails(string name, string department, string type)
        {
            Console.WriteLine("{0} ( {1} ) : {2}", name, department, type);
        }

        static void ValidateStudentBirthday()
        {
            throw new NotImplementedException();
        }

    }
}
