using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx302
{
    class Sub:Super
    {
        public Sub()
        {
            Console.WriteLine("Subのコンストラクタ(引数なし");
        }
        public Sub(int param) : base(param)
        {
            Console.WriteLine("Subのコンストラクタ(引数:param={0}", param);
        }
        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}
