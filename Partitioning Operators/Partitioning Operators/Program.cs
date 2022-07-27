using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Partitioning_Operators
{
    class program
    {
        static void Main(String[] args)
        {
            int[] num=new int[] {1,2,3,4,5,6,7,8,9,10};
            var ms = num.Take(6).ToArray();
            var qs = (from nu in num
                      select nu).Take(5).ToList();



            Console.ReadLine();
        }
    }
}