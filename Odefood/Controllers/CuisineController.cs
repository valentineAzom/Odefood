using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Odefood.Filters;

namespace Odefood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [Log]
        public ActionResult Search(string name)
        {
            String message = Server.HtmlEncode(name);
            //return RedirectToAction("index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { Controller = "Home", Action = "About" });
            //byte[] fileBuffer = null;
            //using (FileStream fileContent = new FileStream(Server.MapPath("~/Content/resume_cv.pdf"), FileMode.Open, FileAccess.Read))
            //{
            //    fileBuffer = new byte[fileContent.Length];
            //    fileContent.Read(fileBuffer, 0, (int)fileContent.Length);
            //}

            //throw new Exception("Something terrible has happened");

            return Json(new { Message = message, name = name }, JsonRequestBehavior.AllowGet);
            
        }
    }
}