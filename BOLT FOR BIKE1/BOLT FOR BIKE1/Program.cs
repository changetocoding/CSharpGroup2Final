using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLT_FOR_BIKE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void user_form()
            {

                Console.WriteLine("kindly fill the form below");
                Console.WriteLine("Your Fullname");
                string fullname = Console.ReadLine();
                Console.WriteLine("Your Address");
                string address = Console.ReadLine();
                Console.WriteLine("Select username");
                string username = Console.ReadLine();
                Console.WriteLine("chose password");
                string password = Console.ReadLine();
                List<string> user = new List<User>()
            {
              new User(fullname,address,username,password),
            };


                while (true)
                {
                    Console.WriteLine("what would you want to do...1.Register...2.Login");
                    string op = Console.ReadLine();
                    if (op == "1")
                    {
                        Console.WriteLine("what category do you want to register under...1.User...2.Provider");
                        string op1 = Console.ReadLine();
                        if (op1 == "1")
                        {
                            User.user_form();

                        }
                        else if (op1 == "2")
                        {
                            Provide.provide_form();
                        }

                    }

                    else if (op == "2")
                    {
                        Console.WriteLine("what category do you want to login under...1.User...2.Provider");
                        string op2 = Console.ReadLine();
                        if (op2 == "1")
                        {
                            Console.WriteLine("Enter username");
                            string loginusername = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            string loginuserpassword = Console.ReadLine();
                            //if (User.user.Contains.(loginusername) && user.Equals(loginuserpassword))
                            //{
                            //    Console.WriteLine("login Successfully");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("invalid login details");
                            //}

                        }
                    }




                }
            }
        }
    }
}
