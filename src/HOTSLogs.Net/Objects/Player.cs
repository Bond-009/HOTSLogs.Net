using System.Collections.Generic;

namespace HOTSLogs
{
    public struct Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public Ranking[] LeaderboardRankings { get; set; }
    }
}
