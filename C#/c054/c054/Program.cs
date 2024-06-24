using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            List<string> list = new List<string>();
            int N = int.Parse(line[0]);
            int V = int.Parse(line[1]);
            int t_i = 0;
            int p_i = 0;
            int t_itmp = 0;
            int p_itmp = 0;
            int sum = 0;
            bool ans = false;

            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < list.Count-1; i++)
            {
                line = list[i].Split(' ');
                t_i = int.Parse(line[0]);
                p_i = int.Parse(line[1]);
                line = list[i+1].Split(' ');
                t_itmp = int.Parse(line[0]);
                p_itmp = int.Parse(line[1]);
                sum = (p_itmp - p_i) / (t_itmp - t_i);
                if (sum > V)
                {
                    ans = true;
                }
            }

            if (ans) 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
