#region

using System.Collections.Generic;
using System.Text.Json.Serialization;

#endregion

namespace NekosBestApiNet.Models.Images;

/// <summary>
///     The class that stores the thingy for the thingy (I really cant think of anything)
/// </summary>
public class ActionResults
{
    /// <summary>
    ///     The name of the anime
    /// </summary>
    [JsonPropertyName("anime_name")]
    public string AnimeName { get; set; }

    /// <summary>
    ///     The actual imaage url
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>
///     The class that stores the list for results (Do i really have to do this?)
/// </summary>
public class ActionResult
{
    /// <summary>
    ///     The returned results
    /// </summary>
    [JsonPropertyName("results")]
    public List<ActionResults> Results { get; set; }
}