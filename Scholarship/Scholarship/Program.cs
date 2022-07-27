using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                               WELCOME TO THE SCHOLARSHIP INTERVIEWER, PLEASE KINDLY CHOOSE FROM THE OPTION BELOW\n\n\n");
            Console.WriteLine("ENTER [1] TO APPLY FOR SCHOLARSHIP ONLY");
            Console.WriteLine("ENTER [2] TO APPLY FOR SCHOLARSHIP AND A PART TIME JOB");
            Console.WriteLine("ENTER [3] TO APPLY FOR SCHOLARSHIP AND A FULL TIME JOB");

            string option = Console.ReadLine();
            if(option== "1")
            {
                Console.WriteLine("KINDLY INPUT YOUR NATIONALITY\n\n");
                string nat = Console.ReadLine();
                Console.WriteLine("DATE OF BIRTH:\n\n");
                string birth =Console.ReadLine();

                Console.WriteLine("GENDER:");
                string gen= Console.ReadLine();
                Console.WriteLine("MAKE A CHOICE OF EDUCATIONAL INSTITUTION");
                Console.WriteLine("1: CAMBRIDGE UNIVERSITY");
                Console.WriteLine("2. MANCHESTER INSTITUTION FOR LEARNING");
                Console.WriteLine("3. LIVING STONE UNIVERSITY");
                string uni = Console.ReadLine();
                if (uni == "1")
                {
                    Console.WriteLine("THE UNIVERSITY IS NO LONGER AVAILABLE FOR SELECTION");
                }
                else if (uni == "2")
                {
                     
                    
                        Console.WriteLine("KINDLY SELECT A COURSE OF STUDY");
                        Console.WriteLine("1. MEDICINE");
                        Console.WriteLine("2. LAW");
                        Console.WriteLine("3. ENGINEERING");
                        string study = Console.ReadLine();
                        if (study == "1")
                        {
                           
                                Console.WriteLine("INPUT YOUR SCHOLARSHIP EXAMINATION SCORE");
                                string score = Console.ReadLine();

                                if (int.Parse(score) >= 290)
                                {
                                    Console.WriteLine("YOU ARE ELIGIBLE FOR THE SCHOLARSHIP");
                                }
                                else
                                {
                                    Console.WriteLine("YOU ARE NOT ELIGIBLE FOR THE SCHOLARSHIP, TRY AGAIN NEXT TIME");
                                }

                         

                        }
                        else if (study == "2")
                        {
                            Console.WriteLine("INPUT YOUR SCHOLARSHIP EXAMINATION SCORE");
                            string score = Console.ReadLine();

                            if (int.Parse(score) >= 270)
                            {
                                Console.WriteLine("YOU ARE ELIGIBLE FOR THE SCHOLARSHIP");
                            }
                            else
                            {
                                Console.WriteLine("YOU ARE NOT ELIGIBLE FOR THE SCHOLARSHIP, TRY AGAIN NEXT TIME");
                            }
                        }
                        else if (study == "3")
                        {
                            Console.WriteLine("INPUT YOUR SCHOLARSHIP EXAMINATION SCORE");
                            string score = Console.ReadLine();

                            if (int.Parse(score) >= 250)
                            {
                                Console.WriteLine("YOU ARE ELIGIBLE FOR THE SCHOLARSHIP");
                            }
                            else
                            {
                                Console.WriteLine("YOU ARE NOT ELIGIBLE FOR THE SCHOLARSHIP, TRY AGAIN NEXT TIME");
                            }
                        }
                        else
                        {
                            Console.WriteLine("PLEASE ENTER YOUR JAMB SCORE");
                        }

                    }
                   
                }






            





        }
    }
}
