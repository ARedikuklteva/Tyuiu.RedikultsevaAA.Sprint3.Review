using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RedikultsevaAA.TaskReview.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1)
                {
                    y = 0.00;
                }
                else
                { 
                    y = Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x; 
                }
                valueArray[count] = Math.Round(y, 2);
                count++;
            }
            return valueArray;
        }
    }
}
