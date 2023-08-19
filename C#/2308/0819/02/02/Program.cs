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
            string line = Console.ReadLine();
            if (line == "A")
            {
                Console.WriteLine(10);
            }else if(line == "B")
            {
                Console.WriteLine(11);
            }
            else
            {
                Console.WriteLine(line);
            }
        }
    }
}
