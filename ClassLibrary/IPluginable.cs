using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IPluginable
    {
        public string Format { get; }

        public void Save(List<Contact> contacts, string filePath);
        public List<Contact> Load(string filePath);
    }
}
