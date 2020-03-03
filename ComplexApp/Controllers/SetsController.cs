using ComplexApp.Models;
using ComplexApp.Services;
using System.Web.Mvc;

namespace ComplexApp.Controllers
{
    public class SetsController : Controller
    {
        public ActionResult Sets()
        {
            var globalSet = (Sets)System.Web.HttpContext.Current.Session["Sets"];

            System.Web.HttpContext.Current.Session["Sets"] = globalSet != null ? System.Web.HttpContext.Current.Session["Sets"] : new Sets();

            return View();
        }

        public ActionResult addNewElement(string newElement)
        {
            char delimiter = ',';
            string[] elements = newElement.Split(delimiter);
            var setsService = new SetsService();
            foreach(var element in elements) {
                setsService.addElement(element);
            }
            
            return View("Sets");
        }

        public ActionResult removeElement(string element)
        {
            var setsServices = new SetsService();
            setsServices.removeElementFromSet(element);

            return View("Sets");
        }
    }
}