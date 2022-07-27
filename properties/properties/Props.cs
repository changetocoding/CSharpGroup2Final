using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Props
    {
        private int run;
        private bool score;

        public bool Score
        {
            get { return score; }
        }

        public int Run
        {
            get { return run; }
        }
    }
}
