using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using linqsamples;

namespace Helloworld
{
     class Program
     {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name= "Isama Michael", Email="isamamichael2005@gmail.com"},
                new Employee(){Id=2, Name= "Basil Precious", Email="okpazobo2004@gmail.com"},
                new Employee(){Id=3, Name= "Adikwu Maria", Email="marigoldperi@gmail.com"},
                new Employee(){Id=4, Name= "Olofu Emmanuel", Email="emacoolofu234@gmail.com"},
            };

            var ms = employees.OrderByDescending(emp => emp.Id).ToList();

            foreach(var item in ms)
            {
                Console.WriteLine(item);
            }

            //foreach(var item in basicpropQuery)
            //{
            //    Console.WriteLine($"Id: {item.Id}   Name: {item.Name}   Email: {item.Email}")
            //}
          



            Console.ReadLine();
        }


     }
}