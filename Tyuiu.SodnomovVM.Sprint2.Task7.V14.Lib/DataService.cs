﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SodnomovVM.Sprint2.Task7.V14.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SodnomovVM.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool rez;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= (-x)) || (x >= 0))
            {
                rez = true;
            }
            else
            {
                rez = false;
            }
            return rez;
        }
    }
}
