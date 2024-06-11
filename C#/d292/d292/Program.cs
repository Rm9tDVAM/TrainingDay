using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d292
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 7; i++) { 
                if ( Console.ReadLine() == "Rain")
                {
                    count++;
                }
            }
            if ( count >= 4 )
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
