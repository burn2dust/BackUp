using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string AddressLine1;
            string AddressLine2;
            string city;
            string state_province;
            int zip_postal;
            string country;

            string userInput_String;
            int DOBYr;
            int DOBM;
            int DOBD;

            //firstName = "Bill";
            //lastName = "Baggins";
            //birthDate = new DateTime(1992, 6, 3);
            //AddressLine1 = "777 Casino Rd.";
            //AddressLine2 = "";
            //city = "Los Vegas";
            //state_province = "NV";
            //zip_postal = 6666;
            //country = "USA";

            //Beginning of challenge section

            Console.Write("Enter Student first name: ");
            userInput_String = Console.ReadLine();
            firstName = userInput_String;

            Console.Write("Enter Student last name: ");
            userInput_String = Console.ReadLine();
            lastName = userInput_String;

            Console.WriteLine("Enter Student's DOB Year: ");
            userInput_String = Console.ReadLine();
            Int32.TryParse(userInput_String,out DOBYr);

            Console.WriteLine("Enter Student's DOB Month: ");
            userInput_String = Console.ReadLine();
            Int32.TryParse(userInput_String, out DOBM);

            Console.WriteLine("Enter Student's DOB Day: ");
            userInput_String = Console.ReadLine();
            Int32.TryParse(userInput_String, out DOBD);


            birthDate = new DateTime(DOBYr, DOBM, DOBD);


            Console.WriteLine("Enter Student Address1 (use Address2 if necessary) : ");
            userInput_String = Console.ReadLine();
            AddressLine1 = userInput_String;

            Console.WriteLine("Enter Student Address2 (press Enter to skip) : ");
            userInput_String = Console.ReadLine();
            AddressLine2 = userInput_String;

            Console.WriteLine("Enter Student City: ");
            userInput_String = Console.ReadLine();
            city = userInput_String;

            Console.WriteLine("Enter Student State or Province: ");
            userInput_String = Console.ReadLine();
            state_province = userInput_String;

            Console.WriteLine("Enter Student Zip: ");
            userInput_String = Console.ReadLine();
            Int32.TryParse(userInput_String, out zip_postal);

            Console.WriteLine("Enter Student Country: ");
            userInput_String = Console.ReadLine();
            country = userInput_String;

            // end of challenge section

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate.ToString());
            Console.WriteLine(AddressLine1);
            if (AddressLine2 != "")
            {
                Console.WriteLine(AddressLine2);
            }
            Console.WriteLine(city);
            Console.WriteLine(state_province);
            Console.WriteLine(zip_postal.ToString());
            Console.WriteLine(country);
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
