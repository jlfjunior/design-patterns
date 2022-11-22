using DesignPatterns.Structure.Adapter;
using Xunit;

namespace DesignPatterns.Tests
{
    public class AdapterTest
    {
        [Fact]
        public void ShouldUseTwoDifferLogs()
        {
            var service = new Service(new Logger());
            service.ToString();
            service = new Service(new AdapterLogger(new CustomLogger()));
            service.ToString();
        }
    }
}