using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Manhattan1.Models;
using Project.Manhattan1.Services;

namespace Project.Manhattan1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public bool MessageSender(MessageModel messageModel)
        {
            var messageSent = new MessageHandler();
            return messageSent.Handling(messageModel);
        }

    }
}