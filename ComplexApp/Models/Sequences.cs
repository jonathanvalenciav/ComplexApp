using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ComplexApp.Models
{
    public class Sequences
    {

        public Sequences()
        {
            
            this.Elements = new List<string>();
            this.ElementsReverse = new List<string>();

        }

        public int Id { get; set; }
        public List<string> Elements { get; set; }
        public List<string> ElementsReverse { get; set; }

    }
}