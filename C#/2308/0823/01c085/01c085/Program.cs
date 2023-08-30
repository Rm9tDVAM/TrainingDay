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
            int[] line1 = Console.ReadLine().Split(' ').Select(a =>int.Parse(a)).ToArray();
            string line2 = Console.ReadLine();
            var atoz = string.Concat(Enumerable.Range('a', 26).Select(c =>(char)c));
            Hashtable ht=new Hashtable();
            int temp;
            for (int i = 0; i < line1.Length; i++)
            {
                ht.Add(atoz.Substring(i,1), line1[i]);
            }
            for(int i=0;i<line2.Length ; i++)
            {
                if ((int)ht[line2.Substring(i, 1)] != 0)
                {
                    Console.Write(line2.Substring(i,1));
                    ht[line2.Substring(i, 1)] = (int)ht[line2.Substring(i, 1)] - 1;;
                }
            }
        }
    }
}
