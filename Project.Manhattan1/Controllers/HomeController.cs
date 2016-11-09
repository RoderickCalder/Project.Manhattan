﻿using System;
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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MessageModel messageModel)
        {
            var messageSent = new MessageHandler();
            messageSent.MessageSend(messageModel);
            return View();
        }
    }
}