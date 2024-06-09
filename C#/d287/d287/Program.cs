using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' '); 
            int A = int.Parse(line[0]);
            int B = (int)(double.Parse(line[1]) - (double.Parse(line[1]) * 0.3));
            if (A < B)
            {
                Console.WriteLine(A);
            }
            else
            {
//test
                Console.WriteLine(B);
            }
        }
    }
}
