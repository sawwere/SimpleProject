using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    public class Program
    {
        /// <summary>
        /// Площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Площадь треугольника</returns>
        public static double SquareBy3Sides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(666);
            Console.ReadKey();
        }
    }
}
