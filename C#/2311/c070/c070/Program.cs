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
            int pairCount = 0;
            for (int i = 0; i < line; i++)
            {
                string line2=Console.ReadLine();
                if (4 == line2.Count(f => (f == char.Parse(line2.Substring(0, 1)))))
                {
                    Console.WriteLine("Four Card");
                }
                else if (3 == line2.Count(f => (f == char.Parse(line2.Substring(0, 1))))||
                         3 == line2.Count(f => (f == char.Parse(line2.Substring(1, 1))))) 
                {
                    Console.WriteLine("Three Card");
                }
                for (int j=0;j<line2.Length; j++)
                {
                    if (2 == line2.Count(f => (f == char.Parse(line2.Substring(i, 1)))))
                    {
                        pairCount++;
                    }
                }
                if ( pairCount == 4 )
                {
                    Console.WriteLine("Two Pair");
                }
                else if( pairCount == 2 )
                {
                    Console.WriteLine("One Pair");
                }
                else
                {
                    Console.WriteLine("No Pair");
                }
            }
        }
    }
}
