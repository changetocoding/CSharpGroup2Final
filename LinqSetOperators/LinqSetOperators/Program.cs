using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TEST_LINQ
{
    class program
    {
        static void Main(String[] args)
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 3, 4, 5, 2, 1, 5, 4 };
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 3, 4, 5, 2, 1, 5, 7, 8 };

            //for distinct
            var ms = numbers.Distinct().ToList();

            var qs = (from num in numbers
                      select num).Distinct().ToList();



            // for  except
            List<string> data1 = new List<string>() { "ani", "beth", "cindy", "doir" };
            List<string> data2 = new List<string>() { "cindy", "doir", "emy", "far" };

            var mes = data2.Except(data1).ToList();

            var qus = (from ch in data2
                       select ch).Except(data1).ToList();

            //intersect
            List<string> datas1 = new List<string>() { "a", "b", "c", "d" };
            List<string> datas2 = new List<string>() { "c", "d", "e", "f" };

            //method
            var methodsy = datas1.Intersect(datas2).ToList();
            //query
            var querysy = (from data in datas1
                           select data).Intersect(datas2).ToList();


            //union
            List<string> datasource1 = new List<string>() {"a","b","c","d"};
            List<string> datasource2 = new List<string>() {"c","d","e","f"};

            //method
            var methods = datasource1.Union(datasource2).ToList();
            //query
            var querys = (from da in datasource1
                          select da).Union(datasource2).ToList();

            Console.ReadLine();

        }
    }
   
}

