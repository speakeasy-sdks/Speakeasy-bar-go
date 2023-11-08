# Config
(*.Config*)

### Available Operations

* [SubscribeToWebhooks](#subscribetowebhooks) - Subscribe to webhooks.

## SubscribeToWebhooks

Subscribe to webhooks.

### Example Usage

```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    }
);

var res = await sdk.Config.SubscribeToWebhooksAsync(new List<RequestBody>() {
    new RequestBody() {},
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | List<[RequestBody](../../models/operations/RequestBody.md)> | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[SubscribeToWebhooksResponse](../../models/operations/SubscribeToWebhooksResponse.md)**

