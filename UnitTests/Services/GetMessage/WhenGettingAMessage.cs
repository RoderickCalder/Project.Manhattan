using System;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Services;
using Project.Manhattan1.Models;
using Project.Manhattan1.Rest;

namespace UnitTests.Services.GetMessage
{
    [TestClass]
    public class WhenGettingAMessage
    {
        [TestMethod]
        public void CanGetMessagesFromTheDatabase()
        {
            var testDate = new DateTime();
            var mockClass = new MessageSend();
            var testClass = new MessageGet();
            var testMessage = new MessageModel
            {
                DateTime = DateTime.Now,
                Message = "Hello World!",
                User = "Jack Black"
            };
            testDate = testMessage.DateTime;

            mockClass.SendMessages(testMessage);

            Assert.AreEqual(testClass.GetMessages(testDate), testMessage);
        }

        [TestMethod]
        public void TheMessageIsDeserializedCorrectly()
        {
            var testClass = new MessageGet();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var testMessage = new MessageModel
            {
                DateTime = DateTime.Now,
                Message = "Hello World!",
                User = "Jack Black"
            };
            var stringSerialized = jss.Serialize(testMessage);
            var result = testClass.DeserializeModel(stringSerialized);

            Assert.AreEqual(result.DateTime, testMessage.DateTime);
            Assert.AreEqual(result.Message, testMessage.Message);
            Assert.AreEqual(result.User, testMessage.User);
        }
    }
}