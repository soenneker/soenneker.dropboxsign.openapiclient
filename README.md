[![](https://img.shields.io/nuget/v/soenneker.dropboxsign.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dropboxsign.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dropboxsign.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dropboxsign.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dropboxsign.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dropboxsign.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dropboxsign.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dropboxsign.openapiclient/actions/workflows/codeql.yml)

# Soenneker.DropboxSign.OpenApiClient

A generated .NET client for Dropbox Sign accounts, signature requests, templates, embedded signing, teams, API apps, bulk sends, reports, and OAuth operations.

## Installation

```bash
dotnet add package Soenneker.DropboxSign.OpenApiClient
```

## Create the client directly

```csharp
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.DropboxSign.OpenApiClient;

using var httpClient = new HttpClient();
string credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apiKey}:"));
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Basic", credentials);

var authentication = new AnonymousAuthenticationProvider();
using var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var client = new DropboxSignOpenApiClient(adapter);

var account = await client.Account.GetAsync(cancellationToken: cancellationToken);
```

The API key is the Basic-auth username and the password is empty. Use `Bearer` authentication instead when calling with an OAuth access token. The client defaults to `https://api.hellosign.com/v3`.

Generated request builders mirror the API paths, including names such as `client.Signature_request`, `client.Template`, and `client.Embedded`. Request and response types live in `Soenneker.DropboxSign.OpenApiClient.Models`; methods accept request-configuration callbacks and cancellation tokens.

For managed transport reuse and configuration, use `Soenneker.DropboxSign.OpenApiClientUtil` with `Soenneker.DropboxSign.HttpClients`.

This repository contains generated source. Keep application-specific behavior in wrapper services or separate partial-class files because regeneration can replace generated files.
