# OrdersSDK
(*Orders*)

## Overview

The orders endpoints.

### Available Operations

* [CreateOrder](#createorder) - Create an order.

## CreateOrder

Create an order for a drink.

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

var res = await sdk.Orders.CreateOrderAsync(new CreateOrderRequest() {
    RequestBody = new List<OrderInput>() {
        new OrderInput() {
            ProductCode = "APM-1F2D3",
            Quantity = 26535,
            Type = Speakeasy.Models.Shared.OrderType.Drink,
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CreateOrderRequest](../../models/operations/CreateOrderRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[CreateOrderResponse](../../models/operations/CreateOrderResponse.md)**

