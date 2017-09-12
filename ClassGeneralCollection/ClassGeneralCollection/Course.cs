using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneralCollection
{
    class Course
    {
        public List<Student> students = new List<Student>();
        private Student student1 = new Student();
        private Student student2 = new Student();
        private Student student3 = new Student();
        private Teacher[] teachers = new Teacher[3];

        public string Courses { get; set; }

        public void defaultCourse()
        {
            
            student1.FirstName = "Greg";
            student1.LastName = "Wark";
            student1.Addr1 = "1234 Fail Blv.";
            student1.Addr2 = "";
            student1.City = "Electric";
            student1.State = "ZZ";
            student1.Zip = "98765";
            student1.Country = "WHY";

            student2.FirstName = "Nami";
            student2.LastName = "Lonely";
            student2.Addr1 = "456 Kick St.";
            student2.Addr2 = "";
            student2.City = "Lately";
            student2.State = "NP";
            student2.Zip = "12345";
            student2.Country = "CAP";

            student3.FirstName = "No";
            student3.LastName = "One";
            student3.Addr1 = "000 Null Ln.";
            student3.Addr2 = "";
            student3.City = "Anonomous";
            student3.State = "XX";
            student3.Zip = "00000";
            student3.Country = "YYY";

            //adding students
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            //adding grades to students.
            students[0].addNumOfGrades(5);
            students[1].addNumOfGrades(5);
            students[2].addNumOfGrades(5);

        }

        public void ListStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("Student: {0} {1} \n", student.FirstName, student.LastName);
            }

        }
    }
}
