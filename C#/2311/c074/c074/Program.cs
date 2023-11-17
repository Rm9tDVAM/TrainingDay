using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int count = int.Parse(line[0]);
            int length = int.Parse(line[2]);
            string tmp="";
            for (int i = 0; i < count; i++)
            {
                tmp = tmp + Console.ReadLine();
            }
            for (int i = 0; i < tmp.Length; i += int.Parse(line[2]) ) 
            {
                if (i + int.Parse(line[2]) > tmp.Length)
                {
                    Console.WriteLine(tmp.Substring(i, tmp.Length-i));
                }
                else
                {
                    Console.WriteLine(tmp.Substring(i, int.Parse(line[2])));
                }
            }
        }
    }
}
