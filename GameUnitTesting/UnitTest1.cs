using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roullete;

namespace GameUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        shootaway UnitTestObj1 = new shootaway();
        [TestMethod]
        public void TestBulleteChange()

        {
            var jatt = UnitTestObj1.BulleteChange(change: 5);
            Assert.AreEqual(expected:6,actual:jatt);
        }
        public void TestBulletChange()

        {
            var jatt = UnitTestObj1.BulleteChange(change: 5);
            Assert.AreNotEqual(notExpected: 5, actual: jatt);
        }
    }
}
