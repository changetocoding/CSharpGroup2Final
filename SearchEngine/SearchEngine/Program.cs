using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchEngine
{
    class program
    {
        static void Main(string[] args)
        {
            var fileLoc = @"C:\Users\WINDOWS 10 PRO\Desktop\Transfering Data Between Classes\TownCountyCountry.txt";
            var placename = new PlaceNamesService();
            var results = placename.GetPlaceNames(fileLoc);
            var places = new List<Place>();

            foreach (var result in results)
            {
                
                var store = new Place(result.Name, result.County, result.Country);
                Regex.Replace(store.Name, (@"\(([^)]*)/)", ""));
                places.Add(store);

                Console.WriteLine($"{result.Name}, {result.County}, {result.Country}");
            }

            
            

            ////1
            //var duplicate = places
            //    .GroupBy(x => x.Name)
            //    .Where(x => x.Count() > 1)
            //    .Select(x => x);
                
            //foreach (var item in duplicate)
            //{
            //    Console.WriteLine($"{item.Key} {item.Count()}");

            //}
            //Console.WriteLine(duplicate.Count());





            //// 2
            //var op = Console.ReadLine();
            //var contain = places.Where(x => x.Name == op).ToList();

            //foreach (var item in contain)
            //{
            //    Console.WriteLine($"{item.Name} {item.County} {item.Country}");
            //}




            ////3

            //string option = Console.ReadLine();
            //var contains = places.Where(x => x.County == option);

            //foreach (var item in contains)
            //{
            //    Console.WriteLine($"{item.Name} {item.Country}");
            //}




        }

          

        
        
    }
}