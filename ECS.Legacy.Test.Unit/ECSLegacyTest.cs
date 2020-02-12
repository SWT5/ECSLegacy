using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    public class ECSLegacyTest
    {
        private ECS uut;
        private Heater h1 = new Heater();
        private TempSensor t1 = new TempSensor();

        [SetUp]
        public void setUpFunction()
        {
           uut = new ECS(30, new Heater(), new TempSensor()); 
        }



    }
}
