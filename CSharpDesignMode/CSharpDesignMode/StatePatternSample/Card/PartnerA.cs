using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public class PartnerA : AbstractCardPartner
    {
        public PartnerA(string nickName,int money)
        {
            this.NickName = nickName;
            this.Money = money;
        }

        public override void ChangeMoney(int money, AbstractMediator mediator)
        {
            mediator.ChangeMoney(money);
        }
    }
}
