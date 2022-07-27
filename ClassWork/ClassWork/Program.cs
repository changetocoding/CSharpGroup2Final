using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqAssignmet
{
    class porgram
    {
        static void Main(string[] args)
        {
            //////                            Console.WriteLine("QUESTON (1)");
            //////Console.WriteLine (" 1 ) WHERE and");//CORRECT
            //////Console.WriteLine(" 2) OFTYPE");//CORRECT

            //////Console.WriteLine();

            //////                            Console.WriteLine("QUESTON (2)");
            //////Console.WriteLine("SELECT and");//CORRECT
            //////Console.WriteLine("SELECTMANY");//CORRECT

            //////Console.WriteLine();

            //////                            Console.WriteLine(" QUESTION (3A)");


            var datasorc = new List<object>() { "isaac", "john", "nathan", 1, 9, 5, 7, 1 };//CORRECT

            //////Console.WriteLine();

            //////                             Console.WriteLine("QUESTION (3B)");
            //////var metodSyntax = datasorc.OfType<string>().ToList();//CORRECT

            //////Console.WriteLine();

            //////                             Console.WriteLine("QUESTION 3C");

            //////var metosSyntax = datasorc.OfType<string>().Where(datasorc => datasorc.Length >= 5).ToList();//CORRECT

            //////Console.WriteLine("..............................................");// QUESTION 4 

            ////////the sorting operator is used to manage data in a particuar order e.g Ascending order or in a descendind oder //CORRECT
            //////// 1. reverse 
            //////// 2. thenby
            //////// 3. orderby
            //////// 4. thenbydescending
            //////// 5. orderbydescending CORRECT
            //////Console.WriteLine("..............................................");
            //////                                Console.WriteLine("QUESTION (5)");
            
            //////var numbers = new List<int>() { 20, 100, 21, 56, 3, 9, 5, 7, 1, 500, 400, 900 };
            ////////                   ASCENDING METHOD
            //////var methodSyntax = numbers.OrderBy(asc => asc).ToList();//CORRECT

            //////foreach (var list in methodSyntax)
            //////{
            //////    Console.WriteLine(list);
            //////}

            ////////             DESCENDING METHOD
            //////var methodsYntax = numbers.Where(nun => nun < 200).OrderByDescending(num => num).ToList();//CORRECT

            //////Console.ReadLine();
            //////foreach (var list in methodsYntax)
            //////{
            //////    Console.WriteLine(list);
            //////}

            //////           Console.WriteLine("..............................................");
            //////                        Console.WriteLine("QUESTION(6)");

            List<Students> students = new List<Students>()
            {
                new Students (){StudentId = 20, StudentName = "Caro", StudentGrade = 100},
                new Students (){StudentId = 2, StudentName = "Abel", StudentGrade = 90},
                new Students (){StudentId = 10, StudentName = "Ben", StudentGrade = 300},
                new Students (){StudentId = 30, StudentName = "Peace", StudentGrade = 200}
            };

            var studntMetod = students.OrderBy(std => std.StudentName).ThenBy(std => std.StudentId).ToList();//CORRECT BUT HALF MARK, LIST WAS NOT COMPLETE

            foreach (var lis in studntMetod)
            {
                Console.WriteLine($"StudentName : {lis.StudentName}, StudentId {lis.StudentId}");
            }

             
            Console.WriteLine("-------------------------------------------------------------");

                                         Console.WriteLine("QUUESTION (7)");

            int[] newnumber ={ 1, 2, 3, 4, 5, 6, 8, 9 ,10 };

            var ArrayMetod = newnumber.Reverse();//CORRECT

            foreach ( var listi in ArrayMetod)
            {
                Console.WriteLine(listi);
            }

            //any 

            var motdsyn = students.Any(li => li.StudentId < 10);

            //all

            var all metod = students.All(students => students.StudentGrade > 10);

            //contains

            var contmetod = datasorc.AsEnumerable().Contains("miracle");

            Console.ReadLine();
        }


    }
} 

