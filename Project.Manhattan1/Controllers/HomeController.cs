using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Manhattan1.Services;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Controllers
{
    public class HomeController : Controller
    {
        public MessageHandler messageHandler = new MessageHandler();
        [HttpGet]
        public ActionResult Index()
        {
            var messageModel = new MessageModel();

            return View("Index", messageModel);
        }

        [HttpPost]
        public ActionResult Index(MessageModel messageModel)
        {
            messageModel.DateTime = DateTime.Now.ToString();
            messageModel.User = "ThisUser";
            messageHandler.MessageSend(messageModel);
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult SendChat(MessageModel messageModel)
        {
            messageModel.DateTime = DateTime.Now.ToString();
            messageModel.User = "ThisUser";
            messageHandler.MessageSend(messageModel);
            ModelState.Clear();
            return Index();
        }
        //SendChat


    }
}