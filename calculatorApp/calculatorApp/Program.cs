// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
     
                        //while loop example//

while (true) {
    string num1;
    string num2;
    string op;

    Console.WriteLine("enter the number");
    num1 = Console.ReadLine();

    Console.WriteLine("the following opperators are accepted +, -, *, /, %, ^");
    op = Console.ReadLine();


    Console.WriteLine("enter another number");
    num2 = Console.ReadLine();


    if (op == "+")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(int.Parse(num1) + int.Parse(num2));
    }


    else if (op == "-")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(int.Parse(num1) - int.Parse(num2));
    }


    else if (op == "*")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(int.Parse(num1) * int.Parse(num2));
    }


    else if (op == "/")
    {
        Console.WriteLine("the result is");
        Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));
    }


    else if (op == "%")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(int.Parse(num1) % int.Parse(num2));
    }


    else if (op == "^")
    {
        Console.WriteLine("the result is");
        Console.WriteLine(Math.Sqrt(int.Parse(num1) + int.Parse(num2)));
    }

    else
    {
        Console.WriteLine("input a value");
    }
}



