using HOTSLogs;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HOTSLogs.Net.Tests
{
    public class HOTSTest : IDisposable
    {
        HOTSLogsClient client = new HOTSLogsClient();

        [Fact]
        public Task HeroesTest()
            => client.GetHeroes();

        [Fact]
        public Task MapsTest()
            => client.GetMaps();

        [Fact]
        public Task EventsTest()
            => client.GetEvents();

        [Theory]
        [InlineData(6088110)]
        [InlineData(6323073)]
        public Task PlayerTest(int value)
            => client.GetPlayerSummary(value);

        public void Dispose() => client.Dispose();
    }
}
