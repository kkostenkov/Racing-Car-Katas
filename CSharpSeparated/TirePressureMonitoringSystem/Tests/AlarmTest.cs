using System.Reflection;
using NUnit.Framework;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        private Alarm alarm;
        private PredictableSensor predictableSensor;

        [SetUp]
        public void SetUp()
        {
            alarm = new Alarm();
            predictableSensor = new PredictableSensor();
        }
        
        [Test]
        public void Should_BeOff_When_Created()
        {
            Assert.False(alarm.AlarmOn);
        }
        
        [TestCase(0, ExpectedResult = true)]
        [TestCase(22, ExpectedResult = true)]
        public bool Should_BeOn_When_PressureIsOfLimits(double inputPressure)
        {
            alarm.Check(inputPressure);
            return alarm.AlarmOn;
        }
        
        [TestCase(17, ExpectedResult = false)]
        [TestCase(19, ExpectedResult = false)]
        [TestCase(21, ExpectedResult = false)]
        public bool Should_BeOff_When_PressureIsInLimits(double inputPressure)
        {
            alarm.Check(inputPressure);
            return alarm.AlarmOn;
        }

        // [Test]
        // public void Foo()
        // {
        //     alarm.GetType().GetField("_sensor", BindingFlags.Instance | BindingFlags.NonPublic)
        //         .SetValue(alarm, predictableSensor);
        //     alarm.Check();
        //     Assert.False(alarm.AlarmOn);
        // }
    }

    public class PredictableSensor : Sensor
    {
        // public override double PopNextPressurePsiValue()
        // {
        //     return 0;
        // }
    }
}