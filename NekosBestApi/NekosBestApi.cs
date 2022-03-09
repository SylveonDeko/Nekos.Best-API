using System;
using System.Net.Http;
using NekosBestApi.Endpoints;
using Refit;

namespace NekosBestApi 
{
  public class NekosBestApi 
  {
    private const string BaseUrl = "https://nekos.best/api/v2";
    /// <summary>
    /// Get memes, wallpapers and query random subreddits.
    /// </summary>
    public IActionsApi ActionsApi { get; private set; }
    /// <summary>
    /// Constructor with token only
    /// </summary>
    public NekosBestApi() 
    {
      var httpClient = new HttpClient {
        BaseAddress = new Uri(BaseUrl)
      };
      Initialize(httpClient);
    }

    /// <summary>
    /// Constructor with custom HttpClient, must set BaseAddress and Authorization header manually
    /// </summary>
    /// <param name="httpClient">HttpClient instance</param>
    public NekosBestApi(HttpClient httpClient) 
        => Initialize(httpClient);

        private void Initialize(HttpClient httpClient)
        {
          ActionsApi = RestService.For<IActionsApi>(httpClient);
        }
  }

}