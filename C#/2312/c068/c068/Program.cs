using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> az = new List<char>();
            for(char c= 'A'; c<= 'Z'; c++)
            {
                az.Add (c);
            }
            int N = 2;
            //string S = Console.ReadLine();
            //string S = "QEPG";
            //string S = "KXKPMQVI";
            string S = "C";
            // A=az[0], Z=az[25]
            for(int i=0; i<S.Length; i++)
            {
                if(i%2 == 0)
                {
                    if (az.IndexOf(S[i])-(N-1) < 0)
                    {
                        Console.WriteLine(az.IndexOf(S[i])-(N-1));
                    }
                    else
                    {
                        Console.WriteLine(az.IndexOf(S[i])-(N-1));
                    }
                }
                else
                {
                }
            }
        }
    }
}
