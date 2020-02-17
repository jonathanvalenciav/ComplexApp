using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplexApp.Models
{
    public class Sets
    {
        public Sets()
        {
            this.Elements = new HashSet<string>();
            this.Elements.Add("Elemento 1");
            this.Elements.Add("Elemento 2");
            this.Elements.Add("Elemento 3");
        }

        public int Id { get; set; }
        public HashSet<string> Elements{ get; set; }

    }
}