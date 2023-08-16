using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line1 = int.Parse(Console.ReadLine());
            int line2 = int.Parse(Console.ReadLine());
            if (line1 + line2 == 21)
            {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine(line1 + line2);
            }
        }
    }
}
