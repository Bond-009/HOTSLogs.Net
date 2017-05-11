using Newtonsoft.Json;

namespace HOTSLogs
{
    public class Event
    {
        [JsonRequired]
        public int EventID { get; set; }
        public int? EventIDParent { get; set; }
        [JsonRequired]
        public string EventName { get; set; }
        [JsonRequired]
        public int EventOrder { get; set; }
        [JsonRequired]
        public int EventGamesPlayed { get; set; }
    }
}
