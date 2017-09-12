using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation
            Course course = new Course();
            UProgram upro = new UProgram();
            //Student dummy = new Student();

            //dummy.addNumOfGrades(5);
            course.defaultCourse();
            course.ListStudents();
            
        }
    }
}
