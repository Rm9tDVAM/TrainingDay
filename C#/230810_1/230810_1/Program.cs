using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230810_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line=Console.ReadLine();
            if (1200 <= int.Parse(line))
            {
                Console.WriteLine(int.Parse(line)+3);
            }
            else
            {
                Console.WriteLine(int.Parse(line));
            }
        }
    }
}
