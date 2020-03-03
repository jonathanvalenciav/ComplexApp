using ComplexApp.Models;
using System;

namespace ComplexApp.Services
{
    public class SetsService
    {
        Sets globalSet = (Sets)System.Web.HttpContext.Current.Session["Sets"];
        public void addElement(String element)
        {
            int a = globalSet.Elements.Count;
            globalSet.Elements.Add(element);
            int b = globalSet.Elements.Count;

        }



        public void removeElementFromSet(string element)
        {
            globalSet.Elements.Remove(element);
        }

    }
}