namespace HOTSLogs
{
    public struct Ranking
    {
        public string GameMode { get; set; }
        public int? LeagueID { get; set; }
        public int? LeagueRank { get; set; }
        public int CurrentMMR { get; set; }
    }
}
