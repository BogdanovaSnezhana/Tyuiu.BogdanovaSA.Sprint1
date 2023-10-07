using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint1.Task4.V10.Lib;

namespace Tyuiu.BogdanovaSA.Sprint1.Task4.V10.cons
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Исходные данные:");
            int x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат:");
            Console.WriteLine("(y ^ 2 - x) / x * y =" + ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
