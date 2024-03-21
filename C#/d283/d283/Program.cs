using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int X = int.Parse(line[0]);
            int P = int.Parse(line[1]);
            if (X - P <= 0)
            {
                Console.WriteLine(0);

            }
            else
            {
                Console.WriteLine(X - P);
            }
        }
    }
}
