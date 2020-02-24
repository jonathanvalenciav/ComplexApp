using System.Collections.Generic;

namespace ComplexApp.Models
{
    public class Sets
    {
        public Sets()
        {
            this.Elements = new HashSet<string>();
        }

        public int Id { get; set; }
        public HashSet<string> Elements{ get; set; }

    }
}