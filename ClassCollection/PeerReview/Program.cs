using System;
using System.Collections;

namespace PeerReview
{
    class Course
    {
        private string _CourseName;
        private string _Credits;
        private string _DurationInWeeks;

        // Grading Criteria:
        // "1. Used an ArrayList of Students, inside the Course object."
        private ArrayList _Students = new ArrayList();

        private Teacher[] _Teachers = new Teacher[3];

        public string CourseName
        {
            get
            {
                return _CourseName;
            }

            set
            {
                _CourseName = value;
            }
        }

        public string Credits
        {
            get
            {
                return _Credits;
            }

            set
            {
                _Credits = value;
            }
        }

        public string DurationInWeeks
        {
            get
            {
                return _DurationInWeeks;
            }

            set
            {
                _DurationInWeeks = value;
            }
        }

        // Grading Criteria:
        // "1. Used an ArrayList of Students, inside the Course object."
        public ArrayList Students
        {
            get
            {
                return _Students;
            }

            set
            {
                _Students = value;
            }
        }

        internal Teacher[] Teachers
        {
            get
            {
                return _Teachers;
            }

            set
            {
                _Teachers = value;
            }
        }

        public void ListStudents()
        {
            // Grading Criteria:
            // "4. Used a foreach loop to output the first and last name of each Student in the ArrayList."
            foreach (object objectStudent in Students)
            {
                // Grading Criteria:
                // "5. Cast the object from the ArrayList to Student, inside the foreach loop, before printing out the name information."
                // For the above reason i've not used the implicit casting in the foreach.
                Student student = (Student)objectStudent;
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

//////////////////

// Degree.cs

namespace PeerReview
{
    class Degree
    {
        private string _DegreeName;
        private string _CreditsRequired;
        private Course _Course;

        public string DegreeName
        {
            get
            {
                return _DegreeName;
            }

            set
            {
                _DegreeName = value;
            }
        }

        public string CreditsRequired
        {
            get
            {
                return _CreditsRequired;
            }

            set
            {
                _CreditsRequired = value;
            }
        }

        internal Course Course
        {
            get
            {
                return _Course;
            }

            set
            {
                _Course = value;
            }
        }
    }
}

////////////////////////////

// Person.cs

namespace PeerReview
{
    abstract class Person
    {
        private string _FirstName;
        private string _LastName;
        private string _BirthDate;
        private string _AddressLine1;
        private string _AddressLine2;
        private string _City;
        private string _StateProvince;
        private string _ZipPostal;
        private string _Country;

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return _BirthDate;
            }

            set
            {
                _BirthDate = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return _AddressLine1;
            }

            set
            {
                _AddressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return _AddressLine2;
            }

            set
            {
                _AddressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string StateProvince
        {
            get
            {
                return _StateProvince;
            }

            set
            {
                _StateProvince = value;
            }
        }

        public string ZipPostal
        {
            get
            {
                return _ZipPostal;
            }

            set
            {
                _ZipPostal = value;
            }
        }

        public string Country
        {
            get
            {
                return _Country;
            }

            set
            {
                _Country = value;
            }
        }
    }
}

////////////////////////

// Program.cs

namespace PeerReview
{
    class ProgramAssignment
    {
        static void Main(string[] args)
        {

            // Instantiate a Course object called Programming with C#.
            Course course = new Course();
            course.CourseName = "Programming with C#";

            // Create 3 student objects.
            Student[] students = new Student[3];
            for (int i = 1; i < 4; i++)
            {
                Student student = new Student();
                students[i - 1] = student;
                student.FirstName = "First name of student " + i;
                student.LastName = "Last name of student " + i;
            }

            // Add 5 grades to the the Stack in the each Student object. (this does not have to be inside the constructor because you may not have grades for a student when you create a new student.)
            for (int ciclStudent = 0; ciclStudent < 3; ciclStudent++)
            {
                for (int ciclGrade = 1; ciclGrade < 6; ciclGrade++)
                {
                    students[ciclStudent].Grades.Push("Grade " + ciclGrade);
                }
            }

            // Grading Criteria:
            // "3. Added 3 Student objects to this ArrayList using the ArrayList method for adding objects."
            for (int i = 0; i < 3; i++)
            {
                course.Students.Add(students[i]);
            }

            // Call the ListStudents() method from Main().
            course.ListStudents();
        }

    }
}

/////////////////////

// Student.cs

using System;
using System.Collections;

namespace PeerReview
{

    class Student : Person
    {
        private static int studentsCreated = 0;

        // Grading Criteria:
        // "2. Added a Stack called Grades inside the Student object."
        private Stack _Grades = new Stack();

        public Student()
        {
            studentsCreated++;
        }

        // Grading Criteria:
        // "2. Added a Stack called Grades inside the Student object."
        public Stack Grades
        {
            get
            {
                return _Grades;
            }

            set
            {
                _Grades = value;
            }
        }

        public static int StudentsCreated()
        {
            return studentsCreated;
        }

        public void TakeTest()
        {
            Console.WriteLine("Method TakeTest of Class Student called");
        }

    }
}

/////////////////////

// Teacher.cs

using System;

namespace PeerReview
{
    class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Method GradeTest of Class Teacher called");
        }
    }
}

//////////////////////

// UProgram.cs

namespace PeerReview
{
    class UProgram
    {

        private string _ProgramName;
        private string _DepartmentHead;
        private Degree _Degree;

        public string ProgramName
        {
            get
            {
                return _ProgramName;
            }

            set
            {
                _ProgramName = value;
            }
        }

        public string DepartmentHead
        {
            get
            {
                return _DepartmentHead;
            }

            set
            {
                _DepartmentHead = value;
            }
        }

        public Degree Degree
        {
            get
            {
                return _Degree;
            }

            set
            {
                _Degree = value;
            }
        }
    }
}