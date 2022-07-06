// See https://aka.ms/new-console-template for more information
/*string num;
Console.WriteLine("enter a number");
num = Console.ReadLine();
if (int.Parse(num) > 10)
{
    Console.WriteLine("the number you entered is greater than 10");
}

else if (int.Parse(num) == 2)
{
    Console.WriteLine("the number you entered is 2");
}

else if (int.Parse(num) == 3)
{
    Console.WriteLine("the number you entered is 3");
}

else if (int.Parse(num) == 4)
{
    Console.WriteLine("the number you entered is 4");
}

else
{
    Console.WriteLine("the number you entered is less than 10");
}
*/

//for calculator
string num1;
Console.WriteLine("enter a number");
num1 = Console.ReadLine();

Console.WriteLine("select an operator, these are +,/,-,*");

string op;
op = Console.ReadLine();


string num2;
num2 = Console.ReadLine();

if (op =="+")
{
    Console.WriteLine(int.Parse(num1)+ int.Parse(num2));
}

else if (op == "/")
{
    Console.WriteLine(int.Parse(num1) / int.Parse(num2));
}

else if (op == "-")
{
    Console.WriteLine(int.Parse(num1) - int.Parse(num2));
}

else if (op == "*")
{
    Console.WriteLine(int.Parse(num1) * int.Parse(num2));
  
}

else
{
    Console.WriteLine("input valid operator");
}















