using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
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
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = course.students[i];
                Student.numOfStudents++;
            }
            teacher = course.teachers;
            course = degree.courses;
            degree = upro.degrees;



            //Assigning courses, degrees, and uprogram
            course.Courses = "Programming with C#";
            degree.Degrees = "Bachelor of Science";
            upro.UPrograms = "Information Technology";



            Console.WriteLine("The {0} program contains the {1} degree.", upro.UPrograms, degree.Degrees);
            Console.WriteLine("The {0} degree contains the course {1}.", degree.Degrees, course.Courses);
            Console.WriteLine("The {0} course contains {1} student(s).", course.Courses, Student.numOfStudents);

        }
    }
}
