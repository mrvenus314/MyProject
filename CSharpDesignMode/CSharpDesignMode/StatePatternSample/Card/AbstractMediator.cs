using System;
using System.Collections.Generic;

namespace StatePatternModel.Card
{
    public abstract class AbstractMediator
    {
        public List<AbstractCardPartner> list = new List<AbstractCardPartner>();
        public GameState gameState { get; set; }

        public AbstractMediator(GameState state)
        {
            this.gameState = state;
        }

        public void Join(AbstractCardPartner partner)
        {
            list.Add(partner);
            Console.WriteLine(partner.NickName + " has joined the game");
        }

        public void Quit(AbstractCardPartner partner)
        {
            list.Remove(partner);
        }

        public void ChangeMoney(int money)
        {
            Console.WriteLine("Game is over");
            gameState.ChangeMoney(money);
        }
    }
}