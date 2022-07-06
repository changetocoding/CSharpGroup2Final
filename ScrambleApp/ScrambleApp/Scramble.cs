using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambleApp
{
    internal class Scramble
    {
        public string ScrambledWord;
        public string FirstWord;
        public string SecondWord;
        public string ThirdWord;
        public string FourthWord;
        public string Answers;
        public static int total;

        public Scramble(string scrambw, string word1, string word2, string word3, string word4, string ans)
        {
            ScrambledWord = scrambw;
            FirstWord = word1;
            SecondWord = word2;
            ThirdWord = word3;
            FourthWord = word4;
            Answers = ans;

            total = 0;

        }

        public static void instruct()
        {
            Console.WriteLine("INSTRUCTION : YOU HAVE FOUR POSSIBLE GUESSES IN EACH QUESTION");
        }
    }
}    

