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
            int N = 1;
            //string S = Console.ReadLine();
            string S = "QEPG";
            //string S = "KXKPMQVI";
            //string S = "AA";
            // A=az[0], Z=az[25]
            for(int i=0; i<S.Length; i++)
            {
                if(i%2 == 0)
                {
                    if (az.IndexOf(S[i])-(N) < 0)
                    {
                        /*
                        Console.WriteLine(true);
                        Console.WriteLine(az.IndexOf(S[i])-(N));
                        Console.WriteLine(26 + (az.IndexOf(S[i])-(N)));
                        */
                        Console.WriteLine(az[26 + (az.IndexOf(S[i])-(N))]);
                    }
                    else
                    {
                        /*
                        Console.WriteLine(false);
                        */
                        Console.WriteLine(az[az.IndexOf(S[i])-(N)]);
                    }
                }
                else
                {
                    //Console.WriteLine(az.IndexOf(S[i])+N);
                    if (az.IndexOf(S[i])+(N) > 25)
                    {
                        //Console.WriteLine(true);
                        //Console.WriteLine((az.IndexOf(S[i])+(N))-26);
                        Console.WriteLine(az[(az.IndexOf(S[i])+(N))-26]);
                    }
                    else
                    {
                        //Console.WriteLine(false);
                        Console.WriteLine(az[az.IndexOf(S[i])+(N)]);
                    }
                }
            }
        }
    }
}
