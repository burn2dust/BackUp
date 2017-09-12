using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challeges_
{
    class Solution
    {
        public static bool isN (int first, int second, int n)
        {
            int test = first + second + 1;
            if (test == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int d1 = 0, d2 = 0, counter = n;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        d1 += a[i][j];
                    }
                }
                for (int k = counter-1; k >= 0; k--)
                {
                    if (isN(i,k,n))
                    {
                        d2 += a[i][k];
                        counter--;
                    }
                }
            }
            Console.WriteLine(Math.Abs((d1 - d2)));
        }
    }
}
