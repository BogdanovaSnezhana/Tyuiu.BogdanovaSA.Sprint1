using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            a = Convert.ToInt32(Console.ReadLine());

            a *= a * a;

            int t = a;

            a = 0;

            Console.WriteLine(t);
        }
    }
}
