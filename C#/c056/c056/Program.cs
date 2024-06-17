using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int N = int.Parse(line[0]);
            int M = int.Parse(line[1]);
            int a_i = 0;
            int b_i = 0;
            List<string> list = new List<string>();

            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < list.Count; i++)
            {
                line = list[i].Split(' ');
                a_i = int.Parse(line[0]);
                b_i = int.Parse(line[1]);

                if (a_i - ( b_i * 5 ) >= M ) 
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
