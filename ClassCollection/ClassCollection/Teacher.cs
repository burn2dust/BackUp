using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Teacher : Person
    {
        private int grade;

        public int Grade { get; set; }

        public void GiveTest()
        {
            Console.WriteLine("Giving the test to the student");
        }

        public void GradTest()
        {
            Console.WriteLine("Giving a \"random\" grade.");
        }


    }
}
