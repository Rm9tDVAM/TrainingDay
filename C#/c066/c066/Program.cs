using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ≦ M ≦ 50
            //1 ≦ N ≦ 10
            //1 ≦ x ≦ 100
            //1 ≦ w_i ≦ 25(1 ≦ i ≦ M)
            string[] line = Console.ReadLine().Split(' ');
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1])-1;
            int x = int.Parse(line[2]);
            int tmp = x;
            int w = 0;
            int cnt = 0;
            List<int> wArray = new List<int>();

            for (int i = 0 ; i < M ; i++)
            {
                wArray.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0 ; i < wArray.Count ; i++)
            {
                w = wArray[i];
                if ( x - w > 0)
                {
                    x -= w; cnt++;
                }
                else
                {
                    if ( N == 0)
                    {
                        break;
                    }
                    else
                    {
                        N--;
                        x = tmp; i--;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
