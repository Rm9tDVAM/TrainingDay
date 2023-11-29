using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d269
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();  
            for(int i=0;i<line.Length; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(line[i]);
                }
            }
        }
    }
}
