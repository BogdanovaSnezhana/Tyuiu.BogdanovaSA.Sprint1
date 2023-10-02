using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint1.Task0.V0.Lib;


namespace Tyuiu.BogdanovaSA.Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Богданова С.А. | ИСПб-23-1";
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                                                         *");
            Console.WriteLine("* Задание #0                                                                                               *");
            Console.WriteLine("* Вариант #25                                                                                              *");
            Console.WriteLine("* Выполнила: Богданова Снежана Андреевна | ИСПб-23-1                                                       *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)                                             *");
            Console.WriteLine("* И печатает результат на экране.                                                                          *");
            Console.WriteLine("*                                                                                                          *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                         *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("* (30 / 6 - 4) * 3                                                                                         *");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                               *");
            Console.WriteLine("************************************************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
