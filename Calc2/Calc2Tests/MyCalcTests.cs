using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calc2.Tests
{
    [TestClass()]
    public class MyCalcTests
    {
        [TestMethod()]
        public void dellTest()
        {
            //arrange
            double a = 0;
            double b = 3; 
            double expected = 0;
            //act
            MyCalc c = new MyCalc();
            double actual = c.dell(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}