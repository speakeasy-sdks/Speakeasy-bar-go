<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;

var sdk = new Speakeasy();

ListDrinksRequest req = new ListDrinksRequest() {};

var res = await sdk.Drinks.ListDrinksAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->