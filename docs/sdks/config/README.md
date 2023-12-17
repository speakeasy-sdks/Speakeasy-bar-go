# Config
(*Config*)

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
        ApiKey = "<YOUR_API_KEY_HERE>",
    });

List<RequestBody> req = new List<RequestBody>() {
    new RequestBody() {},
};

var res = await sdk.Config.SubscribeToWebhooksAsync(req);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | List<[RequestBody](../../Models/Requests/RequestBody.md)> | :heavy_check_mark:                                        | The request object to use for the request.                |


### Response

**[SubscribeToWebhooksResponse](../../Models/Requests/SubscribeToWebhooksResponse.md)**

