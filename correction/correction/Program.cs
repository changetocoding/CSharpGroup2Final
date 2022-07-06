namespace correction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<scramble> scramblequestion = new List<scramble>()
            {
                new scramble("hsto","host"),
                new scramble("osbt","bost"),
            };
            int total = 0;
             
            foreach(var question in scramblequestion)
            {
                Askquestion(question);
                for(int i = 0; i <= 2; i = i + 1)
                {
                    if (checkanswer(question.Answer) == 0)
                    {
                        Console.WriteLine("Try again");
                    }
                    else
                    {
                        total++;
                        break;
                    }
                }
            }

            static void Askquestion(scramble question)
            {
                Console.WriteLine(question.scrambleword);
                Console.WriteLine("Enter quess: ");
            }


            static int checkanswer(string correctanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("correct! you got one point");
                    return 1;
                   
                }
                else
                {
                    return 0;
                }
                

            }
            Console.WriteLine($"Your total is =  {total}");
        }
    }
}
