using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D288
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ( n <= 10)
            {
                Console.WriteLine("low");
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
