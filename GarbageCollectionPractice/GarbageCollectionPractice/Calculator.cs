﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionPractice
{
    //Constructor
    class Calculator : IDisposable
    {
        private bool disposed = false;
        //Constructor
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        //public divide method
        public int Divide(int first, int second)
        {
            return first / second;
        }

        //Destructor
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
