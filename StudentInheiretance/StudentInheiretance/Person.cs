using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInheiretance
{
    class Person
    {
        private string addr1, addr2;
        private string city, country;
        private string firstName, lastName;
        private string state, zip;

        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}
