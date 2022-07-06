namespace carclass
{
    class Program
    {
        static void Main(string[] args)

        {
            Car car1 = new Car();
            car1.color = "blue";
            car1.brandname = "lexus";
            car1.model = "lexus360";
            car1.speedlimit = 250;


            Car car2 = new Car("Red", "Toyota", "Corrola", 350);
            Console.WriteLine(car1.model);
        }
    }
}