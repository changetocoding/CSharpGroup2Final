// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter first number");
string num1 = Console.ReadLine();
Console.WriteLine("enter second number");
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

Console.WriteLine(int.Parse(num1) + int.Parse(num2));
int total = (int.Parse(num1) + int.Parse(num2));


Console.WriteLine($" answer is { total * int.Parse(num3)}");