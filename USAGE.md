<!-- Start SDK Example Usage -->


```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        ApiKey = "",
    }
);

var res = await sdk.Drinks.ListDrinksAsync(new ListDrinksRequest() {});

// handle response
```
<!-- End SDK Example Usage -->