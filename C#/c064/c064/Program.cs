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
            //string[] line = Console.ReadLine().Split(' ');
            string[] line = {"3","3"};
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);
            string[] tmp;
            int ans = 0;

            for ( int i = 0; i < M; i++ )
            {
                //cList.Add(double.Parse(Console.ReadLine()));
            }
            cList.Add(250);
            cList.Add(500);
            cList.Add(1000);

            for ( int i =0 ; i < cList.Count; i++ )
            {
                cList[i] = cList[i] * 0.01;
            }

            for ( int i =0 ; i < N; i++ )
            {
                //aList.Add(Console.ReadLine());
            }
            aList.Add("100 200 300");
            aList.Add("30 250 0");
            aList.Add("1 1 1000");

            for ( int i =0 ;i < aList.Count; i++ ) 
            {
                //Console.WriteLine(aList[i]);
                tmp = aList[i].Split(' ');
                for ( int j = 0 ; j < cList.Count; j++)
                {
                    //Console.WriteLine(cList[j]);
                    //Console.WriteLine(tmp[j]);
                    Console.WriteLine(cList[j] * double.Parse(tmp[j]));
                }
            }
        }
    }
}
