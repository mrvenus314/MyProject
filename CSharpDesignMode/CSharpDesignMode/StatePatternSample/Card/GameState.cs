using System;
using System.Collections.Generic;

namespace StatePatternModel.Card
{
    public abstract class GameState
    {
        protected AbstractMediator mediator;
        public abstract void ChangeMoney(int money);
    }
}