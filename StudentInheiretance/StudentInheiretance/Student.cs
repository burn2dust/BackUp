using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
    class Student : Person
    {
        public static int numOfStudents = 0;

        public void TakeTest()
        {
            Console.WriteLine("Taking the test");
        }

    }
}
