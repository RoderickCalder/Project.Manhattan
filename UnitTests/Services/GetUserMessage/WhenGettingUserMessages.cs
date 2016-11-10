using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Manhattan1.Models;
using Project.Manhattan1.Services;

namespace UnitTests.Services
{
    [TestClass]
    public class WhenGettingUserMessages
    {
        [TestMethod]
        public void CanGetUserMessages()
        {
            var mockClass = new MessageSend();
            var testClass = new MessageGet();
            var testMessage = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Hello World!",
                UserFrom = "Jack Black"
            };

            var secondTestMessage = new MessageModel
            {
                DateTime = DateTime.Now.ToString(),
                Message = "Hello World!",
                UserFrom = "Jack Pink"
            };

            mockClass.SendMessages(testMessage);
            mockClass.SendMessages(secondTestMessage);
            List<MessageModel> List = testClass.GetMessages();


            Assert.AreEqual(List.First().Message, testMessage.Message);
            Assert.AreEqual(List.First().UserFrom, testMessage.UserFrom);

            }
        }
    }