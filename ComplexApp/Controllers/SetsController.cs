using ComplexApp.Models;
using System.Web.Mvc;

namespace ComplexApp.Controllers
{
    public class SetsController : Controller
    {
        Sets aSet = new Sets();
        public ActionResult Sets()
        {
            return View(aSet);
        }
    }
}