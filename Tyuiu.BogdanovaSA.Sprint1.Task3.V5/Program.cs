using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Исходные данные ");
            double a = 12;
            double b = 17;
            Console.WriteLine("Результат");
            Console.WriteLine("Площадь прямоугольника = " + ds.Calculate(a, b));
            Console.ReadKey();
        }
    }
}
