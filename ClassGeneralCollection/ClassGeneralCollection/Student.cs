using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneralCollection
{
    class Student : Person
    {
        private static int numOfStudents = 0;
        private int grade = 0;
        public Stack<int> Grades = new Stack<int>();

        public Student()
        {
            //Initialization
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

        //public static int NumOfStudents { get; set; }

        public int Grade { get; }

        public void addNumOfGrades(int j)
        {
            int tempGrades = 75;
            for (int i = 0; i < j; i++)
            {
                //Console.WriteLine("Entering grade(s) for {0} student(s)...", j);
                grade = tempGrades;
                tempGrades =- 75;
                Grades.Push(grade);
            }
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking the test");
        }


    }
}
