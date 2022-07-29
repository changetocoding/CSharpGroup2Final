using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletePhonebookApp
{
    internal class Contacts
    {
        

        public string Name { get; set; }
        public string Number { get; set; }

        public Contacts (string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
