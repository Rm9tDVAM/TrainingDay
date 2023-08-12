using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;
            int ans1 = calc.add(a, b);
            int ans2 = calc.add(a, b, c);
            Console.WriteLine("{0} + {1} = {2}",a,b,ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, ans2);
        }
    }
}
