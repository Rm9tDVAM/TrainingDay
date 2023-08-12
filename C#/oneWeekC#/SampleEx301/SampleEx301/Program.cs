using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx301
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.Num1 = 10;
            c1.Num2 = 3;
            c1.add();
            c1.sub();
            ExCalculatro c2 = new ExCalculatro();
            c2.Num1 = 10;
            c2.Num2 = 3;
            c2.add();
            c2.sub();
            c2.mul();
            c2.div();
        }
    }
}
