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
            List<double> aList = new List<double>();
            string[] line = Console.ReadLine().Split(' ');
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);
            int Ans = 0;

            for ( int i = 0; i < M; i++ )
            {
                cList.Add(double.Parse(Console.ReadLine()));
            }

            for ( int i =0 ; i < N; i++ )
            {
                aList.Add(double.Parse(Console.ReadLine()));
            }

            for ( int i =0 ;i < aList.Count; i++ ) 
            {
                for ( int j = 0 ; j < cList.Count; j++)
                {

                }
            }
        }
    }
}
