using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            int N = 3;
            int ans = 0;
            List<string> list = new List<string>();
            for ( int i = 0; i < N; i++ )
            {
                //list.Add(Console.ReadLine());
            }
            list.Add("> 30");
            list.Add("< 40");
            list.Add("/ 5");
            for ( int i = 1;i < 100; i++)
            {
                foreach ( string s in list)
                {
                if (s.IndexOf(">") != -1 )
                    {

                    }

                }
            }
        }
    }
}
