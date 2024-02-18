# Authentication
(*Authentication*)

## Overview

The authentication endpoints.

### Available Operations

* [Authenticate](#authenticate) - Authenticate with the API by providing a username and password.

## Authenticate

Authenticate with the API by providing a username and password.

### Example Usage

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(ApiKey: "<YOUR_API_KEY_HERE>");

AuthenticateRequestBody req = new AuthenticateRequestBody() {};

var res = await sdk.Authentication.AuthenticateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [AuthenticateRequestBody](../../Models/Requests/AuthenticateRequestBody.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[AuthenticateResponse](../../Models/Requests/AuthenticateResponse.md)**

