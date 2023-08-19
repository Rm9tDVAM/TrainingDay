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
            int line1 = int.Parse(Console.ReadLine());
            string line2 = Console.ReadLine();
            for (int i = 0; i < line1; i++)
            {
                Console.WriteLine(line2.Substring(i,1));
            }
        }
    }
}
