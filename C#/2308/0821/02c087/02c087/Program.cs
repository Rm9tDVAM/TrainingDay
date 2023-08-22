using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02c087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string rLine = Reverse(line);
            int ans = int.Parse(line) + int.Parse(rLine);
            if (CheckReverse(ans.ToString()))
            {
                Console.WriteLine(ans);
            }
            else
            {
                line = ans.ToString();
                rLine = Reverse(line);
                ans = int.Parse(line) + int.Parse(rLine);
                Console.WriteLine(ans);
            }
        }
        static Boolean CheckReverse(string ans)
        {
            string temp = Reverse(ans);
            if (ans == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string Reverse(string line)
        {
            string temp = "";
            for(int i = line.Length -1; 0 <= i ; i--)
            {
                temp += line.Substring(i,1);
            }
            return temp;
        }
    }
}
