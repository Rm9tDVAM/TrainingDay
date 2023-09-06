using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_c083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            int max = 0;
            int temp = 0;

            for(int i = 0; i < int.Parse(line[0]); i++)
            {
                list.Add(int.Parse(Console.ReadLine()) / int.Parse(line[1]));
            }
            max = list.Max();

            for(int i = 0; i < list.Count; i ++)
            {
                temp = list[i];
                Console.Write(i+1 + ":");
                for (int j = 0; j < max; j++)
                {
                    if (temp > 0)
                    {
                        Console.Write("*");
                        temp--;
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
