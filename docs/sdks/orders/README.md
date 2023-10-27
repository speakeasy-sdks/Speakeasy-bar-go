# Orders
(*orders*)

## Overview

The orders endpoints.

### Available Operations

* [createOrder](#createorder) - Create an order.

## createOrder

Create an order for a drink.

### Example Usage

```typescript
import { Speakeasy } from "The-Speakeasy-Bar";
import { CreateOrderOrderUpdateRequestBodyInput, CreateOrderOrderUpdateResponse } from "The-Speakeasy-Bar/dist/sdk/models/callbacks";
import { CreateOrderRequest } from "The-Speakeasy-Bar/dist/sdk/models/operations";
import { ErrorT, OrderInput, OrderType } from "The-Speakeasy-Bar/dist/sdk/models/shared";

(async() => {
  const sdk = new Speakeasy({
    apiKey: "",
  });
const requestBody: shared.OrderInput[] = [
  {
    productCode: "APM-1F2D3",
    quantity: 26535,
    type: OrderType.Drink,
  },
];
const callbackUrl: string = "string";

  const res = await sdk.orders.createOrder(requestBody, callbackUrl);


  if (res.statusCode == 200) {
    // handle response
  }
})();
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `requestBody`                                                | [shared.OrderInput](../../models/shared/orderinput.md)[]     | :heavy_check_mark:                                           | N/A                                                          |
| `callbackUrl`                                                | *string*                                                     | :heavy_minus_sign:                                           | The url to call when the order is updated.                   |
| `config`                                                     | [AxiosRequestConfig](https://axios-http.com/docs/req_config) | :heavy_minus_sign:                                           | Available config options for making requests.                |


### Response

**Promise<[operations.CreateOrderResponse](../../models/operations/createorderresponse.md)>**

