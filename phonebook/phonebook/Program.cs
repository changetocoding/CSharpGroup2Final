using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact();


            while (true)
            {
                Console.WriteLine("welcome");
                Console.WriteLine("");
                var userInput = Console.ReadLine();

                var split = userInput.Split();


                var opt = split[0];
                

                if(opt == "save")
                {
                    var name = split[1];
                    var number = split[2];
                    contact.AddContact(name, (long.Parse(number)));
                   
                }
                else if(opt == "view")
                {
                    var name = split[1];
                    contact.ViewContact(name);
                }
                else if (opt == "update")
                {
                    contact.U
                }


            }
        }
    }
}
