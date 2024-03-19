using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ≦ N ≦ 10
            // o_i は半角記号で ">", "<", "/" のいずれか
            // 1 ≦ x_i ≦ 100 
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            List<string> list = new List<string>();
            for ( int i = 0; i < N; i++ )
            {
                list.Add(Console.ReadLine());
            }
            for ( int i = 1;i < 100; i++)
            {
                for ( int j = 0;j<list.Count; j++)
                {
                    if (list[j].IndexOf(">") != -1 )
                    {
                        if ( i > int.Parse(list[j].Substring(list[j].IndexOf(" ") + 1)))
                        {
                            cnt++;
                        }
                    }
                    else if (list[j].IndexOf("<") != -1 )
                    {
                        if ( i < int.Parse(list[j].Substring(list[j].IndexOf(" ") + 1)))
                        {
                            cnt++;
                        }
                    }
                    else if (list[j].IndexOf("/") != -1 )
                    {
                        if ( i % int.Parse(list[j].Substring(list[j].IndexOf(" ") + 1)) == 0 )
                        {
                            cnt++;
                        }
                    }
                    if ( j == list.Count - 1)
                    {
                        if ( list.Count == cnt)
                        {
                            Console.WriteLine(i);
                            Environment.Exit(0);
                        }
                        cnt = 0;
                    }
                }
            }
        }
    }
}
