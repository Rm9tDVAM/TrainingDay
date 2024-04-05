using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //・2 ≦ N ≦ 50
            //・各 i(1 ≦ i ≦ N) について、以下をみたす
            //・(b_i の長さ) = 4
            //・b_i は "0" または "1" で構成される文字列である

            int N = int.Parse(Console.ReadLine());
            int tmp = 0;
            List<string> bList = new List<string>();

            for ( int i = 0; i < N; i++)
            {
                bList.Add(Console.ReadLine()) ;
            }

            for( int i = 0; i < 4; i++)
            {
                for( int j = 0; j < bList.Count; j++)
                {
                    tmp += int.Parse(bList[j].Substring(i,1));
                }

                if (tmp % 2 == 0)
                {
                    Console.Write(0);
                }
                else
                {
                    Console.Write(1);
                }
                tmp = 0;
            }
        }
    }
}
