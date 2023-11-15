using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            string[] temp = { "My#name#","is#paiza",".#I#like","#program","ming#ver","y#much.#" };
            for (int i = 0; i < count; i++)
            {
                //tmp = tmp + Console.ReadLine();
                tmp = tmp + temp[i];
            }
            for(int i = 0;i < tmp.Length; i + int.Parse(line[2]))
            {
            }
        }
    }
}
