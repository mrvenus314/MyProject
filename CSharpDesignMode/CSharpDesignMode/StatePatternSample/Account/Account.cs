using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternModel
{
    public class Account
    {
        public State State { get; set; }

        public string Owner { get; set; }

        public double Balance { get { return State.Balance; } } // 余额

        public Account(string name)
        {
            this.Owner = name;
            State = new SilverState(0.0, this);
        }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount">金额</param>
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Deposit... \n");
            Console.WriteLine("存入:" + amount + "\n");
            Console.WriteLine("余额:" + Balance + "\n");
            Console.WriteLine("账户状态:" + State.GetType().Name + "\n");
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount">金额</param>
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Withdraw... \n");
            Console.WriteLine("取出:" + amount + "\n");
            Console.WriteLine("余额:" + Balance + "\n");
            Console.WriteLine("账户状态:" + State.GetType().Name + "\n");
        }

        /// <summary>
        /// 查看利息
        /// </summary>
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("PayInterest... \n");
            Console.WriteLine("余额:" + Balance + "\n");
            Console.WriteLine("账户状态:" + State.GetType().Name + "\n");
        }

    }
}
