using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletePhonebookApp
{
    internal class Phonebook
    {
       /* private*//* List<Contacts> _contact { get; set; } = new List<Contacts>();*/
       private Dictionary<string, string> _contact = new Dictionary<string, string>();

        public void AddContact(Contacts contact, string name )
        {
            _contact.Add(contact.Name, contact.Number);
        }

        public void ViewContact(string name)
        {
            var contact = _contact.FirstOrDefault(c => c.Key == name);

            if(_contact.ContainsKey(name))
            {
                Console.WriteLine("contact does not exist");
            }
            else
            {
                Console.WriteLine($"{contact.Key}, {contact.Value}");
            }
        }

        internal void AddContact(string name, string number)
        {
            throw new NotImplementedException();
        }
    }
}
