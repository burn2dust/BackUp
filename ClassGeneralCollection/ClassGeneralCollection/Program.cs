using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneralCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation
            Course course = new Course();
            UProgram upro = new UProgram();

            course.defaultCourse();
            course.ListStudents();

        }
    }
}
