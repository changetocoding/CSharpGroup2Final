using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrammbleApp
{
    internal class Scramble
    {
        public string scrambled_word { get; set; }
        public string word1 { get; set; }
        public string word2 { get; set; }
        public string word3 { get; set; }
        public string Answer { get; set; }
        
        
        public Scramble(string SW, string W1, string W2, string W3, string ans)
        {
            scrambled_word = SW;
            word1 = W1;
            word2 = W2;
            word3 = W3;
            Answer = ans;
        }
    }
}
