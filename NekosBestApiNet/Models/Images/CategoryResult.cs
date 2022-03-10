using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NekosBestApiNet.Models.Images
{
    public class CategoryResults
        {
            [JsonPropertyName("artist_href")]
            public string ArtistHref { get; set; }

            [JsonPropertyName("artist_name")]
            public string ArtistName { get; set; }

            [JsonPropertyName("source_url")]
            public string SourceUrl { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class CategoryResult
        {
            [JsonPropertyName("results")]
            public List<CategoryResults> Results { get; set; }
        }
        
}