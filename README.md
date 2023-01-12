![Forbury](https://raw.githubusercontent.com/Forbury/Integrations/master/assets/logo/logo_text.png)﻿
# Forbury Integrations
 
 [![NuGet](https://img.shields.io/nuget/v/Forbury.Integrations)](https://www.nuget.org/packages/Forbury.Integrations)
 [![Licence](https://img.shields.io/github/license/Forbury/Integrations)](LICENCE.txt)
 ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/forbury/integrations/codeql.yml?label=Code%20Analysis)
 ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/forbury/integrations/dotnet.yml?label=Build)

This .NET client library provides a quick & easy option for integrating with Forbury APIs.

**_Note:_** In order to use this library, you must be an existing Forbury customer and have an API `ClientId` and `ClientSecret`.
To learn more about becoming a Forbury customer, or if you already are and would like access, please [contact us](https://www.forbury.com/contact-us).

## Documentation

[**Wiki page**](https://github.com/Forbury/Integrations/wiki) - Contains full documentation including examples.

[**Swagger API documentation**](https://api.forbury.com/docs) - Contains the ability for sample requests and available endpoints.

## Quick Start Guide
In order to get started, please follow these steps.

**1.** Install the NuGet package using one of the following commands

_Package Manager_
```
Install-Package Forbury.Integrations -Version 1.2.0
```

_.NET CLI_
```
dotnet add PROJECT package Forbury.Integrations --version 1.2.0
```

_PackageReference_
```
<PackageReference Include="Forbury.Integrations" Version="1.2.0" />
```

For a full list of the latest releases, please see the [package release page](https://www.nuget.org/packages/Forbury.Integrations).

**2.** Add the following to your `appsettings.config` (replace `UNIQUE_CLIENT_NAME`, `YOUR_CLIENT_ID` and `YOUR_CLIENT_SECRET`).

This library supports a multi-client environment, `UNIQUE_CLIENT_NAME` can be any internal reference name you like for accessing the client.
If you only have one client, you **will not** need to choose which client to make calls with during runtime (please see [example below](#Example-API-Usage)).

```json
"Forbury": {
  "Api": {
    "Url": "https://api.forbury.com/",
    "Version": 1
  },
  "Authentication": {
    "Url": "https://account.forbury.com/",
    "Clients": {
      "UNIQUE_CLIENT_NAME": {
        "ClientId": "YOUR_CLIENT_ID",
        "ClientSecret": "YOUR_CLIENT_SECRET"
      },
      "UNIQUE_CLIENT_NAME": {
        "ClientId": "YOUR_CLIENT_ID",
        "ClientSecret": "YOUR_CLIENT_SECRET"
      }
    }
  }
}
```

**3.** Add the following inside your `Startup.cs` _(.NET 3.1 and .NET 5)_.

```C#
public IConfiguration Configuration { get; }

public void ConfigureServices(IServiceCollection services)
{        
    services.AddForburyApi(Configuration);
    ...
}
```

Alternatively, if you are using the new .NET 6 design **without** a `Startup.cs`, add the following inside your `Program.cs` _(.NET 6)_.

```C#
using Forbury.Integrations.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddForburyApi(builder.Configuration);
```

You should now be ready to use the API!

## Example API Usage

Example usage inside a Service.

**_Note:_** _Please take note of the using statements, its important to import usings from the correct version (see [versions](#Versions) below)._

```C#
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Interfaces;
...

public class ForburyDataService
{
    private readonly IForburyTeamApiClient _forburyTeamApiClient;

    public ForburyDataService(IForburyTeamApiClient forburyTeamApiClient)
    {
        _forburyTeamApiClient = forburyTeamApiClient;

        // NOTE: In a multi-client environment, you will need to set the client
        _forburyTeamApiClient.SetClient("UNIQUE_CLIENT_NAME");
    }

    public async Task GetTeams(int amount = 20, int page = 1)
    {
        PagedResult<TeamDto> teams = await _forburyTeamApiClient.GetTeams(amount, page);

        // Do work here
        ...
    }

    public async Task GetModelDataForTeam(int id, DateTime? fromDate = null, int amount = 20, int page = 1)
    {
        PagedResult<ModelDto> models = await _forburyTeamApiClient.GetModelsByTeamId(id, fromDate, null, amount, page);

        // Do work here
        ...
    }
}
```

## Versions

Currently available API versions:
- v1

