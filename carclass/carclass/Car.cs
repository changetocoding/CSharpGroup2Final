using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carclass
{
    internal class Car
    {
        public string color;
        public string brandname;
        public string model;
        public int speedlimit;


        public Car (string col, string brandnm, string mod, int speedlim)
        {
            color = col;
            brandname = brandnm;
            model = mod;
            speedlimit = speedlim;
        }

        public Car()
        {
            
        }
    }
}



