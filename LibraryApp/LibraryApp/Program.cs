namespace LibraryApp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                       WELCOME TO Z-LIBRARY");
            Console.WriteLine("             SELECT YOUR INTRESTED BOOK WITH THE BOOK NUMBER!!!");

            Dictionary<string, string> books = new Dictionary<string, string>();

            books.Add("1", "unde the nights");
            books.Add("2", "good days");
            books.Add("3", "happyhour");
            books.Add("4", "the gun men");
            books.Add("5", "home alone");
            books.Add("6", "Night Walker");
            while (true)
            {
                try 
                {
                    Console.WriteLine("What do u want to do?.. BORROW, OR RETURN A BOOK");
                     string option = Console.ReadLine();

                    if (option == "Borrow")
                    {
                        foreach (var list in books)
                        {
                            Console.WriteLine(list);
                        }

                        Console.WriteLine("which book do u want borrow");
                        string answer = Console.ReadLine();
                        if (books.ContainsKey(answer))
                        {
                            Console.WriteLine($"Book {books[answer]} borrowed");
                            books.Remove(answer);
                            Console.WriteLine("wat do u want to do next");
                            Console.WriteLine("Borrow or Return a book");
                        }
                        else if (!books.ContainsKey(answer))
                        {
                            Console.WriteLine("choose a book in the list of books available");

                        }
                    
                        foreach (var list in books)
                        {
                            Console.WriteLine(list);
                        }

                        if (books.Count == 0)
                        {
                            Console.WriteLine("Shelve Emptied");
                            break;
                        }
                    }

                    else if (option == "Return")
                    {
                        Console.WriteLine("How Many Days Did You Keep The Book");
                        string days = Console.ReadLine();

                        int fine = int.Parse(days) - 10;

                        if (int.Parse(days) <= 10)
                        {
                            Console.WriteLine("Enter No On First Page Of book");
                            string no = Console.ReadLine();
                            

                            if (books.ContainsKey(no))
                            {
                                Console.WriteLine($"{books[no]} Successfully Returned");
                                
                            }
                        }
                        else if (int.Parse(days) >= 11 && int.Parse(days) <= 30)
                        {
                            Console.WriteLine("Book Successfully Returned");

                            Console.WriteLine($"A Fine of {fine * 50} Is To Be Paid");
                        }

                        else if (int.Parse(days) >= 31)
                        {
                            Console.WriteLine($"A Fine of {fine * 100} Is To Be Paid");
                        }
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message);
                    break;
                }
                finally
                {
                    Console.WriteLine("Thanks you for using Z-Library");
                }

            }
    
        }
}   }            

