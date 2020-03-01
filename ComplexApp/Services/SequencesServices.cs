using ComplexApp.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace ComplexApp.Services
{
    public class SequencesServices
    {
        Sequences globalSequence = (Sequences)System.Web.HttpContext.Current.Session["Sequences"];
        Sequences globalSequenceReverse = (Sequences)System.Web.HttpContext.Current.Session["SequencesReverse"];

        public bool validateInput(string inputData)
        {
            string pattern = @"^((\-?[0-9]+)(\.?[0-9]+)?)\^?((\-?[0-9]+)(\.?[0-9]+)?)$";
            bool result = Regex.IsMatch(inputData, pattern);
            return result;
        }

        public void addElementToSequence(string element)
        {
            globalSequence.Elements.Add(element);
            globalSequence.Elements.Sort();
            globalSequenceReverse.ElementsReverse.Add(element);
            globalSequenceReverse.ElementsReverse.Sort();
            globalSequenceReverse.ElementsReverse.Reverse();
        }

        public void removeElementFromSequence(int index)
        {
            globalSequence.Elements.RemoveAt(index);
            int size = globalSequence.Elements.Count();
            globalSequenceReverse.ElementsReverse.RemoveAt(size - index);
        }

    }
}