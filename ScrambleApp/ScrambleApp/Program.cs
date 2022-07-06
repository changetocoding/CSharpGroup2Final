namespace ScrambleApp {
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                          SCRAMBLE WORD GAME");
            Scramble.instruct();
            Console.WriteLine();
            List<Scramble> questions = new List<Scramble>();
            {
                questions.Add(new Scramble("UESTIONQ", "QUESTION", "ONE", "ON", "SON", "QUESTION ON ONE SON"));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", "TYPE YOUR WRITE TYPEWRITER"));
                questions.Add(new Scramble("ADLESCEONT", "ONE", "SCENT", "SCENE", "SENT", "ONE SCENT SCENE SENT"));
                questions.Add(new Scramble("DAOPETD", "DEAD", "POT", "TOP", "DOT", "DEAD POT TOP DOT"));
                //questions.Add(new Scramble("RAEODOREM", "ROME", "ARE", "RODE", "EAR", "ROME ARE RODE EAR"));
                //questions.Add(new Scramble("PPATEIIZGN", "APE", "PET", "GAP", "TAG", "APE PET GAP TAG"));
                //questions.Add(new Scramble("PAPALUES", "USE", "AS", "LAP", "SAP", "USE AS LAP SAP"));
                //questions.Add(new Scramble("BTAMETTNLE", "BENT", "BAT", "LET", "LAB", "BENT BAT LET LAB"));
            }
                while (true)
                {
                    foreach (var check in questions)
                    {
                        ScrambleWord(check);
                        ScrambleAnswer((check.FirstWord), (check.SecondWord), (check.ThirdWord), (check.FourthWord));
                        ScrambleAnswer((check.FirstWord), (check.SecondWord), (check.ThirdWord), (check.FourthWord));
                        ScrambleAnswer((check.FirstWord), (check.SecondWord), (check.ThirdWord), (check.FourthWord));
                        ScrambleAnswer((check.FirstWord), (check.SecondWord), (check.ThirdWord), (check.FourthWord));
                        Console.WriteLine($"THE POSSIBLE GUESSES ARE :{check.Answers}");
                      

                        Console.WriteLine(Scramble.total);
                    }
                        //Console.WriteLine(Scramble.total);
                break;
                }
                
            
            static void ScrambleWord(Scramble question)
            {
                Console.WriteLine(question.ScrambledWord);
                Console.WriteLine("Unscramble the Above Scrambled Word: ");
                
            }

            static int ScrambleAnswer(string scramble1, string scramble2, string scramble3, string scramble4)
            {


                string answer = Console.ReadLine();

                if (answer.Equals(scramble1, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(scramble2, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(scramble3, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(scramble4, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Correct Guess!!! You score a point.");
                    return Scramble.total++;

                }
                //else if (answer != answer || !answer.Equals(scramble1) && !answer.Equals(scramble2) && !answer.Equals(scramble3) && !answer.Equals(scramble4))
                //{
                //    Console.WriteLine("Word Already Guessed,Try Another Word...");
                //    return 0;
                //}
                else
                {
                    Console.WriteLine("WRONG GUESS");
                    return 0;
                }
                //Console.WriteLine($"You scored  {Scramble.total}");
            }
    
        }
    }
}
