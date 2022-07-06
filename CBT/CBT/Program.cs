
Console.WriteLine("JAMB CBT TEST");
Console.WriteLine("Press any key to continue");
Console.ReadLine();



Dictionary<string, string> dict = new Dictionary<string, string>();

dict.Add("1234", "1234");
dict.Add("3322", "3322");
dict.Add("5454", "5454");
dict.Add("6544", "6544");
dict.Add("7876", "7876");
dict.Add("8855", "8855");

while (true)
{
    Console.WriteLine("Enter your registration number");
    
    for (int i =1; i <= 5; i = i++)
    {
            string regnum = Console.ReadLine();

        if (dict.ContainsKey(regnum))
        {riteLine("INITIALISATION SUCCESSFUL");
/*            Console.Clear
                Console.W();
*/ew List<int>();
            Console.WriteLine(" 
            List<int> total = nQUESTION 1: An atom consists of how many particles?");
            List<string> ques = new List<string>();

            ques.Add("(a)3");
            ques.Add("(b)4");
            ques.Add("(c)6");
            ques.Add("(d)7");

            foreach (var test in ques)
            {
                Console.WriteLine(test);
            }

            string ques1 = Console.ReadLine();

            if (ques1 == "a")
            {
                total.Add(20);
                Console.WriteLine("you answered correctly");
            }
            else if (ques1 == "b" || ques1 == "c" || ques1 == "d")
            {
                Console.WriteLine("FAILED");
            }
            else if (ques1 != "a" || ques1 != "b" || ques1 != "c" || ques1 != "d")
            {
                Console.WriteLine("please type in the expected option");
                break;
            }
            else
            {
                Console.WriteLine("skipped");
            }
            Console.Clear();


            Console.WriteLine(" QUESTION 2: the following are example of software you can use for graphics.Except..");
            List<string> ques2 = new List<string>();

            ques2.Add("(a) Illustrator");
            ques2.Add("(b) Figma");
            ques2.Add("(c) VS Code");
            ques2.Add("(d) Canva");
            ques2.Add("Select any other options to skip question ");

            foreach (var test in ques2)
            {
                Console.WriteLine(test);
            }

            string que = Console.ReadLine();
            if (que == "c")
            {
                total.Add(20);
                Console.WriteLine("you answered correctly");
            }
            else if (que == "b" || que == "a" || que == "d")
            {
                Console.WriteLine("FAILED");
            }
            else if (que != "a" || que != "b" || que != "c" || que != "d")
            {
                Console.WriteLine("please type in the expected option");
                break;
            }
            else
            {
                Console.WriteLine("skipped");
                Console.ReadLine();
            }
            Console.Clear();


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
            string quess = Console.ReadLine();
            if (quess == "a")
            {
                total.Add(20);
                Console.WriteLine("you answered correctly");
            }
            else if (quess == "b" || quess == "c" || quess == "d")
            {
                Console.WriteLine("FAILED");
            }
            else if (quess != "a" || quess != "b" || quess != "c" || quess != "d")
            {
                Console.WriteLine("please type in the expected option");
                break;
            }
            else
            {
                Console.WriteLine("skipped");
            }
            Console.Clear();



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
            string quess1 = Console.ReadLine();
            if (quess1 == "b")
            {
                total.Add(20);
                Console.WriteLine("you answered correctly");
            }
            else if (quess1 == "a" || quess1 == "c" || quess1 == "d")
            {
                Console.WriteLine("FAILED");
            }
            else if (quess1 != "a" || quess1 != "b" || quess1 != "c" || quess1 != "d")
            {
                Console.WriteLine("please type in the expected option");
                break;
            }
            else
            {
                Console.WriteLine("skipped");
            }
            Console.Clear();



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
            string quess2 = Console.ReadLine();
            if (quess2 == "c")
            {
                total.Add(20);
                Console.WriteLine("you answered correctly");
            }
            else if (quess2 == "a" || quess2 == "b" || quess2 == "d")
            {
                Console.WriteLine("FAILED");
            }
            else if (quess2 != "a" || quess2 != "b" || quess2 != "c" || quess2 != "d")
            {
                Console.WriteLine("please type in the expected option");
                break;
            }
            else
            {
                Console.WriteLine("skipped");
                Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("press enter to submit");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("submitted sucessfully");
            Console.WriteLine("press continue to see your performance");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine($"You scored {total.Sum()} points");
            if (total.Sum() == 100)
            {
                Console.WriteLine("U passed excellently u admission is sure!!");
            }
            else if (total.Sum() == 90 || total.Sum() == 80 || total.Sum() == 70 || total.Sum() == 60)
            {
                Console.WriteLine("Passed averagely.. Might be admitted!");
            }
            else
            {
                Console.WriteLine("Poor performance.. Na only God go help u sha");
                break;
            }
    
        }
        else
        {
            Console.WriteLine("AUTHORISATION FAILED");
        }
        
    }
/*    Console.Clear();
*/    Console.WriteLine("Your account have been temporarily disabled ");
    Console.WriteLine("try again in 30 minutes");
    break;
}


/*List<int> total = new List<int>();
Console.WriteLine(" QUESTION 1: An atom consists of how many particles?");
List<string> ques = new List<string>();

ques.Add("(a)3");
ques.Add("(b)4");
ques.Add("(c)6");
ques.Add("(d)7");

foreach (var test in ques)
{
    Console.WriteLine(test);
}

string ques1 = Console.ReadLine();

if (ques1 == "a")
{
    total.Add(20);
    Console.WriteLine("you answered correctly");
}
else if (ques1 == "b" || ques1 == "c" || ques1 == "d")
{
    Console.WriteLine("FAILED");
}
else if (ques1 != "a" || ques1 != "b" || ques1 != "c" || ques1 != "d")
{
    Console.WriteLine("please type in the expected option");
    break;
}
else
{
    Console.WriteLine("skipped");
}
Console.Clear();


Console.WriteLine(" QUESTION 2: the following are example of software you can use for graphics.Except..");
List<string> ques2 = new List<string>();

ques2.Add("(a) Illustrator");
ques2.Add("(b) Figma");
ques2.Add("(c) VS Code");
ques2.Add("(d) Canva");
ques2.Add("Select any other options to skip question ");

foreach (var test in ques2)
{
    Console.WriteLine(test);
}

string que = Console.ReadLine();
if (que == "c")
{
    total.Add(20);
    Console.WriteLine("you answered correctly");
}
else if (que == "b" || que == "a" || que == "d")
{
    Console.WriteLine("FAILED");
}
else if (que != "a" || que != "b" || que != "c" || que != "d")
{
    Console.WriteLine("please type in the expected option");
    break;
}
else
{
    Console.WriteLine("skipped");
    Console.ReadLine();
}
Console.Clear();


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
string quess = Console.ReadLine();
if (quess == "a")
{
    total.Add(20);
    Console.WriteLine("you answered correctly");
}
else if (quess == "b" || quess == "c" || quess == "d")
{
    Console.WriteLine("FAILED");
}
else if (quess != "a" || quess != "b" || quess != "c" || quess != "d")
{
    Console.WriteLine("please type in the expected option");
    break;
}
else
{
    Console.WriteLine("skipped");
}
Console.Clear();



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
string quess1 = Console.ReadLine();
if (quess1 == "b")
{
    total.Add(20);
    Console.WriteLine("you answered correctly");
}
else if (quess1 == "a" || quess1 == "c" || quess1 == "d")
{
    Console.WriteLine("FAILED");
}
else if (quess1 != "a" || quess1 != "b" || quess1 != "c" || quess1 != "d")
{
    Console.WriteLine("please type in the expected option");
    break;
}
else
{
    Console.WriteLine("skipped");
}
Console.Clear();



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
string quess2 = Console.ReadLine();
if (quess2 == "c")
{
    total.Add(20);
    Console.WriteLine("you answered correctly");
}
else if (quess2 == "a" || quess2 == "b" || quess2 == "d")
{
    Console.WriteLine("FAILED");
}
else if (quess2 != "a" || quess2 != "b" || quess2 != "c" || quess2 != "d")
{
    Console.WriteLine("please type in the expected option");
    break;
}
else
{
    Console.WriteLine("skipped");
    Console.ReadLine();
}
Console.Clear();

Console.WriteLine("press enter to submit");
Console.ReadLine();
Console.Clear();

Console.WriteLine("submitted sucessfully");
Console.WriteLine("press continue to see your performance");
Console.ReadLine();
Console.Clear();



Console.WriteLine($"You scored {total.Sum()} points");
if (total.Sum() == 100)
{
    Console.WriteLine("U passed excellently u admission is sure!!");
}
else if (total.Sum() == 90 || total.Sum() ==80 || total.Sum() ==70 || total.Sum() ==60 )
{
    Console.WriteLine("Passed averagely.. Might be admitted!");
}
else
{
    Console.WriteLine("Poor performance.. Na only God go help u sha");
}

break;
}

break;
}*/
/*
else
{
    Console.WriteLine(" Skipped Question");



    Console.WriteLine($"Congratulation,your total score is");

}
break;
}
*/
