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
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = {"5","2","10" };
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1])-1;
            int x = int.Parse(line[2]);
            int w = 0;
            int cnt = 0;
            int[] line2 = {5,5,3,1,4};
            for (int i = 0 ; i < M ; i++)
            {
                //w = int.Parse(Console.ReadLine());
                w = line2[i];
                if ( x - w >= 1)
                {
                    x -= w; cnt++;
                }
                else
                {

                }
            }
        }
    }
}
