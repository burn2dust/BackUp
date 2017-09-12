using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edx_Project
{
    class Course
    {
        private string name;
        private decimal credits;
        private int durationInWeeks;

        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        public Course(string name)
        {
            this.name = name;
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int DurationInWeeks
        {
            get
            {
                return durationInWeeks;
            }

            set
            {
                durationInWeeks = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public void ListStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        public void ListStudentsAndGrades()
        {
            foreach (Student student in students)
            {
                string outString = String.Format("{0} {1}", student.FirstName, student.LastName);
                foreach (decimal grade in student.Grades)
                {
                    outString += " " + grade.ToString();
                }
                Console.WriteLine(outString);
            }
        }
    }

    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _birthdate;
        protected string _addressLineOne;
        protected string _addressLineTwo;
        protected string _city;
        protected int _zip;
        protected string _country;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime Birthdate { get { return _birthdate; } set { _birthdate = value; } }
        public string AddressLineOne { get { return _addressLineOne; } set { _addressLineOne = value; } }
        public string AddressLineTwo { get { return _addressLineTwo; } set { _addressLineTwo = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int Zip { get { return _zip; } set { _zip = value; } }
        public string Country { get { return _country; } set { _country = value; } }
    }

    class Student : Person, IComparable
    {
        static private int studentCount = 0;
        static public int StudentCount { get { return studentCount; } }
        private Stack<double> grades = new Stack<double>();

        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            studentCount++;
        }
        public Stack<double> Grades
        {
            get
            {
                return grades;
            }
        }
        public void TakeText()
        {
            Console.WriteLine("Taking a test");
        }

        public int CompareTo(object obj)
        {
            Student studentObj = (Student)obj;
            int lastNameComparison = this.LastName.CompareTo(studentObj.LastName);
            if (lastNameComparison != 0)
            {
                return lastNameComparison;
            }

            return this.FirstName.CompareTo(studentObj.FirstName);

        }
    }

    class Teacher : Person
    {
        static private int teacherCount = 0;
        public Teacher()
        {
            teacherCount++;
        }
        public void GradeText()
        {
            Console.WriteLine("Grading a test.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe");
            Student student2 = new Student("Joe", "Blow");
            Student student3 = new Student("Tron", "Bonne");

            student1.Grades.Push(68.2);
            student1.Grades.Push(58.2);
            student1.Grades.Push(100d);
            student1.Grades.Push(88d);
            student1.Grades.Push(0d);

            student2.Grades.Push(92.1);
            student2.Grades.Push(94.8);
            student2.Grades.Push(93.2);
            student2.Grades.Push(93.2);
            student2.Grades.Push(92.6);

            student3.Grades.Push(83.2);
            student3.Grades.Push(99.2);
            student3.Grades.Push(85.2);
            student3.Grades.Push(88.2);
            student3.Grades.Push(102.0);

            Course course = new Course("Programming with C#");
            course.Students.Add(student1);
            course.Students.Add(student2);
            course.Students.Add(student3);
            course.ListStudents();
        }
    }
}