using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class SingletonMode
    {
        // 定义一个静态变量来保存类的实例
        private static SingletonMode uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        // 定义私有构造函数，使外界不能创建该类实例
        private SingletonMode()
        {
        }

        public static SingletonMode GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new SingletonMode();
                }
            }
            return uniqueInstance;
        }


    }
}
