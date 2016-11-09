using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Services;
using Project.Manhattan1.Models;

namespace UnitTests
{
    [TestClass]
    public class WhenSendingAMessage
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testing = new MessageSend();
            Assert.AreEqual(true, testing.getMessages());
        }
    }
}
