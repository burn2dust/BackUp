using System;

namespace NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            bool flip = false;
            int begin = 1;
            int end = 9;


            Console.WriteLine("Output:\n");


            for (int i = 0; i < 8; i++)
            {
                //clear data that may exist.
                string outputLine = "";

                //Always Flip!
                if (flip)
                {
                    flip = false;
                    begin++;
                    end++;
                }
                else
                {
                    flip = true;
                    begin--;
                    end--;
                }

                for (int j = begin; j < end; j++)
                {
                    //Decision on X or O first and flip between them.
                    if ((j % 2) == 1)
                    {
                        outputLine += 'O';
                    }
                    else
                    {
                        outputLine += 'X';
                    }
                }

                //Print XO's per line
                Console.WriteLine(outputLine);

            }
            //Extra fluff so output may be seen.
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
