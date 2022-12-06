using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NekosBestApiNet.Models.Images
{
    public class ActionResults
    {
        [JsonPropertyName("anime_name")]
        public string AnimeName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class ActionResult
    {
        [JsonPropertyName("results")]
        public List<ActionResults> Results { get; set; }
    }
}