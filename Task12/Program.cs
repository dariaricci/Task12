using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("x0 = ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y0 = ");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Circle.LengthCircle(r);
            Circle.SquareCircle(r);
            Circle.BelongToCircle(x,x0,y,y0,r);

            Console.ReadKey();
        }
        public static class Circle
        {
           

            public static void LengthCircle(double r)
            {
                Console.WriteLine("Длина окружности = {0}", 2 * Math.PI * r);
            }
            public static void SquareCircle(double r)
            {
                Console.WriteLine("Площадь оружности = {0}", Math.PI * Math.Pow(r, 2));
            }
            public static void BelongToCircle(double x, double x0, double y, double y0, double r)
            {
                if (Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2)) > r)
                {
                    Console.WriteLine("Точка не принадлежит кругу");
                }
                else
                {
                    Console.WriteLine("Точка принадлежит кругу");
                }
            }
        }

    }
}
