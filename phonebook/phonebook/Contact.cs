using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    internal class Contact
    {
        public string Name { get; set; }
        public long Number { get; set; }


        Dictionary<string, long> contacts = new Dictionary<string, long>();

        public void AddContact(string name, long number)
        {
            contacts.Add(name, number);
            Console.WriteLine("save sucesful");

        }

        public void ViewContact (string name )
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine(contacts[name]);
            }
            else
            {
                Console.WriteLine("contact does not exist");
            }
        }

        public void UpdateContact(string name, long number)
        {
            if (contacts.ContainsKey(name))
            {
                contacts[Name] = number;
                Console.WriteLine($"{name} and {number} updated sucessfully");
            }
            else 
            {
                Console.WriteLine("not udted");
            }
        }

        
    }
}
