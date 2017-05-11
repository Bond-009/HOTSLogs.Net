using Newtonsoft.Json;
using System.Collections.Generic;

namespace HOTSLogs
{
    public class Map
    {
        [JsonRequired]
        public string PrimaryName { get; set; }
        [JsonRequired]
        public string ImageURL { get; set; }
        [JsonRequired]
        public string Translations { get; set; }
    }
}
