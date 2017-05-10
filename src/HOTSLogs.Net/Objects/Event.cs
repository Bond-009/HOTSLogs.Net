namespace HOTSLogs
{
    public struct Event
    {
        public int EventID { get; set; }
        public int? EventIDParent { get; set; }
        public string EventName { get; set; }
        public int EventOrder { get; set; }
        public int EventGamesPlayed { get; set; }
    }
}
