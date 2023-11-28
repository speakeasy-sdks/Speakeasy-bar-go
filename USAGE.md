<!-- Start SDK Example Usage [usage] -->
```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(
    security: new Security() {
        ApiKey = "",
    }
);

var res = await sdk.Drinks.ListDrinksAsync(new ListDrinksRequest() {});

// handle response
```
<!-- End SDK Example Usage [usage] -->