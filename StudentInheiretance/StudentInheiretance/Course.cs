using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
    class Course
    {
        private string courses;

        public Teacher[] teachers = new Teacher[3];
        public Student[] students = new Student[3];

        public string Courses
        {
            get { return courses; }
            set { courses = value; }
        }
    }
}
