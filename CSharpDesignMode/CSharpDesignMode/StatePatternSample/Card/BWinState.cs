using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public class BWinState : GameState
    {
        public BWinState(AbstractMediator concretemediator)
        {
            this.mediator = concretemediator;
        }

        public override void ChangeMoney(int money)
        {
            foreach (AbstractCardPartner p in mediator.list)
            {
                PartnerB b = p as PartnerB;
                //如果对象是PartnerB，则说明PartnerB赢钱;其他对象减钱
                if (b != null)                    
                    b.Money += money;
                else
                    p.Money -= money;
            }
        }
    }
}
