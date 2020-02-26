using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        public int turnOnCounter { get; set; }
        public int turnOffCounter { get; set; }
        public void TurnOn()
        {
            ++turnOnCounter;
        }

        public void TurnOff()
        {
            ++turnOffCounter;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
