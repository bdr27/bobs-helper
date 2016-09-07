using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BobsHelper;

namespace BobsHelper.Tests
{
    [TestClass]
    public class BNull_UnitTest
    {
        [TestMethod]
        public void BNull_AreNull_True()
        {
            int? nullInt = null;
            object nullObject = null;
            string nullString = null;
            Assert.IsTrue(BNull.AreNull(nullInt, nullObject, nullString));
        }

        public void BNull_AreNull_False()
        {
            int? nullInt = null;
            object nullObject = null;
            string nullString = "";

            Assert.IsFalse(BNull.AreNull(nullInt, nullObject, nullString));
        }
    }
}
