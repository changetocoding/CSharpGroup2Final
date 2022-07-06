namespace Simplified_Quiz_App
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QuizQuestion question1 = new QuizQuestion();
             question1.Question = "what is my name?";
             question1.OptionA = "Great";
             question1.OptionB = "Samuel";
             question1.OptionC = "Isaac";
             question1.OptionD = "Grace";
             question1.Answer = "Isaac";


             QuizQuestion question2 = new QuizQuestion();
             question2.Question = "where are you?";
             question2.OptionA = "G.R.A";
             question2.OptionB = "Quaters";
             question2.OptionC = "Babylon";
             question2.OptionD = "Eupi";
             question2.Answer = "Quaters";


             QuizQuestion question3 = new QuizQuestion ("How many days are there in a week", "20","7", "6", "5", "B");

             Console.WriteLine(question3.Question);*/


            List<QuizQuestion> questions = new List<QuizQuestion>
            {
               new QuizQuestion ("How many days are there in a week", "20","7", "6", "5", "B"),
               new QuizQuestion ("what is the name of this user", "John","Kelly", "Cindy", "Isaac", "D" ),
               new QuizQuestion ("what is your current location", "GRA","Quaters", "Eupi", "Babylon", "B"),
               new QuizQuestion ("An atom consists of how many particles?", "4", "3", "6", "5", "B"),
               new QuizQuestion ("the following are example of software you can use for graphics.Except..","Figma","VS code", "Adobe XD", "Illustrator","B"),

            };
            int totalgrade = 0;
            foreach(var check in questions)
            {
                Askquestion(check);
                totalgrade+= CheckAnswer(check.Answer);
            }

            static int CheckAnswer(string correctanswer)
            {
                string answer = Console.ReadLine();
                if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("u pass u have 1 point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("failed");
                    return 0;
                }
            }

            static void Askquestion(QuizQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine(("A ") + question.OptionA);
                Console.WriteLine(("B ") + question.OptionB);
                Console.WriteLine(("C ") + question.OptionC);
                Console.WriteLine(("D ") + question.OptionD);
                Console.WriteLine("Enter option: ");

            }
            Console.WriteLine($"you scored {totalgrade * 2}");
        }



    }

}
