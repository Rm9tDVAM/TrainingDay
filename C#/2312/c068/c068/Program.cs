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
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            for(int i=0; i<S.Length; i++)
            {
                if(i%2 == 0)
                {
                    if (az.IndexOf(S[i])-(N) < 0)
                    {
                        Console.Write(az[26 + (az.IndexOf(S[i])-(N))]);
                    }
                    else
                    {
                        Console.Write(az[az.IndexOf(S[i])-(N)]);
                    }
                }
                else
                {
                    if (az.IndexOf(S[i])+(N) > 25)
                    {
                        Console.Write(az[(az.IndexOf(S[i])+(N))-26]);
                    }
                    else
                    {
                        Console.Write(az[az.IndexOf(S[i])+(N)]);
                    }
                }
            }
        }
    }
}
