using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int L = int.Parse(Console.ReadLine());
            int L = 6;
            /*string[] uab=Console.ReadLine().Split(' ');
            int u = int.Parse(uab[0]);
            int a = int.Parse(uab[1]);
            int b = int.Parse(uab[2]);
            */
            int u = 2;
            int a = 2;
            int b = 5;
            //int v = int.Parse(Console.ReadLine());
            int v = 4;
            int usagi = (u*L)+(L/a*5);
            int kame = v * L;
            Console.WriteLine("{0},{1}",usagi,kame);
            if (usagi > kame)
            {
                Console.WriteLine("KAMEA");
            }
            else
            {
                Console.WriteLine("USAGI");
            }
        }
    }
}
