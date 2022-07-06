// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("enter second number");
string num2 = Console.ReadLine();
//Console.WriteLine("enta num3");//
//string num3 = Console.ReadLine();//

//Console.WriteLine(int.Parse(num1) + int.Parse(num2));//
//int total = (int.Parse(num1) + int.Parse(num2));/


Console.WriteLine (int.Parse(num1) % int.Parse(num2));*/


string num1;
Console.WriteLine("enta a number");
num1 = Console.ReadLine();

if (int.Parse(num1) > 10)
{
    Console.Write("u have done very well");
}

else if (int.Parse(num1) == 0)
    {
    Console.Write("please enter a valid number");
}

else if (int.Parse(num1) == 10 )
{
    Console.WriteLine("u can still do beter");
}

else
{
    Console.WriteLine("try again");
}




