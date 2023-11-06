# IngredientsSDK
(*Ingredients*)

## Overview

The ingredients endpoints.

### Available Operations

* [ListIngredients](#listingredients) - Get a list of ingredients.

## ListIngredients

Get a list of ingredients, if authenticated this will include stock levels and product codes otherwise it will only include public information.

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

var res = await sdk.Ingredients.ListIngredientsAsync(new ListIngredientsRequest() {
    Ingredients = new List<string>() {
        "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListIngredientsRequest](../../models/operations/ListIngredientsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[ListIngredientsResponse](../../models/operations/ListIngredientsResponse.md)**

