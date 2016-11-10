using System;
using System.Collections.Generic;
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
            var mockClass = new MessageSend();
            var testClass = new MessageGet();
            var testMessage = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Hello World!",
                UserTo = "Jack Black"
            };

            mockClass.SendMessages(testMessage);
            List<MessageModel> List = testClass.GetMessages();

            foreach (var item in List)
            {
                Assert.AreEqual(item.Message, testMessage.Message);
                Assert.AreEqual(item.UserTo, testMessage.UserTo);
            }
        }

        [TestMethod]
        public void TheMessageIsDeserializedCorrectly()
        {
            var testClass = new MessageGet();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var testMessage = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Hello World!",
                UserTo = "Jack Black"
            };
            var stringSerialized = jss.Serialize(testMessage);
            List<MessageModel> result = testClass.DeserializeModel(stringSerialized);

            foreach (var item in result)
            {
                Assert.AreEqual(item.Message, testMessage.Message);
                Assert.AreEqual(item.UserTo, testMessage.UserTo);
            }
        }
    }
}