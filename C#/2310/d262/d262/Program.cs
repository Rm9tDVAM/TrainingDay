using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d262
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            if(line1.Length == line2.Length)
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
