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
    }
}
