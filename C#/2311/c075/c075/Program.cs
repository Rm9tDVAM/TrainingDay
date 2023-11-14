using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int money = int.Parse(line1[0]);
            int count = int.Parse(line1[1]);
            int point = 0;
            for (int i = 0; i < count; i++)
            {
                int pay = int.Parse(Console.ReadLine());
                if (point >= pay)
                {
                    point -= pay;
                }
                else if(money >= pay){
                    point += pay / 10;
                    money -= pay;
                }
                Console.WriteLine("{0} {1}",money,point);
            }
        }
    }
}
