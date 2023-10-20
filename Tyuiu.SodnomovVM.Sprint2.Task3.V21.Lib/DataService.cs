using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SodnomovVM.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return x * Math.Pow(((x + 9) / (x - 1)), x);
            }
            else if (x == 0)
            {
                return (Math.Pow(x, 2) + 9) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if ((x> -25)&&(x<2))
            {
                return Math.Pow((1 + 1 / Math.Pow(x, 2)), x);

            }
            else
            {
                return (x + 10 * x - (1 / x));
            }

            
        }
    }
}
