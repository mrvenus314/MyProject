using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public class MediatorPartner : AbstractMediator
    {
        public MediatorPartner(GameState gameState) : base(gameState)
        {

        }
    }
}
