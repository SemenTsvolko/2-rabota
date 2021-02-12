using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число z");
            double z = double.Parse(Console.ReadLine());
            double r1 = Math.Pow(z, 3);
            Console.WriteLine( "Введите число x" );
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y");
            double y= double.Parse(Console.ReadLine());
            Console.WriteLine("Сумма куба z и максимального из чисел x и y ");
            double r2 = Math.Max(x, y);
            double r3 = (r1 + r2);
            Console.WriteLine(r3);

            Console.ReadKey();
        }
    }
}
