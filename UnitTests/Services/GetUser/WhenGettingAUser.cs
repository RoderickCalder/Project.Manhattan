using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Models;
using Project.Manhattan1.Services;

namespace UnitTests.Services.GetUser
{
    [TestClass]
    public class WhenGettingAUser
    {
        [TestMethod]
        public void CanGetUserFromTheDatabase()
        {
            var mockClass = new UserSend();
            var testClass = new UserGet();
            var testUser = new UserModel
            {
                Name = "testName"
            };

            mockClass.SendUsers(testUser);
            List<UserModel> List = testClass.GetUsers();

            foreach (var item in List)
            {
                Assert.AreEqual(item.Id, testUser.Id);   
                Assert.AreEqual(item.Name, testUser.Name);
            }

        }
    }
}