using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    class Degree
    {
        private string degrees;

        public Course courses = new Course();

        public string Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }
    }
}
