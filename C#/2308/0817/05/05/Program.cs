using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Console.WriteLine(line.Substring(0,1) + line.Substring(line.Length-1) );
        }
    }
}
