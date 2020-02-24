using ComplexApp.Models;
using System;

namespace ComplexApp.Services
{
    public class SetsService
    {
        Sets globalSet = (Sets)System.Web.HttpContext.Current.Session["Sets"];
        public void addElement(String element)
        {
            globalSet.Elements.Add(element);
        }

    }
}