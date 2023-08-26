using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c085
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] line1 = Console.ReadLine().Split(' ');
            string line = "1 3 2 6 3 5 5 6 2 6 0 4 5 2 4 2 1 2 4 0 4 2 2 5 0 2";
            string[] line1 = line.Split(' ');
            // string line2 = Console.ReadLine();
            var atoz = string.Concat(Enumerable.Range('a', 26).Select(c =>(char)c));
            Hashtable ht=new Hashtable();
            for (int i = 0; i < line1.Length; i++)
            {
                ht.Add(atoz.Substring(i,1), line1[i]);
            }
            for (int i=0;i<line1.Length; i++)
            {
                Console.WriteLine(ht[atoz.Substring(i,1)]);
            }
        }
    }
}
