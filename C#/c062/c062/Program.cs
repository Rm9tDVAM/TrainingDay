using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            List<string> nlist = new List<string>();
            int ans = 0;

            for (int i = 0; i < T; i++)
            {
                nlist.Add(Console.ReadLine());
            }

            for (int i = 0;i < nlist.Count; i++) 
            {
                if (nlist[i] == "melon")
                {
                    ans++;
                    i += 10;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
