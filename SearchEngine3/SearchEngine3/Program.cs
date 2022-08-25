using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            while (true)
            {
                Console.WriteLine("WELCOME TO THE SEARCH ENGINE APP. WHAT WOULD YOU WANT TO DO");
                Console.WriteLine("[1] DISPLAY ALL INFORMATIONS.  [2]   DISPLAY TOWN INFORMATION.    [3]  DISPLAY COUNTY INFORMATION.   [4]  DISPLAY DUPLICATED TOWNS ");
                var choose = Console.ReadLine();
                if (choose == "1")
                {
                    var display = search.DisplayingAllInformations();
                    foreach (var item in display)
                    {
                        Console.WriteLine($"{item.Name},    {item.County},     {item.Country}");
                    }
                }
                else if (choose == "2")
                {
                    Console.WriteLine("ENTER THE NAME OF THE TOWN");
                    var option = Console.ReadLine();
                    var contain = search.GivingTownName(option);
                    foreach (var con in contain)
                    {
                        Console.WriteLine($"{con.Name},   {con.County},     {con.Country}");
                    }
                }
                else if (choose == "3")
                {
                    Console.WriteLine("ENTER THE NAME OF THE COUNTY");
                    var option = Console.ReadLine();
                    var contains = search.GivingCountyName(option);
                    foreach (var con in contains)
                    {
                        Console.WriteLine($"{con.Name},   {con.County},     {con.Country}");
                    }
                }
                else if (choose == "4")
                {
                    IEnumerable<IGrouping<string, Place>> dup = search.FindingAllDuplicates();
                    foreach (var con in dup)
                    {
                        Console.WriteLine($"{con.Key}, {con.Count()}");
                    }
                    Console.WriteLine(dup.Count());
                }
            }
        }
    }
}