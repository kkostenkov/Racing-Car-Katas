using System.Reflection;
using NSubstitute;
using NUnit.Framework;

namespace TDDMicroExercises.TelemetrySystem.Tests
{
    public class TelemetryDiagnosticControlsTest
    {
        [Test]
        public void Should_ThrowException_When_ClientIsOffline()
        {
            var offlineClient = Substitute.For<TelemetryClient>();
            offlineClient.OnlineStatus.Returns(false);
            var controls = new TelemetryDiagnosticControls();
            OverrideTelemetryClient(offlineClient, controls);


            Assert.Throws<Exception>(controls.CheckTransmission);
        }
        
        public void OverrideTelemetryClient(TelemetryClient telemetryClient, TelemetryDiagnosticControls diagnosticControls)
        {
            diagnosticControls.GetType().GetField("_telemetryClient", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(diagnosticControls, telemetryClient);
        }
    }
}
