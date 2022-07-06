using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworkproperties
{
    internal class Human
    {
        private int leg;
        private int eye;
        private int teeth;


        public int legproperty
        {
            get { return leg; }
            set 
            {
                if (value != 2 )
                {
                    leg = 2;
                }
                else
                {
                    leg = value; 
                }
            }
        }

        public int eyeproperty
        {
            get { return eye; }
            set
            {
                if (value != 2)
                {
                    eye = 2;
                }
                else
                {
                    eye = value;
                }
            }
        }

        public int teethpropetry
        {
            get { return teeth; }
            set
            {
                if (value >= 32)
                {
                    teeth = 32;
                }
                else
                {
                    teeth = value;
                }
            }
        }

    }
}
