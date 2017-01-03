using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BobsHelper.Tests
{
    [TestClass]
    public class BObject_UnitTest
    {
        [TestMethod]
        public void BObject_AreNotSame()
        {
            object test = new object();
            object areSame = test;
            Assert.AreSame(test, areSame);
            object test2 = BObject.Clone(test);
            Assert.AreNotSame(test, test2);
        }
    }
}
