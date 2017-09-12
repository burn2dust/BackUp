using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReview
{
    public struct Student
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Zip { set; get; }
        public string Country { set; get; }
        public DateTime Birthdate { set; get; }

        public Student(string firstName, string lastName, string addressLine1, string addressLine2, string city, string state, string zip, string country, DateTime birthdate) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.Birthdate = birthdate;
        }
    }

    public struct Teacher
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Zip { set; get; }
        public string Country { set; get; }
        public DateTime Birthdate { set; get; }

        public Teacher(string firstName, string lastName, string addressLine1, string addressLine2, string city, string state, string zip, string country, DateTime birthdate) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
            this.Birthdate = birthdate;
        }
    }

    //UProgram information
    public struct UProgram
    {

        public string ProgramName { set; get; }
        public string DepartmentHead { set; get; }//this will be a teacher class eventually
        public string Degrees { set; get; }//string now but with classes this is an array degree class

        public UProgram(string programName, string departmentHead, string degrees) : this()
        {
            this.ProgramName = programName;
            this.DepartmentHead = departmentHead;
            this.Degrees = degrees;
        }
    }

    //Course Information
    public struct Course
    {

        public string CourseName { set; get; }
        public string Teacher { set; get; }
        public int Credits { set; get; }
        public int DurationInWeeks { set; get; }

        public Course(string courseName, string teacher, int credits, int durationInWeeks) : this()
        {
            this.CourseName = courseName;
            this.Teacher = teacher;
            this.Credits = credits;
            this.DurationInWeeks = durationInWeeks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student("John", "Doe", "733 Bourbon Street", "Apt 1", "New Orleans", "LA", "70116", "USA", Convert.ToDateTime("12/25/1969"));
            students[1] = new Student("Marie", "Laveau", "739 Bourbon Street", "Apt 6", "New Orleans", "LA", "70116", "USA", Convert.ToDateTime("12/31/1979"));
            students[2] = new Student("Pat", "O'Brien", "718 Peter Street", "Apt 11", "New Orleans", "LA", "70116", "USA", Convert.ToDateTime("11/25/1986"));
            students[3] = new Student("Hermann", "Grima", "820 Saint Louis Street", "Apt 27", "New Orleans", "LA", "70116", "USA", Convert.ToDateTime("10/16/1969"));
            students[4] = new Student("Jean", "Lafitte", "419 Decatur Street", "Apt 1", "New Orleans", "LA", "70130", "USA", Convert.ToDateTime("12/25/1769"));

            for (int i = 0; i < students.Length; i++)
            {
                string result = string.Format("StudentInfo:\n Name:\t\t{0} {1}\n Address:\t{2} {3}\n \t\t{4}, {5} {6} {7}\n Birthdate:\t{8}\n\n",
                students[i].FirstName, students[i].LastName, students[i].AddressLine1, students[i].AddressLine2, students[i].City, students[i].State,
                students[i].Zip, students[i].Country, students[i].Birthdate.ToShortDateString());
                Console.WriteLine(result);
            }

        }
    }
}
