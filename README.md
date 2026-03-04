# Nekos.Best API Wrapper

[![nuget version][0]][1]
[![downloads][2]][1]

> https://docs.nekos.best/index.html

## Overview

A C# wrapper for the [Nekos.Best API](https://docs.nekos.best/index.html), which serves fully SFW, high quality anime images and GIFs. All endpoints are available through two APIs: `ActionsApi` for action-based GIFs and `CategoryApi` for image categories.

If you find any bugs or want a feature added, [create an issue](https://github.com/SylveonDeko/Nekos.Best-API/issues/new/).

## Installation

```ps
dotnet add package NekosBestApiNet
```

## Usage

### Basic usage

The constructor takes a client name string used as the User-Agent header.

```cs
using NekosBestApiNet;

var api = new NekosBestApi("MyAppName");

var result = await api.ActionsApi.Hug();
Console.WriteLine(result.Results[0].Url);
```

### Requesting multiple results

All endpoints accept an optional `amount` parameter (defaults to 1).

```cs
var results = await api.ActionsApi.Pat(amount: 5);
foreach (var r in results.Results)
    Console.WriteLine(r.Url);
```

### Custom HttpClient

You can provide your own `HttpClient`. You must set `BaseAddress` manually.

```cs
using System.Net.Http;
using NekosBestApiNet;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://nekos.best/api/v2")
};

var api = new NekosBestApi(httpClient);
```

### Dependency injection

```cs
using NekosBestApiNet;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton(new NekosBestApi("MyAppName"));

var provider = services.BuildServiceProvider();
var api = provider.GetRequiredService<NekosBestApi>();

var result = await api.ActionsApi.Hug();
Console.WriteLine(result.Results[0].Url);
```

## Available endpoints

### ActionsApi

| Method | Endpoint |
|---|---|
| `Angry` | `/angry` |
| `Baka` | `/baka` |
| `Bite` | `/bite` |
| `Bleh` | `/bleh` |
| `Blowkiss` | `/blowkiss` |
| `Blush` | `/blush` |
| `Bonk` | `/bonk` |
| `Bored` | `/bored` |
| `Carry` | `/carry` |
| `Clap` | `/clap` |
| `Confused` | `/confused` |
| `Cry` | `/cry` |
| `Cuddle` | `/cuddle` |
| `Dance` | `/dance` |
| `Facepalm` | `/facepalm` |
| `Feed` | `/feed` |
| `Happy` | `/happy` |
| `Handhold` | `/handhold` |
| `Handshake` | `/handshake` |
| `Highfive` | `/highfive` |
| `Hug` | `/hug` |
| `Kabedon` | `/kabedon` |
| `Kick` | `/kick` |
| `Kiss` | `/kiss` |
| `Laugh` | `/laugh` |
| `Lappillow` | `/lappillow` |
| `Lurk` | `/lurk` |
| `Nod` | `/nod` |
| `Nom` | `/nom` |
| `Nope` | `/nope` |
| `Nya` | `/nya` |
| `Pat` | `/pat` |
| `Peck` | `/peck` |
| `Poke` | `/poke` |
| `Pout` | `/pout` |
| `Punch` | `/punch` |
| `Run` | `/run` |
| `Salute` | `/salute` |
| `Shake` | `/shake` |
| `Shoot` | `/shoot` |
| `Shocked` | `/shocked` |
| `Shrug` | `/shrug` |
| `Sip` | `/sip` |
| `Slap` | `/slap` |
| `Sleep` | `/sleep` |
| `Smile` | `/smile` |
| `Smug` | `/smug` |
| `Spin` | `/spin` |
| `Stare` | `/stare` |
| `TableFlip` | `/tableflip` |
| `Teehee` | `/teehee` |
| `Think` | `/think` |
| `Thumbsup` | `/thumbsup` |
| `Tickle` | `/tickle` |
| `Wag` | `/wag` |
| `Wave` | `/wave` |
| `Wink` | `/wink` |
| `Yawn` | `/yawn` |
| `Yeet` | `/yeet` |

### CategoryApi

Fetch images by category. See [docs.nekos.best](https://docs.nekos.best/index.html) for the full list of available categories.

[0]: https://img.shields.io/nuget/v/NekosBestApiNet?style=flat-square

[1]: https://www.nuget.org/packages/NekosBestApiNet

[2]: https://img.shields.io/nuget/dt/NekosBestApiNet?style=flat-square
