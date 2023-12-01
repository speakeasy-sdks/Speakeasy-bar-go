<!-- Start SDK Example Usage [usage] -->
```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    });

ListDrinksRequest req = new ListDrinksRequest() {};

var res = await sdk.Drinks.ListDrinksAsync(req);

// handle response
```

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    });

ListIngredientsRequest req = new ListIngredientsRequest() {
    Ingredients = new List<string>() {
        "string",
    },
};

var res = await sdk.Ingredients.ListIngredientsAsync(req);

// handle response
```

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;
using System.Collections.Generic;
using Speakeasy.Bar.Models.Callbacks;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    });

CreateOrderRequest req = new CreateOrderRequest() {
    RequestBody = new List<OrderInput>() {
        new OrderInput() {
            ProductCode = "APM-1F2D3",
            Quantity = 26535,
            Type = OrderType.Drink,
        },
    },
};

var res = await sdk.Orders.CreateOrderAsync(req);

// handle response
```

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    });

List<RequestBody> req = new List<RequestBody>() {
    new RequestBody() {},
};

var res = await sdk.Config.SubscribeToWebhooksAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->