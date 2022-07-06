namespace scrambletest
{
    class program
    {
        static void Main (string[] args)
        {
            List<scramble> scrambleques = new List<scramble>()
            {
                new scramble ("question", "ques", "west", "wet"),
            };

            foreach (var check in scrambleques)
            {
               

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
        }
    }
}