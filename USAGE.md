<!-- Start SDK Example Usage -->


```typescript
import { Speakeasy } from "speakeasy-bar";
import { ListDrinksRequest } from "speakeasy-bar/dist/sdk/models/operations";
import { DrinkType } from "speakeasy-bar/dist/sdk/models/shared";

(async () => {
    const sdk = new Speakeasy({
        apiKey: "",
    });
    const drinkType: DrinkType = DrinkType.Spirit;

    const res = await sdk.drinks.listDrinks(drinkType);

    if (res.statusCode == 200) {
        // handle response
    }
})();

```
<!-- End SDK Example Usage -->