/*static int answer(int num1)
{
    return num1*num1*num1;
}

Console.WriteLine(answer(20));*/





/*static void Metod()
{
    DateTime now = DateTime.Now;
    Console.WriteLine("today is " + (now.ToString("ddddd")) + " the time is " + (now.ToString("hh:mm:tt")) + " And we are in the year " +now.Year+ "");

}

Metod();*/
/*

static int highest (int num1, int num2)
   
{
    int max;
    return num1 + num2;
}
Console.WriteLine(highest.max(20));*/



static int answer (int num1, int num2)
{
    if (num1 > num2)
        return num1;

    else if (num2 > num1)
        return num2;
    else
    {
        return 0;
    }
}

Console.WriteLine(answer(0100,0100));
