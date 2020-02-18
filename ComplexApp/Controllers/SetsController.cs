using ComplexApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ComplexApp.Controllers
{
    public class SetsController : Controller
    {

        public ActionResult Sets()
        {
            Sets aSet = new Sets();
            System.Web.HttpContext.Current.Session["HashCode"] = aSet.Id;
            System.Web.HttpContext.Current.Session["Sets"] = aSet.Elements;
            return View();
        }


    }
}