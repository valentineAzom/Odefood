using Odefood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odefood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var Model = new DetailsModel();
            Model.Name = "Valentine's first MVC application";
            Model.Location = "Durban South Africa";
            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Durban South Africa";

            return View(Model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}