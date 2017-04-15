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
        public async Task HeroesTest()
        {
            await client.GetHeroes();
        }

        [Fact]
        public async Task MapsTest()
        {
            await client.GetMaps();
        }

        [Fact]
        public async Task EventsTest()
        {
            await client.GetEvents();
        }

        [Theory]
        [InlineData(6088110)]
        [InlineData(6323073)]
        public async Task PlayerTest(int value)
        {
            await client.GetPlayerSummary(value);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
