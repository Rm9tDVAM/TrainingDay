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
            if(line >= 30 && line <= 34)
            {
                Console.WriteLine("M");
            }
            else
            {
                Console.WriteLine(line);
            }
        }
    }
}
