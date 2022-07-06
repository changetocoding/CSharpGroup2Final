using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleCorrection
{
    internal class Scramble
    {
        public string Scrambledword;
        public string Answer;

        public Scramble(string ScrWord,string Ans)
        {
            Scrambledword = ScrWord;
            Answer = Ans;
        }
        public Scramble()
        {

        }
    }

 
}
