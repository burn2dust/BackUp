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
            int cntr = 0;
            do
            {
                int iCntr = 0;
                do
                {
                    if (cntr % 2 == 0)
                        Console.Write("XO");
                    else
                        Console.Write("OX");
                    iCntr++;

                } while (iCntr < 4);
                cntr++;
                Console.WriteLine();
            } while (cntr < 8);
            Console.ReadKey();
        }
    }
}
