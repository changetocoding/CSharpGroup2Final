using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuging
{
    
    
        public class Message
        {
            public static string GetMessage (string lang)
            {
                if (lang.Equals("Igbo"))
                {
                    return "biaa";
                }
                else if (lang.Equals("Hausa"))
                {
                    return "zo";
                }
                else if (lang.Equals("Yoruba"))
                {
                    return "waa";
                }
                else if (lang.Equals("English"))
            {
                return "come";
            }
                else
                {
                    return "";
                }
            }
        }
    
}
