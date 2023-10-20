using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
//a = 145, b = 916, c = 164, d = 137

namespace Tyuiu.SodnomovVM.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a < c || a < c;
            res[1] = a < c || a < c;
            res[2] = a < c || a < c;
            res[3] = a < c || a < c;
            res[4] = a < c || a < c;
            res[5] = a > c || a > c;
            return res;
        }
    }
}
