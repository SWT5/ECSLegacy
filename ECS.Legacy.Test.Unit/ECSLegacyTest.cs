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
        private FakeHeater _fakeHeater;
        private FakeTempSensor _fakeTemp;

        [SetUp]
        public void setUpFunction()
        {
            _fakeHeater = new FakeHeater();
            _fakeTemp = new FakeTempSensor();
           uut = new ECS(20, 28, _fakeHeater, _fakeTemp);
        }

        [Test]
        public void testIfHeaterGetsTurnedOn()
        {
            _fakeTemp.SetTemp(15);
            uut.Regulate();
            Assert.That(_fakeHeater.IsOn, Is.EqualTo(true));
        }
    }
}
