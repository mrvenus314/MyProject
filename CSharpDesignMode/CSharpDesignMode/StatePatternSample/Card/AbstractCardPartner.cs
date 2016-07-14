using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public abstract class AbstractCardPartner
    {
        public string NickName { get; set; }

        public int Money { get; set; }

        public AbstractCardPartner()
        {
            Money = 0;
        }

        public abstract void ChangeMoney(int money, AbstractMediator mediator);
    }
}
