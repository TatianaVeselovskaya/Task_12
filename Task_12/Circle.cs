using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Circle
    {
        static public double Getlength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public Boolean GetPrinad(double x, double y, double x0, double y0, double r)
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= r * r)
            {
                return true;
            }
            else return false;
        }
    }
}
