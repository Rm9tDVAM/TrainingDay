using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01c87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string rstr = "";
            int temp = 0;
            while (true)
            {
                rstr = ReverseString(str);
                temp = int.Parse(str)+int.Parse(rstr);
                str = temp.ToString();
                if (ReverseCheck(str))
                {
                    break;
                }
            }
            Console.WriteLine(str);
        }
        static Boolean ReverseCheck(string str)
        {
            string temp = ReverseString(str);
            if (str == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string ReverseString(string str)
        {
            string temp = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                temp += str[i];

            }
            return temp;
        }
    }
}
