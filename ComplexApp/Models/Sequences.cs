using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplexApp.Models
{
    public class Sequences
    {

        public Sequences()
        {
            this.Element = new List<double>();
            this.ElementReverse = new List<double>();

        }       

        public int Id { get; set; }
        public List<double> Element { get; set; }
        public List<double> ElementReverse { get; set; }

    }
}