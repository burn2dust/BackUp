using System;

namespace PeerReview
{
    public class Student
    {
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private string email;

        private static int studentsCount = 0;

        //Constructor
        public Student(string fname, string lname, DateTime birthdate, string mail)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.birthdate = birthdate;
            this.email = mail;

            studentsCount++;
        }

        //Properties

        public string Firstname
        {
            get { return this.firstname; }
            set { if (value != null) { this.firstname = value; } }
        }
        public string Lastname
        {
            get { return this.lastname; }
            set { if (value != null) { this.lastname = value; } }
        }
        public DateTime Birthdate
        {
            get { return this.birthdate; }
            set { if (value != null) { this.birthdate = value; } }
        }
        public string Email
        {
            get { return this.email; }
            set { if (value != null) { this.email = value; } }
        }
    }

    public class Teacher
    {
        private string Firstname;
        private string Lastname;
        private DateTime Birthdate;
        private string Email;

        public Teacher(string fname, string lname, DateTime birthdate, string mail)
        {
            this.Firstname = fname;
            this.Lastname = lname;
            this.Birthdate = birthdate;
            this.Email = email;
        }

        public string firstname
        {
            get { return this.Firstname; }
            set { if (value != null) { this.Firstname = value; } }
        }
        public string lastname
        {
            get { return this.Lastname; }
            set { if (value != null) { this.Lastname = value; } }
        }
        public DateTime birthdate
        {
            get { return this.Birthdate; }
            set { if (value != null) { this.Birthdate = value; } }
        }
        public string email
        {
            get { return this.Email; }
            set { if (value != null) { this.Email = value; } }
        }

    }

    public class Uprogram
    {
        private string ProgramName;
        private string DepartmentHead;
        private Degree degree;

        public Uprogram(string pname, string departmenthead, string degree)
        {
            this.ProgramName = pname;
            this.DepartmentHead = departmentHead;
            this.degree = Degree;
        }

        public string programName
        {
            get { return this.ProgramName; }
            set
            {
                if (value != null)
                {
                    this.ProgramName = value;
                }
            }
        }

        public string departmentHead
        {
            get { return this.DepartmentHead; }
            set
            {
                if (value != null)
                {
                    this.DepartmentHead = value;
                }
            }
        }

        public Degree Degree
        {
            get { return this.degree; }
            set { if (value != null) { this.degree = value; } }
        }

    }

    public class Degree
    {

        private string degreeName;
        private int totalCredits;
        private Course course;

        public Degree(string dname, int tcredits, string course)
        {
            this.degreeName = dname;
            this.totalCredits = tcredits;
            this.course = Course;
        }

        public string DegreeName
        {
            get { return this.degreeName; }
            set
            {
                if (value != null)
                {
                    this.degreeName = value;
                }
            }
        }
        public int TotalCredits
        {
            get { return this.totalCredits; }
            set
            {
                if (value != null)
                {
                    this.totalCredits = value;
                }
            }
        }
        public Course Course
        {
            get { return this.course; }
            set { if (value != null) { this.course = value; } }
        }

    }

    public class Course
    {
        private static int maxarraysize = 3;

        private string courseName;
        private int courseCredits;
        private Student[] students;
        private int studentnumber;
        private Teacher[] teachers;
        private int teachernumber;

        public Course(string cname, int credits)
        {
            this.courseName = cname;
            this.courseCredits = credits;
            this.students = new Student[maxarraysize];
            this.studentnumber = 0;
            this.teachers = new Teacher[maxarraysize];
            this.teachernumber = 0;
        }

        public string CourseName
        {
            get { return this.courseName; }
            set
            {
                if (value != null)
                {
                    this.courseName = value;
                }
            }
        }
        public int CourseCredits
        {
            get { return this.courseCredits; }
            set
            {
                if (value != null)
                {
                    this.courseCredits = value;
                }
            }
        }
        public int StudentNumber
        {
            get { return this.studentnumber; }
        }
        public int TeacherNumber
        {
            get { return this.teachernumber; }
        }

        public void addstudent(Student student)
        {
            int n = this.studentnumber;
            if (n < maxarraysize)
            {
                this.students[n] = student;
                this.studentnumber++;
            }
            else
            {
                Console.WriteLine("array of students is full");
            }
        }
        public void addteacher(Teacher teacher)
        {
            int n = this.teachernumber;
            if (n < maxarraysize)
            {
                this.teachers[n] = teacher;
                this.studentnumber++;
            }
            else
            {
                Console.WriteLine("Array of teachers is full");
            }
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Ali", "Mehmood", new DateTime(1995, 02, 21), "ali_hus21@hotmail.Com");
            Student student2 = new Student("Husnain", "Mehmood", new DateTime(1998, 12, 21), "Hus@yahoo.com");
            Student student3 = new Student("Zahid", "Ishaq", new DateTime(1990, 04, 12), " zahid@gmail.com");

            Course course = new Course("Programming with C#", 15);

            course.addstudent(student1);
            course.addstudent(student2);
            course.addstudent(student3);

            Teacher teacher = new Teacher("Awais", "Ahmed", new DateTime(1985, 05, 14), "awais@uet.edu.pk");
            course.addteacher(teacher);
            Degree degree = new Degree("Bachelors of science", 255, null);
            degree.Course = course;
            Uprogram uprogram = new Uprogram("Information Technology", "Dr Maud", null);
            uprogram.Degree = degree;

            Console.WriteLine("The {0} Program contain the {1} Degree", uprogram.programName, degree.DegreeName);
            Console.WriteLine("The {0} Degree contains the {1} course", degree.DegreeName, course.CourseName);
            Console.WriteLine("The {0} course contains {1} Student<s>", course.CourseName, course.StudentNumber);

        }
    }
}
