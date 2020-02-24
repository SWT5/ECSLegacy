namespace ECS.Legacy
{
    public class ECS
    {
        // property + constructor injection 
        private int _thresholdLower;
        private int _threasholdHigher;
        public ITempSensor _tempSensor { get; set; }
        public IHeater _heater{ get; set; }


        public ECS(int thrL, int thrH, IHeater heater,ITempSensor tempSensor)
        {
            SetThreshold(thrL, thrH); 
            _heater = heater; 
            _tempSensor = tempSensor; 
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _thresholdLower)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thrL, int thrH)
        {
            _thresholdLower = thrL;
            _threasholdHigher = thrH;
        }

        public int GetThresholdLower()
        {
            return _thresholdLower;
        }

        public int GetThreaholdHigher()
        {
            return _threasholdHigher;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
