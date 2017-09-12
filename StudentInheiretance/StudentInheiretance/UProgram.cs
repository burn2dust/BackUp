using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
    class UProgram
    {
        private string uPrograms;

        public Degree degrees = new Degree();

        public string UPrograms
        {
            get { return uPrograms; }
            set { uPrograms = value; }
        }
    }
}
