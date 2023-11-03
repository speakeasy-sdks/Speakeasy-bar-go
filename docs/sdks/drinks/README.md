# DrinksSDK
(*Drinks*)

## Overview

The drinks endpoints.

### Available Operations

* [GetDrink](#getdrink) - Get a drink.
* [ListDrinks](#listdrinks) - Get a list of drinks.

## GetDrink

Get a drink by name, if authenticated this will include stock levels and product codes otherwise it will only include public information.

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

var res = await sdk.Drinks.GetDrinkAsync(new GetDrinkRequest() {
    Name = "string",
});

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [GetDrinkRequest](../../models/operations/GetDrinkRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |


### Response

**[GetDrinkResponse](../../models/operations/GetDrinkResponse.md)**


## ListDrinks

Get a list of drinks, if authenticated this will include stock levels and product codes otherwise it will only include public information.

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

var res = await sdk.Drinks.ListDrinksAsync(new ListDrinksRequest() {});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [ListDrinksRequest](../../models/operations/ListDrinksRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[ListDrinksResponse](../../models/operations/ListDrinksResponse.md)**

