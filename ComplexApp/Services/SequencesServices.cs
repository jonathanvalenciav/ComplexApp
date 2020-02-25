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
            globalSequence.Element.Add(element);
            globalSequence.Element.Sort();
            globalSequenceReverse.ElementReverse.Add(element);
            globalSequenceReverse.ElementReverse.Sort();
            globalSequenceReverse.ElementReverse.Reverse();
        }

        public void removeElementFromSequence(int index)
        {
            globalSequence.Element.RemoveAt(index);
            int size = globalSequence.Element.Count();
            globalSequenceReverse.ElementReverse.RemoveAt(size - index - 1);
        }

    }
}