using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02c087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            ArrayList array = new ArrayList();
            for (int i = line.Length -1 ; i >= 0; i--)
            {
                array.Add(i);
            }
        }
    }
}
