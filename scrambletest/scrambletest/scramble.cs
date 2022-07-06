using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrambletest
{
    internal class scramble
    {
        public string scrambled_word;
        public string word1;
        public string word2;
        public string word3;


        public scramble (string SW, string W1, string W2, string W3)
        {
            scrambled_word = SW;
            word1 = W1;
            word2 = W2;
            word3 = W3;
        }
    }
}
