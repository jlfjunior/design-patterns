
using DesignPatterns.Behavorial.Bridge;
using Xunit;

namespace DesignPatterns.Tests
{
    public class BridgeTest
    {
        [Fact]
        public void ShouldConectOnConsole()
        {
            var xBox = new XBox();
            var remote = new JoystickBasic(xBox);
            xBox.Startup();

            Assert.True(remote.ConectOnConsole());
        }

        [Fact]
        public void ShouldShutdownConsole()
        {
            var playStation = new PlayStation();
            var remote = new JoystickAdvanced(playStation);
            playStation.Startup();

            Assert.True(remote.ConectOnConsole());
            Assert.True(remote.ShutdownConsole());
        }
    }
}
