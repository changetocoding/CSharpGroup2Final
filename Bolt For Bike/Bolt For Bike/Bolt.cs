using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt_For_Bike
{
    internal class Bolt
    {
       

        public string _Name;
        public string _Username;
        public string _Address;
        public string _Age;
        public string _Nin;
        

        public Bolt(string name,string username,string add,string age, string nin)
        {
            _Name = name;
            _Username = username;
            _Address = add;
            _Age = age;
            _Nin = nin;
        }
        public Bolt()
        {

        }


    }
}
