using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int N = int.Parse(line[0]);
            int V = int.Parse(line[1]);
            int t_i = 0;
            int p_i = 0;

            for (int i = 0; i < N; i++)
            {
                line = Console.ReadLine().Split(' ');
                t_i = int.Parse(line[0]);
                p_i = int.Parse(line[1]);
            }
        }
    }
}
