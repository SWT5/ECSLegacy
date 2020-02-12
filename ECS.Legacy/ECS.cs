namespace ECS.Legacy
{
    public class ECS
    {
        // property + constructor injection 
        private int _threshold;
        public ITempSensor _tempSensor { private get; set; }
        public IHeater _heater{private get; set; }


        public ECS(int thr, IHeater heater,ITempSensor tempSensor)
        {
            SetThreshold(thr);
            _heater = heater; 
            _tempSensor = tempSensor; 
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
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
