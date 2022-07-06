//// See https://aka.ms/new-console-template for more information

///*Console.WriteLine("NAMES OF FOOD !!");
//string[] food = new string [4] { "Beans", "Rice", "swallow","noodles"};

//foreach(string a in food)
//{
//    Console.WriteLine(a);
//}*/
///*
////List<string> foods = new List<string>();
////foods.Add("rice");
////foods.Add("beans");
////foods.Ad
//d("swallow");
////foods.Add("noodles");
////foods.Add("fish");
////foods.Remove("rice");
////foods.Insert(3, "bonemeal");

////foreach (string i in foods)
////{
////    Console.WriteLine(i);
////}*/
////create a list of your favorite car

//List<string> cars = new List<string>();



//cars.Add("Benz 360");
//cars.Add("Ferrari");
//cars.Add("Golf");
//cars.Add("Toyota camry");
//cars.Insert(0, "samuel best car is");
//cars.Insert(2, "patrick best car is");
//cars.Insert(4, "isaac best car is");
//cars.Insert(6, "esther best car is");

//foreach (string a in cars)
//{
//    Console.WriteLine(a);

//}

List<string> cars = new List<string>();
cars.Add("Benz 360");
cars.Add("Ferrari");
cars.Add("Golf");
cars.Add("Toyota camry");

foreach (string a in cars)
{
    if (a  == "Benz 360")
    {
        Console.WriteLine("samuels best car is " + cars[0]);
    }

    else if (a == "Ferrari")
    {
        Console.WriteLine("patricks best car is " + cars[1]);
    }

    else if (a == "Golf")
    {
        Console.WriteLine("Isaacs best car is " + cars[2]);
    }

    else if (a == "Toyota camry")
    {
        Console.WriteLine("Esthers best car is " + cars[3]);
    }

}




