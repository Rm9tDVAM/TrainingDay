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
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = { "6","8","6" };
            int count = int.Parse(line[0]);
            int length = int.Parse(line[2]);
            string tmp="";
            string[] temp = { "My#name#","is#paiza",".#I#like","#program","ming#ver","y#ch.#" };
            for (int i = 0; i < count; i++)
            {
                //tmp = tmp + Console.ReadLine();
                tmp = tmp + temp[i];
            }
            for (int i = 0; i < tmp.Length; i += int.Parse(line[2]) ) 
            {
                //Console.WriteLine("{0},{1}",i,tmp.Length);
                //Console.WriteLine(tmp.Substring(i, int.Parse(line[2])));
                //Console.WriteLine(tmp.Substring(i, tmp.Length));
                Console.WriteLine(tmp.Substring(i,1));
            }
        }
    }
}
