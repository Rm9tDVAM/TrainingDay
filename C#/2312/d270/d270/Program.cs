using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d270
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line=Console.ReadLine().Split(' ');
            int A = int.Parse(line[0]);
            int W = int.Parse(line[1]);
            if (A <= 15 && W >= 60)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
