using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int add = 0;
            if ( M % 30 > 0)
            {
                add++;
            }
            Console.WriteLine(X*((M/30)+add));
        }
    }
}
