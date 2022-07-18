using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class program
    {
        static void Main (string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student("Isaac",  "Ogah", "JSS1", 48.5),
                new Student("Jane",   "John",  "JSS2", 50.5),
                new Student("Miracle","Ogoh",  "SSS1", 60.5),
                new Student("Ann",     "Okpe", "JSS1", 78.5),
                new Student("Joy",     "Onah", "JSS3", 55.68),
                new Student("Peter",   "Simon", "SSS2", 33.5),
                new Student("Ajeibi",   "Caro", "KG1",  33.5),
                new Student("Esther",   "anthony", "KG1",  33.5),
                new Student("Ajeibi",   "Caro", "KG1",  33.5)
            };

            var querysyntax = (from name in student
                               orderby name.CurrentClass
                               select name).ToList();

            foreach(var item in querysyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //var Querysyntax = from led in student
            //                  where led.ResultAverage >= 50 && led.CurrentClass == "JSS1"
            //                  select led;

            


            //foreach (var pass in Querysyntax)
            //{
                
            //    Console.WriteLine($"FirstName: {pass.FirstName}, SurName: {pass.SurName}, Class: {pass.CurrentClass}, Average: {pass.ResultAverage}");
            //}

            //Console.WriteLine("..................................");

            //var methodSyntax = student.Where(led => led.ResultAverage >= 48.5 && led.CurrentClass =="KG1");

            //foreach (var pass in methodSyntax)
            //{
            //    Console.WriteLine($"FirstName: {pass.FirstName}, SurName: {pass.SurName}, Class: {pass.CurrentClass}, Average: {pass.ResultAverage}");
            //}

            //Console.WriteLine("..................................");

            //var mixedSyntax = (from led in student
            //                  select led.ResultAverage).Max();

            //Console.WriteLine($"Average{mixedSyntax}");
        }

    }
}