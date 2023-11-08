# Orders
(*.Orders*)

## Overview

The orders endpoints.

### Available Operations

* [CreateOrder](#createorder) - Create an order.

## CreateOrder

Create an order for a drink.

### Example Usage

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;
using System.Collections.Generic;
using Speakeasy.Bar.Models.Callbacks;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    }
);

var res = await sdk.Orders.CreateOrderAsync(new CreateOrderRequest() {
    RequestBody = new List<OrderInput>() {
        new OrderInput() {
            ProductCode = "APM-1F2D3",
            Quantity = 26535,
            Type = OrderType.Drink,
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

