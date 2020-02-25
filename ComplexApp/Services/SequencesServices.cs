using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComplexApp.Models;

namespace ComplexApp.Services
{
    public class SequencesServices
    {
        Sequences globalSequence = (Sequences)System.Web.HttpContext.Current.Session["Sequences"];
        Sequences globalSequenceReverse = (Sequences)System.Web.HttpContext.Current.Session["SequencesReverse"];
        public void addElementToSequence(double element)
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