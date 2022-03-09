﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NekosBestApi.Models.Images 
{
    public class Result
    {
        [JsonPropertyName("anime_name")]
        public string AnimeName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class ActionResult
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }
}