using System;
using System.IO;

namespace Basics.FileIO
{
    class FileInputNRead
    {    
        static void Main(string[] args)
        {
            string path = "test.dat";
            /* try to 
             * - open the data
             * -  - if it exists, read the data
             * -  - if it does not, create the data
             * - otherwise produce a general error
             * with a safe-handled "it went wrong here." type of thing.
            */
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i <= 20; i++)
            {
                fs.WriteByte((byte)i);
            }

            fs.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(fs.ReadByte() + " ");
            }

            fs.Close();
            Console.ReadKey();
        }
    }
}
