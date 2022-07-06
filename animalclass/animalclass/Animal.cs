using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalclass
{
    internal class Animal
    {
        public string Mode_Of_Feeding { get; set; }
        public bool Movement { get; set; }
        public string Habitat { get; set; }
        public bool Colony { get; set; }
        public string Respiration { get; set; }
        public string AnimalClass { get; set; }


        public Animal(string feed, bool move, string hab, bool col, string Resp, string anclass)
        {
            Mode_Of_Feeding = feed;
            Movement = move;
            Habitat = hab;
            Colony = col;
            Respiration = Resp;
            AnimalClass = anclass;


        }

        public Animal()
        {
          
        }



    }

}
