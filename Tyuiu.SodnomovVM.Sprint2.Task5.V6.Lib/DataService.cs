using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SodnomovVM.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string dost;
            string mast;
            switch (value1)
            {
                case 6:
                    dost = "Шестерка";
                    break;
                case 7:
                    dost = "Семерка";
                    break;
                case 8:
                    dost = "Восьмерка";
                    break;
                case 9:
                    dost = "Девятка";
                    break;
                case 10:
                    dost = "Десятка";
                    break;
                case 11:
                    dost = "Валет";
                    break;
                case 12:
                    dost = "Дама";
                    break;
                case 13:
                    dost = "Король";
                    break;
                case 14:
                    dost = "Туз";
                    break;
                default:
                    dost = "Достоинство карты не определено";
                    break;

            }
            switch (value2)
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
            return (dost +" " + mast);
        }
    }
}
