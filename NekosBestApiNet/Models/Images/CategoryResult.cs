using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NekosBestApiNet.Models.Images;

/// <summary>
///     Represents a single category result item from the API.
/// </summary>
public class CategoryResults
{
    /// <summary>
    ///     Gets or sets the artist's profile URL.
    /// </summary>
    [JsonPropertyName("artist_href")]
    public string ArtistHref { get; set; }

    /// <summary>
    ///     Gets or sets the artist's name.
    /// </summary>
    [JsonPropertyName("artist_name")]
    public string ArtistName { get; set; }

    /// <summary>
    ///     Gets or sets the source URL of the image.
    /// </summary>
    [JsonPropertyName("source_url")]
    public string SourceUrl { get; set; }

    /// <summary>
    ///     Gets or sets the URL of the image.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>
///     Represents the API response containing a collection of category results.
/// </summary>
public class CategoryResult
{
    /// <summary>
    ///     Gets or sets the list of category results returned from the API.
    /// </summary>
    [JsonPropertyName("results")]
    public List<CategoryResults> Results { get; set; }
}