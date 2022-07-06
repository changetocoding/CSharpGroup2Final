Console.WriteLine("#zzz");
Console.WriteLine("CBT APP");
List<int> total = new List<int>();
Console.WriteLine("press enter to start");
Console.ReadLine();

while (true)
{
    Console.WriteLine(" QUESTION 1: An atom consists of how many particles?");

    List<string> ques1 = new List<string>();

    ques1.Add("(a)3");
    ques1.Add("(b)4");
    ques1.Add("(c)6");
    ques1.Add("(d)7");
    ques1.Add("Select any other options to skip question ");

    foreach (var test in ques1)
    {
        Console.WriteLine(test);
    }

    string op = Console.ReadLine();
    if (op == "a")
    {
        total.Add(2);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");

    }
    else if (op == "a")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is d");
    }
    else if (op == "b")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is d");
    }
    else if (op == "c")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is d");
    }
    else
    {
        Console.WriteLine(" Skipped Question");

    }

    Console.WriteLine(" QUESTION 2: the following are example of software you can use for graphics.Except..");
    List<string> ques2 = new List<string>();

    ques2.Add("(a) Illustrator");
    ques2.Add("(b) Figma");
    ques2.Add("(c) VS Code");
    ques2.Add("(d) Canva");
    ques2.Add("Select  any other options to skip question ");

    foreach (var test in ques2)
    {
        Console.WriteLine(test);
    }

    string op2 = Console.ReadLine();
    if (op2 == "c")
    {
        total.Add(2);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");

    }

    else if (op == "b")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is c");
    }
    else if (op == "a")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is c");
    }
    else if (op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is c");
    }

    else
    {
        Console.WriteLine(" Skipped Question");

    }


    Console.WriteLine(" QUESTION 3: Who is the richest man in the world?");
    List<string> ques3 = new List<string>();

    ques3.Add("(a) Elon Musk");
    ques3.Add("(b) Joe Biden");
    ques3.Add("(c) Vitalik");
    ques3.Add("(d) Satoshi Nakamoto");
    ques3.Add("Select  any other options to skip question ");

    foreach (var test in ques3)
    {
        Console.WriteLine(test);
    }


    string op3 = Console.ReadLine();
    if (op3 == "a")
    {
        total.Add(2);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "b")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "c")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else
    {
        Console.WriteLine(" Skipped Question");

    }


    Console.WriteLine(" QUESTION 4: Who is the Father of Electricity?");
    List<string> ques4 = new List<string>();

    ques4.Add("(a) John Dalton");
    ques4.Add("(b) Isaac Newton");
    ques4.Add("(c) JIm Rues");
    ques4.Add("(d) Mendel");
    ques4.Add("Select  any other options to skip question ");

    foreach (var test in ques4)
    {
        Console.WriteLine(test);
    }


    string op4 = Console.ReadLine();
    if (op4 == "b")
    {
        total.Add(2);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "a")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "c")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else
    {
        Console.WriteLine(" Skipped Question");

    }



    Console.WriteLine(" QUESTION 5: The Bone ia a? ");
    List<string> ques5 = new List<string>();

    ques5.Add("(a) Cell");
    ques5.Add("(b) Ligament");
    ques5.Add("(c) Tissue");
    ques5.Add("(d) Muscle");
    ques5.Add("Select  any other options to skip question ");

    foreach (var test in ques5)
    {
        Console.WriteLine(test);
    }


    string op5 = Console.ReadLine();
    if (op5 == "c")
    {
        total.Add(2);
        Console.WriteLine("CORRECT, YOU SCORE 2 POINT");
    }
    else if (op == "a")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "b")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }
    else if (op == "d")
    {
        Console.WriteLine("Incorrect Answer");
        Console.WriteLine("The Answer is a");
    }

    else
    {
        Console.WriteLine(" Skipped Question");

    }

    Console.WriteLine($"Congratulation,your total score is {total.Sum()}");


    break;
}