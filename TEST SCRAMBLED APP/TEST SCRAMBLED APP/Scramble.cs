using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_SCRAMBLED_APP
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

        public Scramble(string scrambw, string word, string word1, string word2, string word3, string ans)
        {
            ScrambledWord = scrambw;
            FirstWord = word;
            SecondWord = word1;
            ThirdWord = word2;
            FourthWord = word3;
            Answers = ans;

            total = 0;

        }

        public static void instruct()
        {
            Console.WriteLine("1 : YOU HAVE FOUR ATEEMPTS AFTER");
        }

    }
}

