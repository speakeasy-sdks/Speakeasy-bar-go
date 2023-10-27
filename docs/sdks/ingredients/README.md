# Ingredients
(*ingredients*)

## Overview

The ingredients endpoints.

### Available Operations

* [listIngredients](#listingredients) - Get a list of ingredients.

## listIngredients

Get a list of ingredients, if authenticated this will include stock levels and product codes otherwise it will only include public information.

### Example Usage

```typescript
import { Speakeasy } from "The-Speakeasy-Bar";
import { ListIngredientsRequest } from "The-Speakeasy-Bar/dist/sdk/models/operations";

(async() => {
  const sdk = new Speakeasy({
    apiKey: "",
  });
const ingredients: string[] = [
  "string",
];

  const res = await sdk.ingredients.listIngredients(ingredients);


  if (res.statusCode == 200) {
    // handle response
  }
})();
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ingredients`                                                                         | *string*[]                                                                            | :heavy_minus_sign:                                                                    | A list of ingredients to filter by. If not provided all ingredients will be returned. |
| `config`                                                                              | [AxiosRequestConfig](https://axios-http.com/docs/req_config)                          | :heavy_minus_sign:                                                                    | Available config options for making requests.                                         |


### Response

**Promise<[operations.ListIngredientsResponse](../../models/operations/listingredientsresponse.md)>**

