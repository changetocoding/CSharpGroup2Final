using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filesystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\WINDOWS 10 PRO\Downloads";

            string[] directory = Directory.GetFiles(rootPath,"*.jpg");

            string destinationFolder = @"C:\Users\WINDOWS 10 PRO\Downloads\Images\";
            Directory.CreateDirectory(destinationFolder);

            if (Directory.Exists(destinationFolder))
            {
                foreach (string item in directory)
                {
                    if (directory.Length == 0)
                    {
                        Console.WriteLine("No image exist in this folder");
                    }
                    else
                    {
                        foreach (string items in directory)
                        {
                            try
                            {
                                File.Move(items, $"{destinationFolder},{Path.GetFileName(item)}");
                                Console.WriteLine("files succesfully moved");
                            }
                            catch (Exception err)
                            {
                                Console.WriteLine("Image name already exist");
                            }
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("DIR DOES NOT EXIST");
            }

            Console.ReadLine();
        }
    }
}
