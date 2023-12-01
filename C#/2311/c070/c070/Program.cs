using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line =int.Parse(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                string line2=Console.ReadLine();
                if(4==line2.Count(f => (f == char.Parse(line2.Substring(0, 1)))))
                {
                    Console.WriteLine("Four Card");
                }
                for (int j=0;j<line2.Length; j++)
                {
                }

            }
        }
    }
}
