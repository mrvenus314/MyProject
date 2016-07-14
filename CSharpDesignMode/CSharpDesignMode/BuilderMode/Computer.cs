using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderMode
{
    public class Computer
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始装配...");

            foreach (var item in parts)
            {
                Console.WriteLine("组件" + item + "开始装配...");
            }

            Console.WriteLine("电脑完成装配...");
        }
    }
}
