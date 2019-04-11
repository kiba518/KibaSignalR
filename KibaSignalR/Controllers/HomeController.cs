using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KibaSignalR.Controllers
{ 
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View();
        } 
    }
}