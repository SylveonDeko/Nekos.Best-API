#region

using System.Threading.Tasks;
using NekosBestApiNet.Models.Images;
using Refit;

#endregion

namespace NekosBestApiNet.Endpoints;

/// <summary>
///     Return a random Neko or Kitsune!
/// </summary>
public interface ICategoryApi
{
    /// <summary>
    ///     What does the fox say? Returns a random Kitsune.
    ///     <param name="results">Number of results to return.</param>
    /// </summary>
    [Get("/kitsune")]
    public Task<CategoryResult> Kitsune(int results = 1);

    /// <summary>
    ///     Nyaa~ Returns a random Neko.
    ///     <param name="results">Number of results to return.</param>
    /// </summary>
    [Get("/neko")]
    public Task<CategoryResult> Neko(int results = 1);


    /// <summary>
    ///     Ara Ara~ Returns a random waifu
    /// </summary>
    /// <param name="results">Number of results to return</param>
    [Get("/waifu")]
    public Task<CategoryResult> Waifu(int results = 1);

    /// <summary>
    ///     Returns a random husbando
    /// </summary>
    /// <param name="results"></param>
    /// <returns>Number of results to return.</returns>
    [Get("/husbando")]
    public Task<CategoryResult> Husbando(int results = 1);
}