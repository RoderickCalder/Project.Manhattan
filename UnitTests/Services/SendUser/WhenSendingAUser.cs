using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Models;
using Project.Manhattan1.Services;

namespace UnitTests.Services.SendUser
{
    [TestClass]
    public class WhenSendingAUser
    {
        [TestMethod]
        public void TheMessageIsSentToTheDatabase()
        {
            var testModel = new UserModel
            {
                Name = "testName"
            };
            var testClass = new UserSend();

            Assert.AreEqual(testClass.SendUsers(testModel), true);
        }

    }
}