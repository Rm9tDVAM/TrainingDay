using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d273
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            M = M += 2;
            if (M > 12) 
            {
                Console.WriteLine(M-12);
            }
            else
            {
                Console.WriteLine(M);
            }
        }
    }
}
