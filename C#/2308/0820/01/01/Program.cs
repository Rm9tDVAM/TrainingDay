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
            string line2 = Console.ReadLine();
            for(int i = line1 -1 ; i>=0 ; i--)
            {
                Console.Write(line2.Substring(i, 1));
            }
        }
    }
}
