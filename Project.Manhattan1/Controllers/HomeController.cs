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

        public ActionResult Index()
        {
            MasterModel models = new MasterModel();
            models.User = messageHandler.GetUser();
            return View("Index", models);
        }

        [HttpGet]
        public ActionResult GetChat(string id, string userName)
        {
            MasterModel models = new MasterModel();
            models.Message = messageHandler.MessageGet();
            models.User = messageHandler.GetUser();
            return View("Index", models);
        }


        [HttpPost]
        public ActionResult SendChat(MessageModel messageModel)
        {
            messageModel.DateTime = DateTime.Now.ToString();
            messageModel.UserTo = "u";
            messageHandler.MessageSend(messageModel);
            ModelState.Clear();
            return Index();
        }


    }
}