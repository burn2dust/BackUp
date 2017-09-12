using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Student : Person
    {
        private static int numOfStudents = 0;
        private int grade = 0;
        public Stack Grades = new Stack();

        public Student()
        {

        }

        public Student(string fn, string ln, string addr1, string addr2, string cit, string st, string zp, string countrie)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Addr1 = addr1;
            this.Addr2 = addr2;
            this.City = cit;
            this.State = st;
            this.Zip = zp;
            this.Country = countrie;
        }

        public static int NumOfStudents { get; set; }

        public int Grade { get; }

        public void addNumOfGrades(int j)
        {
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Enter the grade(s) for the student, previous to most recent ({0}):", j);
                //grade = Console.ReadLine();
                grade = 75;
                Grades.Push(grade);
                grade =- 25;
            }
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking the test");
        }


    }
}
