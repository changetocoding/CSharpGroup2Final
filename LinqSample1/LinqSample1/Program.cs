using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqsamples1
{
    internal class program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            var querySyntax = from obj in numbers
                              where obj > 2
                              select obj;

            var methodSyntax = numbers.Where(obj => obj > 2);



            Console.WriteLine("....................................................");

            var methodsyntax = numbers.Where(obj => obj > 2);
            {
                            foreach(var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            }

            Console.ReadLine();




        }
        

    }
}
