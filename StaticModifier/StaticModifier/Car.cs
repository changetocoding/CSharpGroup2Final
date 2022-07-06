using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal class Car
    {
        public static string Carnumber;


        public Car(string model)
        {
            Carnumber++;
        }

        public static void take()
        {
            Console.WriteLine("go");
        }

    }
}
