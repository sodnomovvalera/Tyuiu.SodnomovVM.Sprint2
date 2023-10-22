using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SodnomovVM.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            string mast;
            switch (value)
            {
                case 1:
                    mast = "Пики";
                    break;
                case 2:
                    mast = "Трефы";
                    break;
                case 3:
                    mast = "Бубны";
                    break;
                case 4:
                    mast = "Червы";
                    break;
                default:
                    mast = "масть не определена";
                    break;

            }
            return mast;
     }   }
}
