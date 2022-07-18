using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class program
    {
        static void Main(string[] args)
        {
            var datasourceint = new List<int>() { 1, 2, 4, 6, 7, 9, 5, };

            var methodsyntax = (from num in datasourceint
                                orderby num descending
                                select num).ToList();
                               



            Console.ReadLine();

        }
    }
}
