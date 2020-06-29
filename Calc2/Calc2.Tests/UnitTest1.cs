using System;
using Calc2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Min30_20_ret10()
        {
            //arrange
            int x = 30;
            int y = 20;
            int expected = 10;
            //act
            MyCalc c = new MyCalc();
            int actual = c.min(x, y);
            //assert
           Assert.AreEqual(expected, actual);
        }
    }
}
