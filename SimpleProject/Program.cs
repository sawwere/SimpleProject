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
		/// 
		/// <returns>Площадь треугольника</returns>
		public static double SquareBy3Sides(double a, double b, double c)
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public static double SquareBySideAndHeight(double a, double h)
		{
			return a * h * 0.5;
		}

		public static double SquareBySidesAndAngle(double a, double b, double angle)
		{
			angle = (angle * Math.PI) / 180;
			return a * b * (Math.Sin(angle)) * 0.5;
		}

		public static double SquareBySideAndRadius(double a, double b, double c, double r)
		{
			double p = (a + b + c) / 2;
			return p * r;
		}

		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
