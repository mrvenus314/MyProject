using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePatternModel.Card
{
    public class InitState : GameState
    {
        public InitState()
        {
            Console.WriteLine("Game start... Wait for Players");
        }

        public override void ChangeMoney(int money)
        {
            throw new NotImplementedException();
        }
    }
}
