#region

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using NekosBestApiNet.Endpoints;
using Refit;

#endregion

namespace NekosBestApiNet;

public class NekosBestApi
{
    private const string BaseUrl = "https://nekos.best/api/v2";

    /// <summary>
    ///     Constructor with token only
    /// </summary>
    public NekosBestApi(string clientName)
    {
        var productValue = new ProductInfoHeaderValue(clientName, "1.0.7");
        var commentValue = new ProductInfoHeaderValue("(+https://github.com/SylveonDeko/Nekos.Best-API)");
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };
        httpClient.DefaultRequestHeaders.UserAgent.Add(productValue);
        httpClient.DefaultRequestHeaders.UserAgent.Add(commentValue);
        Initialize(httpClient);
    }

    /// <summary>
    ///     Constructor with custom HttpClient, must set BaseAddress and Authorization header manually
    /// </summary>
    /// <param name="httpClient">HttpClient instance</param>
    public NekosBestApi(HttpClient httpClient)
    {
        Initialize(httpClient);
    }

    public IActionsApi ActionsApi { get; private set; }

    public ICategoryApi CategoryApi { get; private set; }

    private void Initialize(HttpClient httpClient)
    {
        ActionsApi = RestService.For<IActionsApi>(httpClient);
        CategoryApi = RestService.For<ICategoryApi>(httpClient);
    }
}