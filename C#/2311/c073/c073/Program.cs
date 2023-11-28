using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            string[] uab=Console.ReadLine().Split(' ');
            int u = int.Parse(uab[0]);
            int a = int.Parse(uab[1]);
            int b = int.Parse(uab[2]);
            int v = int.Parse(Console.ReadLine());
            int usagi = 0;
            if (L % a == 0)
            {
                usagi = (u * L) + (L / a * b) -b;
            }
            else
            {
                usagi = (u * L) + (L / a * b);
            }
            int kame = v * L;
            if (usagi > kame)
            {
                Console.WriteLine("KAME");
            }
            else if(usagi < kame)
            {
                Console.WriteLine("USAGI");
            }
            else
            {
                Console.WriteLine("DRAW");
            }
        }
    }
}
