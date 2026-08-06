# Non-Consumable Purchases

Non-consumable products are purchased once and permanently owned by the player. Unlike consumable items, these purchases do not expire or decrease over time and can be restored if the player reinstalls the game or switches to a new device.

Common examples include removing advertisements, unlocking premium content, purchasing character packs, or unlocking all levels.

This guide explains how to implement non-consumable purchases using Unity IAP with production-ready practices.

---

# Before You Begin

Complete the previous guides before continuing:

- [Introduction](introduction.md)
- [Prerequisites](prerequisites.md)
- [Install Unity IAP](install-unity-iap.md)
- [Unity Gaming Services](unity-gaming-services.md)
- [Create Products](create-products.md)
- [Consumable Purchases](consumable-purchases.md)

---

# What is a Non-Consumable Product?

A non-consumable product is purchased only once.

After the purchase, the player permanently owns the item.

Examples:

- Remove Ads
- Premium Upgrade
- Unlock All Levels
- Character Pack
- Soundtrack
- Theme Pack

If a player reinstalls the game or changes devices, these purchases can usually be restored.

---

# Typical Purchase Flow

```text
Player taps Buy Button
        │
        ▼
Unity IAP starts purchase
        │
        ▼
Store verifies payment
        │
        ▼
Purchase Successful
        │
        ▼
Unlock Premium Content
        │
        ▼
Save Ownership
        │
        ▼
Complete Transaction
```

---

# Example Product IDs

Use descriptive Product IDs for permanent purchases.

```text
com.company.game.removeads

com.company.game.premium

com.company.game.unlockalllevels

com.company.game.characterpack
```

Never change Product IDs after publishing your game.

---

# Register Non-Consumable Products

Register every non-consumable product during Unity IAP initialization.

Example:

```csharp
builder.AddProduct(
    "com.company.game.removeads",
    ProductType.NonConsumable
);

builder.AddProduct(
    "com.company.game.premium",
    ProductType.NonConsumable
);
```

---

# Start a Purchase

Begin the purchase when the player selects a premium item.

Example:

```csharp
controller.InitiatePurchase(
    "com.company.game.removeads"
);
```

Unity IAP will communicate with Google Play or the App Store to complete the transaction.

---

# Process Successful Purchases

After the purchase succeeds:

- Verify the Product ID.
- Unlock the purchased feature.
- Save ownership permanently.
- Refresh the game interface.

Example:

```csharp
switch(product.definition.id)
{
    case "com.company.game.removeads":

        AdsManager.DisableAds();

        break;

    case "com.company.game.premium":

        UnlockPremiumFeatures();

        break;
}
```

Always unlock content only after the purchase has been confirmed.

---

# Save Ownership

Once a purchase is complete, permanently save the player's ownership status.

Example:

```text
Purchase Success

↓

Unlock Feature

↓

Save Ownership

↓

Update Game
```

Ownership can be stored locally and synchronized with cloud save if your game supports multiple devices.

---

# Restore Purchases

Unlike consumables, non-consumable products can be restored.

Typical examples include:

- Remove Ads
- Premium Upgrade
- Character Packs
- Level Unlocks

On iOS, restoration is initiated manually.

On Google Play, previously owned purchases are usually restored automatically when the player signs in with the same Google account.

Always provide a **Restore Purchases** option in your game's settings or shop.

---

# Testing Non-Consumables

Before releasing your game:

- Purchase each product.
- Verify premium content unlocks.
- Restart the game.
- Confirm ownership is saved.
- Test purchase restoration.
- Reinstall the game and verify restored purchases.
- Test on multiple devices using the same account.

---

# Best Practices

- Unlock content only after successful purchases.
- Save ownership immediately.
- Hide purchase buttons for already-owned items.
- Clearly indicate owned products in the shop.
- Provide a Restore Purchases button.
- Keep Product IDs consistent across all platforms.
- Separate purchase logic from UI code.

---

# Common Mistakes

Avoid these common issues:

- Unlocking content before purchase confirmation.
- Selling the same permanent item multiple times.
- Forgetting to save ownership.
- Not providing purchase restoration.
- Changing Product IDs after publishing.
- Mixing consumable and non-consumable product types.

---

# Production Tips

For larger projects:

- Manage ownership through a dedicated Purchase Manager.
- Store purchased items in a centralized player profile.
- Sync ownership with cloud services when available.
- Update UI dynamically when purchases are restored.
- Log premium purchases for analytics and customer support.

These practices make your monetization system easier to maintain and scale.

---

# What's Next?

Non-consumables unlock permanent content.

The next guide explains **Subscription Purchases**, which provide recurring premium access through monthly or yearly billing.

You'll learn how to:

- Configure subscriptions
- Handle recurring purchases
- Check subscription status
- Manage premium access

---

# Related Guides

- ← [Consumable Purchases](consumable-purchases.md)
- → [Subscriptions](subscriptions.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Create Products](create-products.md)
6. [Consumable Purchases](consumable-purchases.md)
7. [Subscriptions](subscriptions.md)
8. [Restore Purchases](restore-purchases.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
