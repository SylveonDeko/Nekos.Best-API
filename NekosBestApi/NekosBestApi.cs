using System;
using System.Net.Http;
using NekosBestApi.Endpoints;
using Refit;

namespace NekosBestApi 
{
  public class NekosBestApi 
  {
    private const string BaseUrl = "https://nekos.best/api/v2";
    public IActionsApi ActionsApi { get; private set; }
    
    public ICategoryApi CategoryApi { get; private set; }
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
          CategoryApi = RestService.For<ICategoryApi>(httpClient);
        }
  }

}