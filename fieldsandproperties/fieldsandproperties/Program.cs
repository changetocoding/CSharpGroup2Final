namespace fieldsandproperties
{
     class program
    {
        static void Main (string[] args)
        {
            Car car1 = new Car();
            car1.speedproperty = 5000;
            car1.wheelsproperty = 5;
            car1.color = "black";

            Console.WriteLine(car1.speedproperty);
            Console.WriteLine(car1.wheelsproperty);
            Console.WriteLine(car1.color);


        }
    }
}
