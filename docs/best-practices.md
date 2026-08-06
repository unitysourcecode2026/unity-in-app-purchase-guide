# Best Practices

Building a successful Unity In-App Purchase (IAP) system involves more than making purchases work. A production-ready implementation should be secure, maintainable, scalable, and easy to extend as your game grows.

This guide shares recommended practices used by professional Unity developers to create reliable purchasing systems for Android and iOS.

---

# Before You Begin

Complete the previous guides before continuing:

- [Introduction](introduction.md)
- [Prerequisites](prerequisites.md)
- [Install Unity IAP](install-unity-iap.md)
- [Unity Gaming Services](unity-gaming-services.md)
- [Create Products](create-products.md)
- [Consumable Purchases](consumable-purchases.md)
- [Non-Consumable Purchases](non-consumables.md)
- [Subscriptions](subscriptions.md)
- [Restore Purchases](restore-purchases.md)
- [Receipt Validation](receipt-validation.md)
- [Testing](testing.md)

---

# Keep Purchase Logic Separate

Avoid placing purchase code inside UI buttons or gameplay scripts.

Instead, create a dedicated purchase manager.

Example structure:

```text
UI Button
      │
      ▼
IAP Manager
      │
      ▼
Unity IAP
      │
      ▼
Store
```

Keeping responsibilities separated makes the project easier to maintain and test.

---

# Use a Dedicated IAP Manager

A single manager should handle:

- Product initialization
- Purchase requests
- Purchase processing
- Restore purchases
- Receipt validation
- Error handling

Avoid duplicating purchase logic across multiple scripts.

---

# Organize Product IDs

Store Product IDs in one location instead of hardcoding them throughout your project.

Example:

```csharp
public static class ProductIds
{
    public const string Coin100 =
        "com.company.game.coin100";

    public const string RemoveAds =
        "com.company.game.removeads";

    public const string MonthlyVIP =
        "com.company.game.vip.monthly";
}
```

This makes future updates much easier.

---

# Use Clear Naming Conventions

Choose Product IDs that clearly describe their purpose.

Good examples:

```text
coin100
coin500
removeads
premiumupgrade
vip.monthly
```

Avoid:

```text
item1
test
abc123
purchase
```

Readable names simplify debugging and maintenance.

---

# Never Grant Rewards Too Early

A purchase should follow this order:

```text
Purchase Complete
        │
        ▼
Validate Purchase
        │
        ▼
Grant Reward
        │
        ▼
Save Player Data
```

Granting rewards before purchase confirmation can lead to duplicate rewards or unauthorized unlocks.

---

# Save Player Data Immediately

After a successful purchase:

- Save player progress.
- Save purchased items.
- Save premium status.
- Update cloud data if applicable.

This reduces the risk of players losing purchases due to crashes or unexpected interruptions.

---

# Always Support Purchase Restoration

Provide a Restore Purchases option for eligible products.

Restore:

- Non-Consumables
- Subscriptions

Do not restore:

- Coins
- Gems
- Energy
- Other consumables

---

# Validate High-Value Purchases

Receipt validation helps protect your game from fraudulent purchases.

Recommended for:

- Premium Upgrades
- Remove Ads
- Character Packs
- Subscriptions
- Expensive IAP items

Server-side validation provides the strongest protection for production games.

---

# Display Clear Purchase Feedback

Players should always know what's happening.

Examples:

- Loading purchase...
- Purchase successful.
- Purchase cancelled.
- Purchase failed.
- Restoring purchases...
- Purchases restored successfully.

Clear feedback improves the overall user experience.

---

# Handle Errors Gracefully

Always prepare for unexpected situations.

Examples include:

- Network unavailable
- Store unavailable
- Billing disabled
- Invalid Product ID
- Purchase cancelled

Avoid exposing technical error messages to players.

---

# Keep the Shop UI Updated

After every purchase:

- Refresh owned items.
- Hide purchased products.
- Display premium status.
- Update virtual currency.
- Disable unavailable purchase buttons.

A responsive interface prevents confusion.

---

# Test Every Product

Before every release:

- Test every Product ID.
- Test every platform.
- Test subscriptions.
- Test restoration.
- Test failed purchases.
- Test receipt validation.

Never assume one successful purchase means everything works.

---

# Log Purchase Events

Logging helps diagnose issues during development.

Useful information includes:

- Product ID
- Transaction ID
- Purchase status
- Restore events
- Validation result

Avoid logging sensitive receipt information in production builds.

---

# Plan for Future Expansion

Design your purchasing system so new products can be added with minimal code changes.

For example:

Instead of rewriting purchasing logic for every new item, simply register the new Product ID and update your reward system.

This approach scales much better for games with large stores.

---

# Recommended Folder Structure

A clean project structure keeps purchasing code organized.

```text
Scripts/

├── IAP/
│   ├── IAPManager.cs
│   ├── ProductIds.cs
│   ├── PurchaseHandler.cs
│   ├── ReceiptValidator.cs
│   └── RestoreManager.cs
│
├── UI/
│   ├── ShopUI.cs
│   └── PurchasePopup.cs
│
└── Player/
    └── PlayerData.cs
```

Organizing related scripts together makes navigation and maintenance easier.

---

# Production Checklist

Before releasing your game:

- [ ] Product IDs organized
- [ ] Purchase manager implemented
- [ ] Restore purchases supported
- [ ] Receipt validation enabled
- [ ] UI updates correctly
- [ ] Player data saved
- [ ] Failed purchases handled
- [ ] Purchases tested on Android
- [ ] Purchases tested on iOS
- [ ] Debug logs reviewed

Completing this checklist helps reduce post-launch issues.

---

# What's Next?

Even with a well-designed purchasing system, unexpected issues can still occur.

The next guide covers **Common Errors**, explaining the most frequent Unity IAP problems, their causes, and practical solutions.

---

# Related Guides

- ← [Testing](testing.md)
- → [Common Errors](common-errors.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Create Products](create-products.md)
6. [Consumable Purchases](consumable-purchases.md)
7. [Non-Consumable Purchases](non-consumables.md)
8. [Subscriptions](subscriptions.md)
9. [Restore Purchases](restore-purchases.md)
10. [Receipt Validation](receipt-validation.md)
11. [Testing](testing.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
