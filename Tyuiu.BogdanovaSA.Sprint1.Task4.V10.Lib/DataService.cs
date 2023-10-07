using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BogdanovaSA.Sprint1.Task4.V10.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Pow(y, 2) - x) / x * y);
            return res;
        }
    }
}
