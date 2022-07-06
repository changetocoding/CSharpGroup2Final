namespace ScrambleCorrection
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                            WELCOME TO SCRAMBLE GAME APP");
            Console.WriteLine();
            Console.WriteLine("INSTRUCTION: Your are limited to guess only one word from each scrambled word");
            Console.WriteLine();
            List<Scramble> ScrambleQuestion = new List<Scramble>()
            {
                new Scramble("olev","love"),
                new Scramble("atog","goat"),
                new Scramble("ypte","type"),
                new Scramble("ouyr","your"),
                new Scramble("onup","upon"),
                new Scramble("taom","atom"),


            };

            int total = 0;

            foreach(var question in ScrambleQuestion)
            {
                AskQuestion(question);

                for (int i = 0; i <= 2 ; i = i+1)
                {
                    if (checkanswer(question.Answer) == 0 )
                    {
                        Console.WriteLine("try again");
                    }
                    else
                    {
                        total++;
                        break;


                    }
                 
                }

            }


            static void AskQuestion(Scramble question)
            {
                Console.WriteLine(question.Scrambledword);
                Console.WriteLine("Enter quess: ");
               
            }

            static int checkanswer(string rightanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(rightanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                
                        Console.WriteLine("correct! You got one point");
                        return 1;
                    int total = total + 1;
                }

                else
                {
                    return 0;
                }
                
            }
            
            Console.WriteLine($"Your total = {total++}");
        }

    }
}