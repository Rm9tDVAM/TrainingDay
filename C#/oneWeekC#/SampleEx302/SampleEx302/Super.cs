using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx302
{
    class Super
    {
        private int param = 0;
        public Super()
        {
            Console.WriteLine("Superクラスのコンストラクタ(引数なし)");
        }
        public Super(int param)
        {
            Console.WriteLine("Superクラスのコンストラクタ(引数:param={0}", param);
            this.param = param;
        }
        ~Super()
        {
            Console.WriteLine("Superクラスのデストラクタ");
        }
        public void ShowParam()
        {
            Console.WriteLine("param={0}", param);
        }
    }
}
