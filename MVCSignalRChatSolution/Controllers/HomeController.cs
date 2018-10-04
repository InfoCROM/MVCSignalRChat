using MVCSignalRChatSolution.Data.Models;
using MVCSignalRChatSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSignalRChatSolution.Controllers
{
    public class HomeController : Controller
    {
        private DBService _dBService = new DBService();

        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult Chat(string id, HttpPostedFileBase img)
        {
            //img.ToString();

            if (string.IsNullOrEmpty(id))
                 return View("Index");

            User _user = new User();
            _user.UserName = id;
            if (_dBService.SetUser(_user))
                return View(_user);
            else
                return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}