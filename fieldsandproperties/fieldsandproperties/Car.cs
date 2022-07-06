using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldsandproperties
{
    internal class Car
    {
        private int speed;
        private int wheels;


        public int speedproperty
        {
            get { return speed; }
            set 
            { 
                if (value > 250)
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public int wheelsproperty
        {
            get { return wheels; }
            set 
            { 
                if (value > 4)
                {
                    wheels = 4;
                }
                else
                {
                    wheels = value;
                }
            }
        }

        public string color { get; set; }
    }

    public string model
}
