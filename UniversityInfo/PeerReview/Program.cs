using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReview
{
    class Program
    {
        static void Main(string[] args)
        {
            String Firstname, Lastname, Address1, Address2, City, State, Country, Birthdate;
            int Postal;

            Console.WriteLine("\n***** Student Information ***** \n\n");
            Console.WriteLine("Enter first name :- ");
            Firstname = Console.ReadLine();
            Console.WriteLine("Enter last name :- ");
            Lastname = Console.ReadLine();
            Console.WriteLine("Enter address 1 :- ");
            Address1 = Console.ReadLine();
            Console.WriteLine("Enter address 2 :- ");
            Address2 = Console.ReadLine();
            Console.WriteLine("Enter City :- ");
            City = Console.ReadLine();
            Console.WriteLine("Enter State :- ");
            State = Console.ReadLine();
            Console.WriteLine("Enter Country :- ");
            Country = Console.ReadLine();
            Console.WriteLine("Enter Birthdate || dd/mm/yyyy || :- ");
            Birthdate = Console.ReadLine();
            Console.WriteLine("Enter Postal :- ");
            Postal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");
            Console.WriteLine("Firstname - " + Firstname);
            Console.WriteLine("Lastname - " + Lastname);
            Console.WriteLine("Address 1 - " + Address1);
            Console.WriteLine("Address 2 - " + Address2);
            Console.WriteLine("City - " + City);
            Console.WriteLine("State - " + State);
            Console.WriteLine("Country - " + Country);
            Console.WriteLine("Birthdate - " + Birthdate);
            Console.WriteLine("Postal - " + Postal);
        }
    }
}
