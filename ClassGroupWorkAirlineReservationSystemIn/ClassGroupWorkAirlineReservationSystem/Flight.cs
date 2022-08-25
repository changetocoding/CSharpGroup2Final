using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGroupWorkAirlineReservationSystem
{
    internal class Flight
    {
        public Flight()
        {
            passengers = new List<Passenger>();
        }
            public long Flight_Number { get; set; }
            public string TakeOff { get; set; }
            public string Destination { get; set; }
            public string Date_Of_Flight { get; set; }
            public List<Passenger> passengers { get; set; }
            public Plane planes { get; set; }

    }
}
