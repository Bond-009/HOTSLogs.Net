using Newtonsoft.Json;
using System.Collections.Generic;

namespace HOTSLogs
{
    public class Hero
    {
        [JsonRequired]
        public string PrimaryName { get; set; }
        [JsonRequired]
        public string ImageURL { get; set; }
        [JsonRequired]
        public string AttributeName { get; set; }
        [JsonRequired]
        public string Group { get; set; }
        [JsonRequired]
        public string SubGroup { get; set; }
        [JsonRequired]
        public string Translations { get; set; }
    }
}
