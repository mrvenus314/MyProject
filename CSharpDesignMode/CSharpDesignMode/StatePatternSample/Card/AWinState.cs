using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public class AWinState : GameState
    {
        public AWinState(AbstractMediator concretemediator)
        {
            this.mediator = concretemediator;
        }

        public override void ChangeMoney(int money)
        {
            foreach (AbstractCardPartner p in mediator.list)
            {
                PartnerA partnerA = p as PartnerA;
                //如果对象是PartnerA，则说明PartnerA赢钱;其他对象减钱
                if (partnerA != null)
                    partnerA.Money += money;
                else
                    p.Money -= money;  

            }
        }
    }
}
