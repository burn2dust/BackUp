using System;

namespace StudentClasses
{
    class UProgram
    {
        private string uPrograms;
        
        public Degree degrees = new Degree();

        public string UPrograms
        {
            get { return uPrograms; }
            set { uPrograms = value; }
        }
    }

    class Degree
    {
        private string degrees;

        public Course courses = new Course();

        public string Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }
    }

    class Course
    {
        private string courses;

        public Teacher[] teachers = new Teacher[3];
        public Student[] students = new Student[3];

        public string Courses
        {
            get { return courses; }
            set { courses = value; }
        }
    }

    class Teacher
    {
        private string addr1, addr2, city, country, firstName, lastName, state, zip;

        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }

    class Student
    {
        private string addr1, addr2, city, country, firstName, lastName, state, zip;
        public static int numOfStudents = 0;

        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation
            Course course = new Course();
            Degree degree = new Degree();
            Student[] student = new Student[3];
            Teacher[] teacher = new Teacher[3];
            UProgram upro = new UProgram();

            //Assigning new students & teachers
            for ( int i = 0; i < student.Length; i++ )
            {
                student[i] = course.students[i];
                Student.numOfStudents++;
            }
            course.teachers[0] = teacher[0];
            course = degree.courses;
            degree =  upro.degrees;

            //Assigning courses, degrees, and uprogram
            course.Courses = "Programming with C#";
            degree.Degrees = "Bachelor of Science";
            upro.UPrograms = "Information Technology";

            Console.WriteLine("The {0} program contains the {1} degree.",upro.UPrograms,degree.Degrees);
            Console.WriteLine("The {0} degree contains the course {1}.",degree.Degrees,course.Courses);
            Console.WriteLine("The {0} course contains {1} student(s).",course.Courses,Student.numOfStudents);

        }
    }
}
