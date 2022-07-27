namespace LIBRARYAPP2
{
    class program
    {
        static void Main(string[] args)
        {
            List<Library> books = new List<Library>();
            {
                books.Add(new Library("1", "hom alone"));
                books.Add(new Library("2", "bad lands"));
            }

            foreach (var list in books)
            {
                ScrambleWord(list);
                //Console.WriteLine(list);
            }

            static void ScrambleWord(Library books)
            {
                Console.WriteLine(books.Secondbook);
                Console.WriteLine("Unscramble the Above Scrambled Word: ");

            }
        }
    }
}



//                else if (option == "Return")
//                {
//                    try
//                    {
//                        Console.WriteLine("how long have u keep the book");
//                        string numdays = Console.ReadLine();
//                        if (int.Parse(numdays) <= 10)
//                        {

//                            Console.WriteLine("enter first book number");
//                            string no = Console.ReadLine();
//                            Console.WriteLine("enter  book name");
//                            string name = Console.ReadLine();

//                            if (books.ContainsKey(no))
//                            {ser

//                                Console.WriteLine($"{books[no]} Successfully Returned");
//                                //books.Add(no, name);
//                            }
//                            //Console.WriteLine("book returned sucessfully");
//                            //break;
//                        }

//                        else if (int.Parse(numdays) >= 11 && int.Parse(numdays) <= 30)
//                        {
//                            int amount = int.Parse(numdays) - 10;
//                            Console.WriteLine($"u owe {amount * 50}");
//                        }
//                        else if (int.Parse(numdays) > 10 && int.Parse(numdays) == 30)
//                        {
//                            int amount = int.Parse(numdays) - 10;

//                            Console.WriteLine($" u owe {amount * 100}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("invalid input");
//                        }

//                    }
//                    catch (FormatException err)
//                    {
//                        Console.WriteLine(err.Message);
//                        break;
//                    }
//                    finally
//                    {
//                        Console.WriteLine("Thanks");
//                    }







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