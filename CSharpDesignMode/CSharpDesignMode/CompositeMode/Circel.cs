using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeMode
{
    public class Circel : Graphics
    {
        public Circel(string name)
            : base(name)
        {

        }

        public override void Draw()
        {
            Console.Write("绘制开始... \n");
            Console.Write("这是1个圆 o \n");
            Console.Write("绘制结束... \n \n");
        }
    }
}
