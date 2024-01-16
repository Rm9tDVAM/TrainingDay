using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //int N = 4;
            //int N = 19;
            int N = 2;
            //string S = Console.ReadLine();
            //string S = "QEPG";
            //string S = "KXKPMQVI";
            string S = "B";
            // A=65, Z=90
            for(int i=0; i<S.Length; i++)
            {
                if(i%2 == 0)
                {
                    if ( 65 > (int)char.Parse(S.Substring(i,1))-N)
                    {
                        Console.WriteLine( 65 - (int)char.Parse(S.Substring(i,1))-N+1 );

                        //Console.WriteLine(65 - ((int)char.Parse(S.Substring(i,1))-N));
                    }
                    else
                    {
                        //Console.Write((char)((int)char.Parse(S.Substring(i,1))-N));
                    }
                }
                else
                {
                    //Console.Write((char)((int)char.Parse(S.Substring(i,1))+N));
                }
            }
        }
    }
}
