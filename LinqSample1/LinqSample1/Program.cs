using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqSample1;

namespace linqsamples1
{
    internal class program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id= 2,
                    FirstName="Basil",
                    LastName="Michael",
                    Email="isamamichael2005@gmail.com"
                },
                new Employee()
                {
                    Id= 3,
                    FirstName="Basil",
                    LastName="Maria",
                    Email="marigoldperi23@gmail.com"
                },
                new Employee()
                {
                    Id= 1,
                    FirstName="Basil",
                    LastName="Precious",
                    Email="okpazobo34@gmail.com"
                }
            };
            var qs = (from emp in employees
                      orderby emp.FirstName descending, emp.LastName
                      select emp).ToList();
            var ms = employees.OrderByDescending(emp => emp.FirstName).ThenBy(emp => emp.LastName).ToList();
    
            
            foreach(var item in qs)
            {
                Console.WriteLine($"Id: {item.Id}    FirstName: {item.FirstName}  LastName: {item.LastName}   Email: {item.Email}");


            }

            Console.ReadLine();




        }
        

    }
}
