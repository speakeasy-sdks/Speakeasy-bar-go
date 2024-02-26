<!-- Start SDK Example Usage [usage] -->
```csharp
using Speakeasy.Bar;
using Speakeasy.Bar.Models.Components;
using Speakeasy.Bar.Models.Requests;

var sdk = new Speakeasy(ApiKey: "<YOUR_API_KEY_HERE>");

ListDrinksRequest req = new ListDrinksRequest() {};

var res = await sdk.Drinks.ListDrinksAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->