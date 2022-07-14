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