using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderMode
{
    public class Builder1 : Builder
    {
        Computer computer = new Computer();

        public override void BuildCPU()
        {
            computer.Add("CPU1");
        }

        public override void BuildMainBoard()
        {
            computer.Add("MainBoard1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
