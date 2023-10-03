namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        Sensor _sensor = new Sensor();

        bool _alarmOn = false;
        private long _alarmCount = 0;


        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            Check(psiPressureValue);
        }

        public void Check(double psiPressureValue)
        {
            var isInLimits = LowPressureThreshold <= psiPressureValue && psiPressureValue <= HighPressureThreshold;
            if (!isInLimits) {
                _alarmOn = true;
                _alarmCount += 1;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
