# Drinks
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
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;

var sdk = new Speakeasy(ApiKey: "<YOUR_API_KEY_HERE>");

GetDrinkRequest req = new GetDrinkRequest() {
    Name = "<value>",
};

var res = await sdk.Drinks.GetDrinkAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetDrinkRequest](../../Models/Requests/GetDrinkRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[GetDrinkResponse](../../Models/Requests/GetDrinkResponse.md)**


## ListDrinks

Get a list of drinks, if authenticated this will include stock levels and product codes otherwise it will only include public information.

### Example Usage

```csharp
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;

var sdk = new Speakeasy();

ListDrinksRequest req = new ListDrinksRequest() {};

var res = await sdk.Drinks.ListDrinksAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListDrinksRequest](../../Models/Requests/ListDrinksRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListDrinksResponse](../../Models/Requests/ListDrinksResponse.md)**

