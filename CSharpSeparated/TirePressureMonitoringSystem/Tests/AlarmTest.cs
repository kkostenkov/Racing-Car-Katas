using System.Reflection;
using NUnit.Framework;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class AlarmTest
    {
        private Alarm alarm;
        private Sensor fakeSensor;

        [SetUp]
        public void SetUp()
        {
            alarm = new Alarm();
            fakeSensor = new Sensor();
        }
        
        [Test]
        public void Should_BeOff_When_Created()
        {
            Assert.False(alarm.AlarmOn);
        }

        [Test]
        public void Foo()
        {
            alarm.GetType().GetField("_sensor", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(alarm, fakeSensor);
            alarm.Check();
            Assert.False(alarm.AlarmOn);
        }
    }
}