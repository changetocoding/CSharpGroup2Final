namespace ScrammbleApp
{
    class program
    {

        static void Main(string[] args)
        {

            Dictionary<int, string> hobby = new Dictionary<int, string>();
            hobby.Add(1, "question,stine,us");
            hobby.Add(2, "pot,type,typewriter");


            List<Scramble> ScrambleQuestion = new List<Scramble>()
            {
                    new Scramble ("uestionq", "question", "stine", "us", "question stine us"),
                    new Scramble ("qwertyuiop", "pot", "type", "typewriter", "pot type typewriter")


            };
            string checkcorrect = Console.ReadKey(hobby);
            foreach (var Scramble in checkcorrect)
            {

            }
            

            /*int totalgrade = 0;
            foreach (var check in ScrambleQuestion)
            {
                scrambleques(check);
                totalgrade += CheckAnswer(check.Answer);
               *//* totalgrade += CheckAnswer(check.word2);
                totalgrade += CheckAnswer(check.word3);*//*


            }*/
           
                int totalgrade = 0;
                foreach (var check in ScrambleQuestion)
                {
                    scrambleques(check);
                    totalgrade += CheckAnswer(check.word1);
                    totalgrade += CheckAnswer(check.word2);
                    totalgrade += CheckAnswer(check.word3);
                    Console.WriteLine(check.Answer);

                    Console.WriteLine($"u scored {totalgrade * 2}");
                }


                static int CheckAnswer(string correctanswer)
                {
                    string answer = Console.ReadLine();
                    if (answer.Equals(correctanswer, StringComparison.InvariantCultureIgnoreCase))
                    {
                        /* Console.WriteLine("u pass u have 1 point");*/
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("failed");
                        return 0;

                    }
                    
                }
         
           
            Console.WriteLine("u pass u have 1 point");

            static void scrambleques(Scramble ScrambleQuestion)
                {
                    Console.WriteLine(ScrambleQuestion.scrambled_word);

                    Console.WriteLine("Enter option: ");

                }

                foreach (var all in hobby)
                {
                    Console.WriteLine($"All The Possible Words In Question  Are :{all.Value}");
                }
                /*
                        List<Answers> answers = new List<Answers>
                        {
                             new Answers ("uestionq","question","stine", "us"),
                        };

                        foreach (var check in answers)
                        {
                            scrambleans(check);
                        }

                        static void  scrambleans(Answers answers)
                        {
                            Console.WriteLine(answers.scrambledWord);
                            Console.WriteLine(answers.wordAnswer1);
                            Console.WriteLine(answers.wordAnswer2);
                            Console.WriteLine(answers.wordAnswer3);


                        }*/
                //AttributeTargets=Random


        }

            
        

        
     }
    
   
}