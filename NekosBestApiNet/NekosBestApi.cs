﻿#region

using System;
using System.Net.Http;
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
    public NekosBestApi()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(BaseUrl)
        };
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