using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            if (line >= 1000)
            {
                Console.WriteLine(line / 10);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
