using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public abstract class Polygon
    {
        private int angle;
        private int sides;

        protected double sideLength;
        protected double radius;

        public int Sides { get; set; }

        public abstract int Area(int sides, int angle);
    }

    public class Square : Polygon
    {
        
        public override int Area(int sides, int angle)
        {
            Polygon p = new Square();
            

            return 0;
        }
    }
    public class CalcPi
    {
        public const int radius = 1;
        public double piDiff = 1;
        double pi = 4.0;

        public CalcPi()
        {
            
        }
        

        public static CalcPi circleArea(CalcPi prev)
        {
            CalcPi next = prev;
            

            return next;
        }
    }
}
