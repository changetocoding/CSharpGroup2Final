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

            var basicpropQuery = (from emp in employees
                              select emp.Email).ToList();
            var basicMethod = employees.Select(emp=>emp.Email).ToList();



            Console.ReadLine();
        }


     }
}