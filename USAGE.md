<!-- Start SDK Example Usage -->
```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy();

var res = await sdk.Drinks.ListDrinksAsync(new ListDrinksRequest() {});

// handle response
```
<!-- End SDK Example Usage -->