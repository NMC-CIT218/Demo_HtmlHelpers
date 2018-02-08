using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_HtmlHelpers.Controllers
{
    public class HtmlHelperFormsController : Controller
    {
        // GET: HtmlHelperForms
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            foreach (var data in form)
            {
                ViewBag.Data = data.;
            }

            return View("DisplayInfo");
        }
    }
}