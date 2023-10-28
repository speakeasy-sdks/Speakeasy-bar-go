# AuthenticationSDK
(*Authentication*)

## Overview

The authentication endpoints.

### Available Operations

* [Authenticate](#authenticate) - Authenticate with the API by providing a username and password.

## Authenticate

Authenticate with the API by providing a username and password.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        ApiKey = "",
    }
);

var res = await sdk.Authentication.AuthenticateAsync(new AuthenticateRequestBody() {});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [AuthenticateRequestBody](../../models/operations/AuthenticateRequestBody.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[AuthenticateResponse](../../models/operations/AuthenticateResponse.md)**

