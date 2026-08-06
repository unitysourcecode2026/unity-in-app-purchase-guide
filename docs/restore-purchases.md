# Restore Purchases

Restore Purchases allows players to recover previously purchased **Non-Consumable** products and **Subscriptions** after reinstalling the game or switching to a new device.

Providing a reliable restore mechanism is an important part of a good user experience and is required for many App Store submissions.

This guide explains how purchase restoration works in Unity IAP, platform differences, implementation examples, and production-ready best practices.

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

---

# What is Purchase Restoration?

Purchase restoration allows players to recover previously owned purchases without paying again.

Common examples include:

- Remove Ads
- Premium Upgrade
- Character Packs
- VIP Membership
- Monthly Subscription
- Yearly Subscription

Consumable purchases such as coins, gems, and energy are **not restored** because they are considered consumed after use.

---

# Which Products Can Be Restored?

| Product Type | Can Be Restored |
|--------------|-----------------|
| Consumable | ❌ No |
| Non-Consumable | ✅ Yes |
| Subscription | ✅ Yes |

---

# Why Restore Purchases?

Players may need to restore purchases if they:

- Buy a new phone
- Reinstall the game
- Reset their device
- Delete app data
- Install the game on another device using the same store account

Without restoration, players could lose access to content they already purchased.

---

# Platform Differences

## Apple App Store

Apple requires developers to provide a **Restore Purchases** option.

Players must manually tap a restore button.

Typical flow:

```text
Player taps Restore Purchases
            │
            ▼
Unity requests previous purchases
            │
            ▼
Apple verifies account
            │
            ▼
Owned products returned
            │
            ▼
Game restores purchases
```

---

## Google Play

Google Play automatically returns previously owned non-consumables and active subscriptions when the player signs in with the same Google account.

In most cases, no manual restore action is required.

However, providing a **Restore Purchases** button creates a consistent user experience across platforms.

---

# Create a Restore Button

A Restore Purchases button should be easy to find.

Recommended locations:

- Settings
- Shop
- Premium Store
- Account Screen

Avoid hiding this feature deep inside the interface.

---

# Example Restore Method

Unity IAP provides platform-specific APIs for restoring purchases.

Example:

```csharp
public void RestorePurchases()
{
    if (Application.platform == RuntimePlatform.IPhonePlayer ||
        Application.platform == RuntimePlatform.OSXPlayer)
    {
        var apple =
            m_ExtensionProvider.GetExtension<IAppleExtensions>();

        apple.RestoreTransactions(result =>
        {
            Debug.Log("Restore completed: " + result);
        });
    }
}
```

This method requests Apple to return all previously owned purchases.

---

# Restore Purchased Content

After restoration succeeds:

- Verify each Product ID.
- Unlock owned content.
- Restore premium features.
- Save ownership locally.
- Refresh the user interface.

Typical workflow:

```text
Restore Successful

↓

Verify Product

↓

Unlock Feature

↓

Save Ownership

↓

Refresh UI
```

---

# Handle Restore Failures

Restoration may fail for several reasons:

- No previous purchases
- Wrong Apple ID or Google Account
- Internet connection issues
- Store temporarily unavailable

Show clear messages such as:

- "No purchases were found."
- "Please check your internet connection."
- "Restore failed. Please try again."

Avoid displaying technical error messages to players.

---

# Testing Restore Purchases

Before releasing your game:

- Purchase a non-consumable product.
- Reinstall the game.
- Restore purchases.
- Verify premium content unlocks.
- Test subscriptions.
- Test with multiple devices.
- Test using sandbox accounts.
- Verify UI updates correctly.

---

# Best Practices

- Always provide a Restore Purchases button.
- Restore purchases automatically when appropriate.
- Save restored ownership immediately.
- Update the shop interface after restoration.
- Inform players when restoration completes.
- Test on both Android and iOS.

---

# Common Mistakes

Avoid these common issues:

- Attempting to restore consumable products.
- Forgetting to update the UI.
- Not saving restored ownership.
- Hiding the Restore Purchases button.
- Not testing on real devices.
- Assuming Android and iOS behave identically.

---

# Production Tips

For production games:

- Centralize restoration logic in your `IAPManager`.
- Log restoration events for debugging.
- Restore purchases during account recovery.
- Synchronize restored ownership with cloud saves if supported.
- Keep restoration logic separate from purchase logic.

This makes future maintenance easier and improves long-term reliability.

---

# What's Next?

Restoring purchases helps players recover previously owned content, but it doesn't confirm whether a purchase receipt is genuine.

The next guide explains **Receipt Validation**, including why it's important, how it works, and how to improve the security of your in-app purchase system.

---

# Related Guides

- ← [Subscriptions](subscriptions.md)
- → [Receipt Validation](receipt-validation.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Create Products](create-products.md)
6. [Consumable Purchases](consumable-purchases.md)
7. [Non-Consumable Purchases](non-consumables.md)
8. [Subscriptions](subscriptions.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
