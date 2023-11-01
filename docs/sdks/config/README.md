# ConfigSDK
(*Config*)

### Available Operations

* [SubscribeToWebhooks](#subscribetowebhooks) - Subscribe to webhooks.

## SubscribeToWebhooks

Subscribe to webhooks.

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

var res = await sdk.Config.SubscribeToWebhooksAsync(new List<SubscribeToWebhooksRequestBody>() {
    new SubscribeToWebhooksRequestBody() {},
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | List<[SubscribeToWebhooksRequestBody](../../models/operations/SubscribeToWebhooksRequestBody.md)> | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[SubscribeToWebhooksResponse](../../models/operations/SubscribeToWebhooksResponse.md)**

