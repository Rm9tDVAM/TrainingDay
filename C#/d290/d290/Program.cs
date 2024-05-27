using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d290
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            if (S.Length <= 10)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(S.Length-10);
            }
        }
    }
}
