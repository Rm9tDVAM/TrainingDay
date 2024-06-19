using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string G = Console.ReadLine();
            List<string> list = new List<string>();
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(G))
                {
                    Console.WriteLine(list[i]);
                }
                else
                {
                    cnt++;
                }
            }

            if (cnt == N)
            {
                Console.WriteLine("None");
            }
        }
    }
}
