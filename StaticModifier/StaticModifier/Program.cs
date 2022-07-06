namespace StaticModifier
{
    class program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("nissan");
            Car car2 = new Car("dog");
            Car car3 = new Car("qus");

            Console.WriteLine(Car.Carnumber);

            Car.take();
            
       
        }

        
    }
}