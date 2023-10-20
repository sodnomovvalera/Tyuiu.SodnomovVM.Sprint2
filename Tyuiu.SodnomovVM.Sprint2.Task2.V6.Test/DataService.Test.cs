using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SodnomovVM.Sprint2.Task2.V6.Lib;


namespace Tyuiu.SodnomovVM.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 4;
            int y = 4;
            DataService ds = new DataService();


            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
