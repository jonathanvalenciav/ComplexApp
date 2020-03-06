using ComplexApp.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace ComplexApp.Services
{
    public class SetsService
    {
        public const char ELEMENTS_SEPARATOR = ',';
        public const string EMPTY_STRING = "";
        public const char SPACE = ' ';
        public const char SYMBOL_EMPTY = '∅';

        Sets globalSet = (Sets)System.Web.HttpContext.Current.Session["Sets"];
        string patternMultipleElements = @"^[\w\s._]+(?:\,[\w\s._]+)+$";
        string patternSingleElement = @"^[\w\s\d.]+$";
        string patterEmptyElement = @"^[\s] +$";

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

        private bool isValidElement(string elementToAdd)        {
            return Regex.IsMatch(elementToAdd, patternSingleElement);
        }
        private bool isEmptyElement(string elementToAdd)
        {
            return Regex.IsMatch(elementToAdd, patterEmptyElement);
        }

        private void addSingleElement(string element)
        {
            if (isValidElement(element) && !globalSet.Elements.Contains(element) && !element.Equals(EMPTY_STRING)){
                if (isEmptyElement(element))
                {
                    element = SYMBOL_EMPTY.ToString();
                }
                globalSet.Elements.Add(element.Trim(SPACE));
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