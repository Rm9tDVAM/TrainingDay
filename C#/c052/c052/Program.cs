using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //・1 ≦ H, W ≦ 10,000
            //・-H ≦ dy ≦ H
            //・-W ≦ dx ≦ W
            string[] line = Console.ReadLine().Split(' ');
            int H = int.Parse(line[0]);
            int W = int.Parse(line[1]);
            line = Console.ReadLine().Split(' ');
            int dy = int.Parse(line[0]);
            int dx = int.Parse(line[1]);

            Console.WriteLine(H * dy);
            Console.WriteLine(W * dx);
            Console.WriteLine(H * dy + W * dx);
            Console.WriteLine(dy * dx);
            Console.WriteLine(H * dy + W * dx - dy * dx);
        }
    }
}
