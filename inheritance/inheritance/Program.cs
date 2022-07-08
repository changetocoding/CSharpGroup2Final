namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Male Isaac = new Male();
            Female Abigail = new Female();

            Console.WriteLine(Isaac.Bloodgroup);
            Console.WriteLine(Isaac.complexion);
            Console.WriteLine(Isaac.voice);
            Console.WriteLine(" ");
            Console.WriteLine(Abigail.Bloodgroup);
            Console.WriteLine(Abigail.complexion);
            Console.WriteLine(Abigail.LengthOfHair);

        }
    }
}
