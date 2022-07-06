namespace classworkproperties
{
    class program
    {
        static void Main (string[] args)
        {
            Human human1 = new Human();
            human1.legproperty = 1;
            human1.eyeproperty = 2;
            human1.teethpropetry = 9;

            Console.WriteLine(human1.legproperty);
            Console.WriteLine(human1.eyeproperty);
            Console.WriteLine(human1.teethpropetry);

        }
    }
}
