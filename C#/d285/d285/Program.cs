using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d285
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            if (N % a == 0)
            {
                Console.WriteLine(N / a);
            }
            else
            {
                Console.WriteLine(N / a  + 1);
            }
        }
    }
}
