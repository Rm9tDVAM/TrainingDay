using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int A = int.Parse(line[0]);
            int B = int.Parse(line[1]);
            if (A >= B)
            {
                Console.Write("No");
            }
            else
            {
                Console.Write("Yes");
            }
        }
    }
}
