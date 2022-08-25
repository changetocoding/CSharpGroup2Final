using SearchEngine2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine2
{
    public class Search
    {
        List<Place> places;
       
        public Search()
        {
            var fileLoc = @"C:\Users\WINDOWS 10 PRO\Desktop\Transfering Data Between Classes\TownCountyCountry.txt";
            var placename = new PlaceNamesService();
            var results = placename.GetPlaceNames(fileLoc);
             places = new List<Place>();

            foreach (var result in results)
            {
                var store = new Place(result.Name, result.County, result.Country);
                places.Add(store);
            }
        }

        public IEnumerable<Place> DisplayingAllInformations()
        {
           var display= places.Select(x => x).First();
            return places;

        }

       public IEnumerable<IGrouping<string, Place>> FindingAllDuplicates()
        {
        

            var duplicate = places.GroupBy(x => x.Name).Where(x => x.Count() > 1).Select(x => x);
            return duplicate;
        }

        public IEnumerable<Place>  GivingTownName(string op)
        {
            var contain = places.Where(x => x.Name == op).ToList();
            return contain;
        }

        public IEnumerable<Place> GivingCountyName(string option)
        {
            var contains = places.Where(x => x.County == option);
            return contains;
        }
    }
}
