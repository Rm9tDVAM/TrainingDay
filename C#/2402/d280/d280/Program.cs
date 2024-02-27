using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d280
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int W = int.Parse(line[0]);
            int M = int.Parse(line[1]);
            Console.WriteLine(W/60*M);
        }
    }
}
