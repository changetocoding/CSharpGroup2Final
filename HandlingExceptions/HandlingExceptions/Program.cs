
try
{
    Console.WriteLine("first number");
    string num1 = Console.ReadLine();

    Console.WriteLine("second nnumber");
    string num2 = Console.ReadLine();

    Console.WriteLine((decimal)(int.Parse(num1) * (decimal)(int.Parse(num2))));

}
catch (FormatException error)
{
    Console.WriteLine(error.Message);
}
catch (DivideByZeroException err)
{
    Console.WriteLine(err.Message);
}
catch (Exception no)
{
    Console.WriteLine(no);
}
finally
{
    Console.WriteLine("thank u");
}