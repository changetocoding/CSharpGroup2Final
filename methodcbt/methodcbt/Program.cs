
Console.Write("CBT APP2 ");
Console.WriteLine(" SPECIAL WELCOME ");
int total = 0;

static void QUESTION(string question, string option1, string option2, string option3, string option4)
{
    Console.WriteLine($"{question}, { option1}, { option2}, { option3}, {option4}");
}

Dictionary<string, string> dict = new Dictionary<string, string>();

dict.Add("1234", "1234");
dict.Add("3322", "3322");
dict.Add("5454", "5454");
dict.Add("6544", "6544");
dict.Add("7876", "7876");
dict.Add("8855", "8855");

int attemptleft = 5;

while (true)
{


    for (int i = 1; i <= 5; i++)
    {



        Console.WriteLine("kindly provide your registration number!.");

        string regnum = Console.ReadLine();

        if (dict.ContainsKey(regnum))
        {
            Console.WriteLine("INITIALISATION SUCCESSFUL");


            Console.Clear();


            QUESTION(" QUESTION 1: where is ur current location?", "(a) G.R.A", "(b) Eupi", "(c) Quaters", "(d) swamp");
            string op1 = Console.ReadLine();
            if (op1 == "c")
            {
                Console.WriteLine("CORRECT");
                total++;
            }
            else
            {
                Console.WriteLine("FAILED");
            }
            Console.Clear();


            QUESTION(" QUESTION 2: what is my name is?", "(a) isaac", "(b) john", " (c) peace", "(c) daniel");
            string op2 = Console.ReadLine();
            if (op2 == "a")
            {
                Console.WriteLine("CORRECT");
                total++;
            }
            else
            {
                Console.WriteLine("FAILED");
            }
            Console.Clear();

            Console.Write("Your score is ");
            Console.WriteLine(total++ * 2);

            break;

        }

        else
        {
            Console.WriteLine("INITIALISATION FAILED");
            Console.WriteLine($"You Have {attemptleft = attemptleft - 1} attempt left");
            if (!dict.ContainsKey(regnum) && i >= 5)
            {
                Console.WriteLine("BLOCKED");

            }
        }










    }

    break;

}






//        }
//        else
//        {
//            Console.WriteLine("INITIALISATION FAILED");
//            break;
//        }

//    }
//    Console.WriteLine("blocked");

//}

