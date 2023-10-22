using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InfoAttribute : Attribute
    {
        public string Author { get; set; }

        public InfoAttribute(string author)
        {
            Author = author;
        }
    }
}
