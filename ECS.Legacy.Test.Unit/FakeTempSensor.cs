using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Test.Unit
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temperature;

        public void SetTemp(int temp)
        {
            Temperature = temp;
        }

        public int GetTemp()
        {
            return Temperature;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
