using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    class Neighbor
    {
        private int neighbors = 0;
        bool isAlive(int[,] pos, int i, int j)
        {
            if (pos[i, j] == 1)
                return true;
            else
                return false;
        }
        bool neighborCheck(int?[,] pos, int i, int j)
        {
            int sum = 0;
            int? loc_up = pos[i + 1, j];
            int? loc_left = pos[i, j - 1];
            int? loc_right = pos[i, j + 1];
            int? loc_down = pos[i - 1, j];

            if (loc_up != null & loc_up == 1)
            {
                sum++;
            }
            if (loc_left != null & loc_up == 1)
            {
                sum++;
            }
            if (loc_right != null & loc_up == 1)
            {
                sum++;
            }
            if (loc_down != null & loc_up == 1)
            {
                sum++;
            }

            if (sum == 2 | sum == 3)
                return true;
            else
                return false;
        }

        bool willLive(int?[,] pos, int i, int j)
        {
            int?[,] self = pos;
            if (neighborCheck(self, i, j))
                return true;
            
            else
                return true;
        }

        bool willProduce()
        {
            
            return false;
        }
    }
    static class Program
    {
        public static int[,] grid = new int[9,9];

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
