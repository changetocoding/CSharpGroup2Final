namespace LibraryApp
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("                       WELCOME TO Z-LIBRARY");

            Dictionary<string, string> books = new Dictionary<string, string>();

            books.Add("1", "(1) Sleeping");
            books.Add("2", "(2).Research");
            books.Add("3", "(3).Coding");
            books.Add("4", "(4)Analysis");
            books.Add("5", "(5).Movies");
            books.Add("6", "(6).Night Walks");

            Console.WriteLine("What do u want to do?.. BORROW, OR RETURN A BOOK");
            while (true)
                {
                   
                string option = Console.ReadLine();

                if (option == "Borrow")
                {
                    foreach (var list in books)
                    {
                        Console.WriteLine(list.Value);
                    }

                    Console.WriteLine("which book do u want borrow");
                    string answer = Console.ReadLine();
                    if (books.ContainsKey(answer))
                    {
                        Console.WriteLine($"Book {books[answer]} borrowed");
                        books.Remove(answer);
                        Console.WriteLine("wat do u want to do next");
                    }
                    else if (!books.ContainsKey(answer))
                    {
                        Console.WriteLine("choose a book in the list of books available");
                        break;
                    }
                }

                else if (option == "Return")
                {
                    try
                    {
                        Console.WriteLine("how long have u keep the book");
                        string numdays = Console.ReadLine();
                        if (int.Parse(numdays) <= 10)
                        {
                            Console.WriteLine("book returned sucessfully");
                            break;
                        }

                        else if (int.Parse(numdays) >= 11 && int.Parse(numdays) <= 30)
                        {
                            int amount = int.Parse(numdays) - 10;
                            Console.WriteLine($"u owe {amount * 50}");
                        }
                        else if (int.Parse(numdays) > 10 && int.Parse(numdays) == 30)
                        {
                            int amount = int.Parse(numdays) - 10;

                            Console.WriteLine($" u owe {amount * 100}");
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    }
                    catch (FormatException err)
                    {
                        Console.WriteLine(err.Message);
                        break;
                    }
                    finally
                    {
                        Console.WriteLine("Thanks");
                    }
                    
                }    
            }
        }
    }
}

//Console.WriteLine("how long have u keep the book");
//string numdays = Console.ReadLine();
//if (int.Parse(numdays) <=10)
//{
//    Console.WriteLine("book returned sucessfully");
//    break;
//}

//else if (int.Parse(numdays) >= 11 && int.Parse(numdays) <=30)
//{
//    int amount =int.Parse(numdays)- 10;
//    Console.WriteLine($"u owe {amount * 50}");
//} 
//else if (int.Parse(numdays) >10 && int.Parse(numdays) == 30)
//{
//    int amount = int.Parse(numdays) - 10;

//    Console.WriteLine($" u owe {amount *100}");
//}
//break;