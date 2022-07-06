// See https://aka.ms/new-console-template for more information
Console.WriteLine("num1");
string num1 = Console.ReadLine();

Console.WriteLine("plus");
string num2 = Console.ReadLine();
Console.WriteLine(int.Parse(num1) + int.Parse(num2));


Console.WriteLine("multiply");
string num3 = Console.ReadLine();
int total1 = int.Parse(num1) + int.Parse(num2);
Console.WriteLine(total1 * int.Parse(num3));


Console.WriteLine("subtract");
string num4 = Console.ReadLine();
int total2 = total1 * int.Parse(num3);
Console.WriteLine(total2 - int.Parse(num4));


Console.WriteLine("divide");
string num5 = Console.ReadLine();
int total3 = total2 - int.Parse(num4);
Console.WriteLine(total3 / int.Parse(num5));


Console.WriteLine("modulo");
string num6 = Console.ReadLine();
int total4 = total3 - int.Parse(num4);
Console.WriteLine(total3 % int.Parse(num6));












