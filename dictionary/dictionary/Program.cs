/*Console.WriteLine("dictionary");


Dictionary<string, string> test = new Dictionary<string, string>();

test.Add("ugbabe", "isaac");
test.Add("ogbu", "isaac");
test.Add("danladi", "john");

foreach (var i in test)

    {
        Console.WriteLine("test: {0} ",test);
    } */

Dictionary<int, string> dict = new Dictionary<int, string>();
/*Dictionary<string, int> dict1 = new Dictionary<string, int>(5);
*/
dict.Add(0, "Sleeping");
dict.Add(1, "Research");
dict.Add(2, "Coding");
dict.Add(3, "Analysis");
dict.Add(4, "Movies");
dict.Add(5, "Night Walks");

Console.WriteLine("WHAT ARE UR HOBBIES??");
Console.ReadLine();

Console.WriteLine("MY HOBBIES ARE ............");
Console.ReadLine();

for (int i = 0; i < dict.Count; i++) 
{
    Console.WriteLine(dict[i]);
}


/*foreach (var item in dict)
{
    Console.WriteLine(item.Value);
}
*/


