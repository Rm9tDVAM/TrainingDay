using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int M = int.Parse(line[0]); // 1<= M <=30
            int N = int.Parse(line[1]); // 1<= N <=30
            int num = 0;
            int ans = 0;
            for(int i = 1; i < M; i++)
            {
                for(int j = 1; j < N; j++) { 
                    if(!(i == j))
                    {
                        num = (i*i) + (j*j);
                        for(int k = 1; k < num; k++)
                        {
                            if (k * k == num)
                            {
                                ans++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
