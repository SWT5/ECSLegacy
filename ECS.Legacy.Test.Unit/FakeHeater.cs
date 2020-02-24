using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Test.Unit
{
    public class FakeHeater : IHeater
    {
        public bool IsOn { get; set; }

        public FakeHeater()
        {
            IsOn = false;
        }
        
        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        } 

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
