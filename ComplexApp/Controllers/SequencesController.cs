using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComplexApp.Models;
using ComplexApp.Services;

namespace ComplexApp.Controllers
{
    public class SequencesController : Controller
    {
        // GET: Sequences
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sequences()
        {

            var globalSequence = (Sequences)System.Web.HttpContext.Current.Session["Sequences"];
            var globalSequenceReverse = (Sequences)System.Web.HttpContext.Current.Session["SequencesReverse"];

            System.Web.HttpContext.Current.Session["Sequences"] = globalSequence != null ? System.Web.HttpContext.Current.Session["Sequences"] : new Sequences();
            System.Web.HttpContext.Current.Session["SequencesReverse"] = globalSequenceReverse != null ? System.Web.HttpContext.Current.Session["SequencesReverse"] : new Sequences();

            return View();
        }

        public ActionResult addNewElementToSequence(double newElement)
        {
            var sequencesServices = new SequencesServices();
            sequencesServices.addElementToSequence(newElement);

            return View("Sequences");
        }


    }
}