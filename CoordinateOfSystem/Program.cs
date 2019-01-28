using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateOfSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите значения координат \"x\" и \"y\" для точки");
            Console.Write("Введите \"x\": ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите \"y\": ");
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 & y > 0)
            {
                Console.WriteLine("I четверть");
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine("II четверть");
            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine("III четверть");
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine("IV четверть");
            }
            else if (x == 0 & y != 0)
            {
                Console.WriteLine("Точка находится на оси ординат");
            }
            else if (y == 0 & x != 0)
            {
                Console.WriteLine("Точка находится на оси абсцисс");
            }
            else if (x == 0 & y == 0)
            {
                Console.WriteLine("Точка находится в начале координат");
            }
            else
            {
                Console.WriteLine("Неверно заданы координаты");
            }
        }
    }
}
