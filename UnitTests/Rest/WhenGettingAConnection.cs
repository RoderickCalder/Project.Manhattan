using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Services;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace UnitTests
{
    [TestClass]
    public class WhenGetttingAConnection
    {
        [TestMethod]
        public void CanConnectToTheDatabase()
        {
            var testing = new RestClient();
            Assert.AreEqual(true, testing.getConnection());
        }
    }
}
