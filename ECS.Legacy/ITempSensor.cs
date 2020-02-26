using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy //sensor mellemrum
{
    public interface ITempSensor
    {
        int GetTemp(); 
        bool RunSelfTest(); 

    }
}
