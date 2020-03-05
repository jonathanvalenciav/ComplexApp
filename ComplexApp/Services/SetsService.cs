using ComplexApp.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace ComplexApp.Services
{
    public class SetsService
    {
        public const char ELEMENTS_SEPARATOR = ',';
        public const string EMPTY_STRING = "";

        Sets globalSet = (Sets)System.Web.HttpContext.Current.Session["Sets"];
        string patternMultipleElements = @"^[\w\s._]+(?:\,[\w\s._]+)+$";


        public void addElement(string stringElement) {
            if (existsMultiplesElements(stringElement))
            {
                addMultiplesElements(stringElement);
            } else {
                addSingleElement(stringElement);
            }
        }

        private bool existsMultiplesElements(string elementToAdd) {
            return Regex.IsMatch(elementToAdd, patternMultipleElements);        
        }

        private void addSingleElement(string element)
        {
            if (!globalSet.Elements.Contains(element) && !element.Equals(EMPTY_STRING)){
                globalSet.Elements.Add(element);
            }            
        }

        private void addMultiplesElements(string StringOfElements)
        {
            string[] elements = StringOfElements.Split(ELEMENTS_SEPARATOR).Distinct().ToArray();
            
            foreach (string aElement in elements) {
                addSingleElement(aElement);
            }
        }

        public void removeElementFromSet(string element)
        {
            globalSet.Elements.Remove(element);
        }
    }
}