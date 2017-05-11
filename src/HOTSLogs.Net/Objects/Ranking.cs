using Newtonsoft.Json;

namespace HOTSLogs
{
    public class Ranking
    {
        [JsonRequired]
        public string GameMode { get; set; }
        public int? LeagueID { get; set; }
        public int? LeagueRank { get; set; }
        [JsonRequired]
        public int CurrentMMR { get; set; }
    }
}
