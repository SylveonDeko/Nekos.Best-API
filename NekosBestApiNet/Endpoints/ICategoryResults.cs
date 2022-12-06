using System.Threading.Tasks;
using NekosBestApiNet.Models.Images;
using Refit;

namespace NekosBestApiNet.Endpoints
{
    /// <summary>
    /// Return a random Neko or Kitsune!
    /// </summary>
    public interface ICategoryApi
    {
        /// <summary>
        /// What does the fox say? Returns a random Kitsune.
        /// <param name="results">Number of results to return.</param>
        /// </summary>
        [Get("/kitsune")]
        Task<CategoryResult> Kitsune(int results = 1);

        /// <summary>
        /// Nyaa~ Returns a random Neko.
        /// <param name="results">Number of results to return.</param>
        /// </summary>
        [Get("/neko")]
        Task<CategoryResult> Neko(int results = 1);


        /// <summary>
        /// Ara Ara~ Returns a random waifu
        /// </summary>
        /// <param name="results">Number of results to return</param>
        [Get("/waifu")]
        Task<CategoryResult> Waifu(int results = 1);
    }
}