#region

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using NekosBestApiNet.Endpoints;
using Refit;

#endregion

namespace NekosBestApiNet;

/// <summary>
///     Main client for interacting with the Nekos.Best API.
/// </summary>
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

    /// <summary>
    ///     Gets the Actions API endpoint for action-based GIF requests.
    /// </summary>
    public IActionsApi ActionsApi { get; private set; }

    /// <summary>
    ///     Gets the Category API endpoint for image category requests.
    /// </summary>
    public ICategoryApi CategoryApi { get; private set; }

    private void Initialize(HttpClient httpClient)
    {
        ActionsApi = RestService.For<IActionsApi>(httpClient);
        CategoryApi = RestService.For<ICategoryApi>(httpClient);
    }
}