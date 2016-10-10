using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp;

namespace SampleAppUnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AddValueAndOne_HandlesNegetiveOne()
        {
            var baseValue = new MockRepositoryOne();
            var worker = new Worker(baseValue);
            var passedValue = -1;
            var result = worker.AddValueAndOne(passedValue);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddOneAndOne_HandlesBadConnection()
        {
            var baseValue = new MockRepositoryBadConnection();
            var worker = new Worker(baseValue);
            var passedValue = 1;
            worker.AddValueAndOne(passedValue);
        }

    }
}
