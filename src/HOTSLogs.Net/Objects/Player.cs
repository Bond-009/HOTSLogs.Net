using Newtonsoft.Json;
using System.Collections.Generic;

namespace HOTSLogs
{
    public class Player
    {
        [JsonRequired]
        public int PlayerID { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonRequired]
        public IEnumerable<Ranking> LeaderboardRankings { get; set; }
    }
}
