# Frequently Asked Questions (FAQ)

This FAQ answers some of the most common questions developers have when implementing Unity In-App Purchases (IAP). Whether you're building your first mobile game or maintaining a production title, these answers can help you avoid common pitfalls and better understand how Unity IAP works.

---

# Before You Begin

If you're new to Unity IAP, we recommend reading the documentation in order:

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
- [Best Practices](best-practices.md)
- [Common Errors](common-errors.md)

---

# General Questions

## What is Unity IAP?

Unity In-App Purchasing (IAP) is Unity's official solution for selling digital products inside mobile games. It provides a single API for integrating purchases across multiple platforms, including Google Play and the Apple App Store.

---

## Which platforms are supported?

Unity IAP supports several platforms, including:

- Android (Google Play)
- iOS (Apple App Store)
- macOS (limited scenarios)

Always check the latest Unity documentation for current platform support.

---

## Which Unity version should I use?

This guide recommends:

- Unity 2022 LTS or newer
- Unity 6 (latest stable release)

Using an LTS version is generally recommended for production projects.

---

# Product Questions

## What is the difference between Consumable and Non-Consumable products?

**Consumables** can be purchased multiple times.

Examples:

- Coins
- Gems
- Energy
- Hints

**Non-Consumables** are purchased once and permanently unlocked.

Examples:

- Remove Ads
- Premium Upgrade
- Unlock All Levels

---

## What is a Subscription?

A subscription provides recurring access to premium content through automatic billing.

Examples include:

- VIP Membership
- Monthly Pass
- Premium Access

Subscriptions remain active until they expire or are cancelled.

---

## Can I change a Product ID after publishing?

No.

Changing a published Product ID will break existing purchases because the app stores use the Product ID as the permanent identifier.

Choose clear Product IDs before releasing your game.

---

# Purchase Questions

## Why isn't my purchase button working?

Common reasons include:

- Unity IAP has not finished initializing.
- Products are not configured.
- Product IDs do not match.
- Internet connection is unavailable.

Always wait for Unity IAP initialization before enabling purchase buttons.

---

## Why are my products not loading?

Check the following:

- Product IDs
- Unity IAP initialization
- Google Play Console configuration
- App Store Connect configuration
- Internet connection

---

## Why does my purchase fail?

Possible reasons include:

- Player cancelled the purchase
- Billing service unavailable
- Network issues
- Product unavailable
- Invalid Product ID

Always handle failed purchases gracefully and display a helpful message.

---

# Restore Purchases

## Which purchases can be restored?

You can restore:

- Non-Consumables
- Subscriptions

Consumables such as coins, gems, and energy are not restored automatically.

---

## Do I need a Restore Purchases button?

Yes.

Providing a Restore Purchases option is strongly recommended, especially for iOS, where players are expected to manually restore eligible purchases.

---

# Security Questions

## Should I validate receipts?

Yes.

Receipt validation helps verify that purchases are legitimate before granting premium content or rewards.

For games with subscriptions or expensive purchases, server-side validation is recommended.

---

## Is client-side validation enough?

Client-side validation provides basic protection but can be bypassed on compromised devices.

Server-side validation offers stronger security and is preferred for production games.

---

# Testing Questions

## Can I test purchases without spending money?

Yes.

Use:

**Android**

- Google Play Internal Testing
- License Testers

**iOS**

- TestFlight
- Sandbox Apple IDs

These environments simulate real purchases without charging users.

---

## Can I test in the Unity Editor?

The Unity Editor is useful for testing your UI and purchase flow, but real store transactions should always be tested using Google Play Internal Testing or TestFlight.

---

# Best Practices

## Where should I store Product IDs?

Store all Product IDs in one location, such as:

- Constants
- Static class
- ScriptableObject

Avoid hardcoding Product IDs throughout your project.

---

## Should I create an IAP Manager?

Yes.

A dedicated `IAPManager` keeps purchasing logic organized and separates it from UI and gameplay systems.

---

## Should I save purchases immediately?

Yes.

After a successful purchase:

- Grant the reward.
- Save player data.
- Update the user interface.

Saving immediately helps prevent data loss.

---

# Troubleshooting

## Purchases work on Android but not iOS. Why?

Possible causes include:

- Missing App Store configuration
- Incorrect Product IDs
- Sandbox account issues
- Store review status

Verify each platform independently.

---

## Purchases worked before but suddenly stopped.

Check:

- Product status in the store
- Unity IAP package updates
- Store account changes
- Internet connectivity
- Recent project modifications

Review the Unity Console for additional error information.

---

# Additional Resources

Continue learning with the rest of the documentation:

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
- [Best Practices](best-practices.md)
- [Common Errors](common-errors.md)

---

# Congratulations!

You've completed the **Unity In-App Purchase Guide** documentation.

You now understand how to:

- Configure Unity IAP
- Connect Unity Gaming Services
- Create products
- Implement consumables
- Implement non-consumables
- Implement subscriptions
- Restore purchases
- Validate receipts
- Test purchases
- Follow production-ready best practices
- Troubleshoot common issues

The next step is to explore the reusable C# examples in the repository's **`code/`** folder and adapt them to your own Unity project.

We hope this guide helps you build secure, reliable, and maintainable in-app purchase systems for your games.

Happy coding! 🚀
