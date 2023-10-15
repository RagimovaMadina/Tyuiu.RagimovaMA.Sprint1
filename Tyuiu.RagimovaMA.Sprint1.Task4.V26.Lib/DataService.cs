using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RagimovaMA.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Atan(x) + y) / Math.Exp(y + x), 3, MidpointRounding.AwayFromZero);
        }
    }
}
