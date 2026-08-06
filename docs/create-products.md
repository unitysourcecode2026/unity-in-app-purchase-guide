# Create Products

Before players can purchase items in your game, you need to create products in both Unity and your app store dashboards. Each product must have a unique Product ID that matches across Unity, Google Play Console, and App Store Connect.

This guide explains how to create and organize your products for a production-ready Unity IAP implementation.

---

# Before You Begin

Complete the previous guides before continuing:

- [Introduction](introduction.md)
- [Prerequisites](prerequisites.md)
- [Install Unity IAP](install-unity-iap.md)
- [Unity Gaming Services](unity-gaming-services.md)

---

# What is a Product?

A product represents an item that players can purchase inside your game.

Examples include:

- Coin Packs
- Remove Ads
- Premium Upgrade
- Character Packs
- VIP Membership
- Battle Pass
- Monthly Subscription

Each product has:

- Product ID
- Display Name
- Description
- Price
- Product Type

---

# Product Types

Unity IAP supports three primary product types.

## Consumable

Consumable products can be purchased multiple times.

Examples:

- Coins
- Gems
- Energy
- Hints
- Lives

---

## Non-Consumable

These products are purchased once and permanently unlocked.

Examples:

- Remove Ads
- Premium Version
- Unlock All Levels
- Character Bundle

---

## Subscription

Subscriptions provide recurring access to premium content.

Examples:

- VIP Membership
- Monthly Pass
- Premium Access
- Exclusive Rewards

---

# Create Product IDs

Every product requires a unique Product ID.

Example naming convention:

```
com.company.game.coin100

com.company.game.coin500

com.company.game.removeads

com.company.game.premium

com.company.game.vip.monthly
```

### Best Practices

- Use lowercase letters.
- Avoid spaces.
- Keep IDs permanent.
- Never change a Product ID after publishing.
- Use descriptive names.

---

# Product Naming Tips

A good Product ID should clearly describe the item.

Good examples:

```
coin100
coin500
removeads
premiumupgrade
starterpack
monthlyvip
```

Avoid names like:

```
item1
product2
abc123
testproduct
```

Clear naming makes long-term maintenance much easier.

---

# Configure Products in Unity

Once Unity IAP is installed, you'll add products to your purchasing system.

Each product should include:

- Product ID
- Product Type
- Localized Title
- Localized Description

Unity uses this information to communicate with the app stores during the purchase process.

---

# Configure Products in Google Play Console

For Android games, create matching products in Google Play Console.

Each product must use the exact same Product ID as your Unity project.

Example:

| Product | Product ID |
|---------|------------|
| 100 Coins | `com.company.game.coin100` |
| Remove Ads | `com.company.game.removeads` |
| Monthly VIP | `com.company.game.vip.monthly` |

Any mismatch will cause purchases to fail.

---

# Configure Products in App Store Connect

For iOS games, create the same products in App Store Connect.

Ensure that:

- Product IDs are identical to Unity.
- Pricing is configured.
- Products are approved before release.
- Localizations are complete.

---

# Organize Your Products

As your game grows, organizing products becomes increasingly important.

Example:

```
Coins

- coin100
- coin500
- coin1000

Premium

- removeads
- premiumupgrade

Subscriptions

- vip.monthly
- vip.yearly
```

This structure makes product management much easier.

---

# Common Mistakes

Avoid these common configuration errors:

- Different Product IDs between Unity and store dashboards
- Using spaces in Product IDs
- Renaming published Product IDs
- Incorrect product type selection
- Forgetting to activate products in the store console

These mistakes are among the most common causes of purchase failures.

---

# Best Practices

- Plan all Product IDs before development.
- Use consistent naming conventions.
- Group similar products together.
- Test every product before release.
- Keep a document listing all Product IDs used in your project.

---

# Verify Your Products

Before continuing, confirm the following:

- [ ] All Product IDs created
- [ ] Product types selected correctly
- [ ] Google Play products configured
- [ ] App Store products configured
- [ ] Product IDs match exactly across all platforms
- [ ] Products activated in the store dashboards

---

# What's Next?

Now that your products have been created, it's time to implement purchasing logic.

We'll start with **Consumable Purchases**, which are the most common product type in mobile games.

You'll learn how to:

- Register consumable products
- Process purchases
- Reward players
- Handle successful and failed transactions

---

# Related Guides

- ← [Unity Gaming Services](unity-gaming-services.md)
- → [Consumable Purchases](consumable-purchases.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Consumable Purchases](consumable-purchases.md)
6. [Non-Consumables](non-consumables.md)
7. [Subscriptions](subscriptions.md)
8. [Restore Purchases](restore-purchases.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
