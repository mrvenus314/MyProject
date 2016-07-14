using System;

namespace StatePatternModel
{
    public class GoldState : State
    {

        public GoldState(State state)
        {
            Balance = state.Balance;
            Account = state.Account;
            Interest = 0.05;
            LowerLimit = 1000.00;
            UpperLimit = 1000000.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.State = new SilverState(this);
            }
            else if (Balance < 0.0)
            {
                Account.State = new RedState(this);
            }
        }
    }
}