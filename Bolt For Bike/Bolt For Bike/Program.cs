Dictionary<string, string> database = new Dictionary<string, string>();
Dictionary<string, string> name1 = new Dictionary<string, string>();
Dictionary<string, string> username1 = new Dictionary<string, string>();
Dictionary<string, string> Address = new Dictionary<string, string>();
Dictionary<string, string> Age = new Dictionary<string, string>();
Dictionary<string, string> Nin = new Dictionary<string, string>();


while (true)
{
    Console.WriteLine("What Do You Want To Do...1.Signup ,2.View");
    string do1 = Console.ReadLine();
    if (do1 == "1") 
    {
        Console.WriteLine("What Category Do You Want To Signup To?... 1.Provider ,2.Reciever ");
        string signup = Console.ReadLine();
        if (signup == "1")
        {
            Console.WriteLine("Kindly Fill The Form Below");
            Console.WriteLine("Your Full Name");
            string name = Console.ReadLine();
            name1.Add("1", name);

            Console.WriteLine("Preferred Username");
            string username = Console.ReadLine();


            Console.WriteLine("Address");
            string address = Console.ReadLine();

            Console.WriteLine("Age");
            string age = Console.ReadLine();

            Console.WriteLine("Nin Number for Verification");
            string nin = Console.ReadLine();
           




        }
    }






}