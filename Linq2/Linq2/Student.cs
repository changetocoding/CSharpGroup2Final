using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string CurrentClass { get; set; }
        public double ResultAverage { get; set; }


        public Student(string FirstN, string SurN, string CurCls, double ResultAv)
        {
            FirstName = FirstN;
            SurName = SurN;
            CurrentClass = CurCls;
            ResultAverage = ResultAv;
        }

    }
}
