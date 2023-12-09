using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpleProject;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestSquareBy3Sides()
		{
			Assert.IsTrue(Math.Abs(6 - Program.SquareBy3Sides(3, 4, 5)) < 1e-8);
			Assert.IsTrue(Math.Abs(224.71857399867952 - Program.SquareBy3Sides(45, 16, 34)) < 1e-8);
		}

		[TestMethod]
		public void TestSquareBySideAndHeight()
		{
			Assert.IsTrue(Math.Abs(12 - Program.SquareBySideAndHeight(8, 3)) < 1e-8);
			Assert.IsTrue(Math.Abs(17.5 - Program.SquareBySideAndHeight(7, 5)) < 1e-8);
		}

		[TestMethod]
		public void TestSquareBySidesAndAngle()
		{
			Assert.IsTrue(Math.Abs(18 - Program.SquareBySidesAndAngle(8, 9, 30)) < 1e-8);
			Assert.IsTrue(Math.Abs(24 - Program.SquareBySidesAndAngle(8, 12, 30)) < 1e-8);
		}

		[TestMethod]
		public void TestSquareBySideAndRadius()
		{
			Assert.IsTrue(Math.Abs(12 - Program.SquareBySideAndRadius(5, 5, 6, 1.5)) < 1e-8);
			Assert.IsTrue(Math.Abs(6 - Program.SquareBySideAndRadius(3, 4, 5, 1)) < 1e-8);
		}
	}
}
