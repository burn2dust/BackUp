using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
    class Teacher : Person
    {

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
