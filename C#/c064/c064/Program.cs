using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cList = new List<double>();
            List<string> aList = new List<string>();
            string[] line = Console.ReadLine().Split(' ');
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);
            string[] tmp;
            int ans = 0;

            for ( int i = 0; i < M; i++ )
            {
                cList.Add(double.Parse(Console.ReadLine()));
            }

            for ( int i =0 ; i < cList.Count; i++ )
            {
                cList[i] = cList[i] * 0.01;
            }

            for ( int i =0 ; i < N; i++ )
            {
                aList.Add(Console.ReadLine());
            }

            for ( int i =0 ;i < aList.Count; i++ ) 
            {
                tmp = aList[i].Split(' ');
                for ( int j = 0 ; j < cList.Count; j++)
                {
                    ans += (int)(cList[j] * double.Parse(tmp[j]));
                }
                Console.WriteLine(ans);
                ans = 0;
            }
        }
    }
}
