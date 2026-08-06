# Consumable Purchases

Consumable products are the most common type of in-app purchase in mobile games. They can be purchased multiple times because they are "consumed" after use.

Examples include coins, gems, energy, extra lives, hints, boosters, and other virtual currencies.

This guide explains how to implement consumable purchases using Unity IAP with a production-ready workflow.

---

# Before You Begin

Complete the previous guides before continuing:

- [Introduction](introduction.md)
- [Prerequisites](prerequisites.md)
- [Install Unity IAP](install-unity-iap.md)
- [Unity Gaming Services](unity-gaming-services.md)
- [Create Products](create-products.md)

---

# What is a Consumable Product?

A consumable product can be purchased repeatedly.

Every successful purchase grants the player additional resources.

Examples:

- 100 Coins
- 500 Coins
- 1000 Gems
- Extra Lives
- Energy Refill
- Hint Pack

Unlike non-consumables, ownership is not permanent.

---

# Typical Purchase Flow

A standard consumable purchase follows this sequence:

```text
Player taps Buy Button
        │
        ▼
Unity IAP starts purchase
        │
        ▼
Store processes payment
        │
        ▼
Purchase Successful
        │
        ▼
Validate Product
        │
        ▼
Reward Player
        │
        ▼
Complete Transaction
```

---

# Example Product IDs

Use clear and descriptive Product IDs.

```text
com.company.game.coin100

com.company.game.coin500

com.company.game.coin1000

com.company.game.energy

com.company.game.hints
```

Avoid changing Product IDs after publishing.

---

# Register Consumable Products

When initializing Unity IAP, register each consumable product.

Example:

```csharp
builder.AddProduct(
    "com.company.game.coin100",
    ProductType.Consumable
);

builder.AddProduct(
    "com.company.game.coin500",
    ProductType.Consumable
);
```

Repeat this process for every consumable item in your game.

---

# Start a Purchase

When the player presses a purchase button, initiate the purchase using the Product ID.

Example:

```csharp
controller.InitiatePurchase("com.company.game.coin100");
```

Unity IAP communicates with Google Play or the App Store and handles the payment process.

---

# Process Successful Purchases

When a purchase succeeds:

1. Verify the purchased Product ID.
2. Reward the player.
3. Save the updated player data.
4. Complete the transaction.

Example:

```csharp
switch(product.definition.id)
{
    case "com.company.game.coin100":

        playerCoins += 100;

        break;
}
```

Always grant rewards only after confirming the purchase was successful.

---

# Save Player Data

After rewarding the player, save the updated data immediately.

Example:

```text
Purchase Success

↓

Grant Coins

↓

Save Game

↓

Update UI
```

Saving immediately helps prevent progress loss if the game closes unexpectedly.

---

# Handle Failed Purchases

Not every purchase will succeed.

Possible reasons include:

- Payment cancelled
- Network error
- Store unavailable
- Invalid Product ID
- Billing unavailable

Always inform the player with a clear, user-friendly message instead of failing silently.

---

# Restore Purchases?

Consumable purchases are **not restored**.

Once consumed, they are considered used.

Examples:

- Coins
- Gems
- Energy

If your game needs to restore consumable balances across devices, implement a secure cloud-based inventory system.

---

# Testing Consumables

Before publishing your game:

- Test every consumable product.
- Verify the correct reward is granted.
- Confirm purchases complete successfully.
- Test failed purchases.
- Test repeated purchases.
- Check that saved data updates correctly.

Never release without testing every purchase flow.

---

# Best Practices

Follow these recommendations:

- Use descriptive Product IDs.
- Grant rewards only after successful purchases.
- Save player progress immediately.
- Prevent duplicate rewards.
- Display loading indicators during purchases.
- Handle errors gracefully.
- Log purchase events for debugging.
- Keep purchase logic centralized in one manager class.

---

# Common Mistakes

Avoid these common issues:

- Rewarding players before purchase confirmation.
- Using incorrect Product IDs.
- Forgetting to save player data.
- Ignoring failed purchases.
- Hardcoding values throughout the project.
- Allowing duplicate purchase processing.

---

# Production Tips

For larger games:

- Create a dedicated `IAPManager`.
- Store Product IDs in constants or ScriptableObjects.
- Separate UI from purchasing logic.
- Log purchases for analytics.
- Validate receipts for high-value purchases.
- Keep purchasing code reusable and modular.

This approach makes your purchasing system easier to maintain as your game grows.

---

# What's Next?

Consumable products are only one type of purchase.

The next guide explains **Non-Consumable Purchases**, which unlock permanent content such as Remove Ads, Premium Versions, and Character Packs.

---

# Related Guides

- ← [Create Products](create-products.md)
- → [Non-Consumables](non-consumables.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Create Products](create-products.md)
6. [Non-Consumables](non-consumables.md)
7. [Subscriptions](subscriptions.md)
8. [Restore Purchases](restore-purchases.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
