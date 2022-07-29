using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletePhonebookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you can perform the following operations");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. View all contact");
            Console.WriteLine("3. press x to quit");
            var userInput2 = Console.ReadLine();
            var userInput = Console.ReadLine();



            var newcontact = new Phonebook();

            while (true)
            {
                var split = userInput.Split();
                var opt = split[0];

                var name = split[1];
                var number = split[2];

                if (opt == "save")
                {
                    newcontact.AddContact(name, number);
                    Console.WriteLine("save sucessfull");
                }
                else if (opt == "view")
                {
                    newcontact.ViewContact(name);
                }
            }
            

           


            //while (true)
            //{

            //    switch (userInput2)
            //    {
            //        case "1":
            //            var split = userInput.Split();
            //            if (opt == userInput)
            //            {
            //                var name = split[0];
            //                var number = split[1];
            //                newcontact.AddContact(name, number);

            //             }




            //            //var newcontact = new Contacts(name, number);
            //            //phonebook.AddContact();


            //            break;
            //        case "2":
            //            Console.WriteLine("enter contact to view");
            //            var viewcontat = Console.ReadLine();
            //            contact.ViewContact(viewcontat);
            //            break;
            //        case "x":
            //            return;
            //    }
            //    Console.WriteLine("enter opreation");
            //    userInput = Console.ReadLine();
            

        }
    }
}
