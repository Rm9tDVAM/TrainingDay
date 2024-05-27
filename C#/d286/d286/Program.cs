using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d286
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' '); 
            int X = int.Parse(line[0]); 
            int T = int.Parse(line[1]);
            Console.WriteLine(60*T/X);
        }
    }
}
