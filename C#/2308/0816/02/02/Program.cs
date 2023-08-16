using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line1 = int.Parse(Console.ReadLine());
            int line2 = int.Parse(Console.ReadLine());
            int ans = line2 - line1;
            if (ans > 0)
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
