# Subscriptions

Subscription products provide players with recurring access to premium content through automatic monthly or yearly billing. Unlike consumable and non-consumable purchases, subscriptions remain active until they expire or are cancelled.

This guide explains how to implement subscription products using Unity IAP and manage subscription status in a production-ready mobile game.

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

---

# What is a Subscription?

A subscription is a recurring purchase that grants premium access for a specific billing period.

Billing is handled automatically by Google Play or the Apple App Store.

Common subscription periods include:

- Weekly
- Monthly
- Quarterly
- Yearly

---

# Subscription Examples

Typical subscription products include:

- VIP Membership
- Premium Pass
- Monthly Rewards
- Battle Pass
- Ad-Free Membership
- Unlimited Energy
- Exclusive Content

---

# Typical Purchase Flow

```text
Player selects Subscription
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
Verify Subscription
            │
            ▼
Unlock Premium Features
            │
            ▼
Save Subscription Status
```

---

# Example Product IDs

Use descriptive Product IDs.

```text
com.company.game.vip.monthly

com.company.game.vip.yearly

com.company.game.premium.monthly

com.company.game.battlepass
```

Keep Product IDs identical across Unity, Google Play Console, and App Store Connect.

---

# Register Subscription Products

Register each subscription during Unity IAP initialization.

Example:

```csharp
builder.AddProduct(
    "com.company.game.vip.monthly",
    ProductType.Subscription
);

builder.AddProduct(
    "com.company.game.vip.yearly",
    ProductType.Subscription
);
```

---

# Start a Subscription Purchase

When the player selects a subscription plan, initiate the purchase.

Example:

```csharp
controller.InitiatePurchase(
    "com.company.game.vip.monthly"
);
```

Unity IAP communicates with the appropriate app store and handles the billing process.

---

# Process Successful Purchases

After a successful purchase:

- Verify the Product ID.
- Confirm the subscription is active.
- Unlock premium features.
- Save subscription information.
- Update the user interface.

Example:

```csharp
switch(product.definition.id)
{
    case "com.company.game.vip.monthly":

        EnableVIPFeatures();

        break;
}
```

Only unlock premium features after the purchase has been successfully completed.

---

# Premium Features

Subscription products commonly unlock:

- Exclusive levels
- VIP rewards
- Daily bonuses
- Unlimited energy
- Premium characters
- Faster progression
- Ad-free gameplay
- Exclusive events

Design your subscription benefits to provide ongoing value without creating an unfair gameplay advantage.

---

# Check Subscription Status

Each time the game starts:

- Verify whether the subscription is active.
- Unlock premium content if the subscription is valid.
- Restrict premium features if the subscription has expired.

Avoid assuming a subscription remains active without checking its current status.

---

# Subscription Renewal

Subscriptions renew automatically unless cancelled by the player.

Typical workflow:

```text
Subscription Active

↓

Billing Date

↓

Store Charges Player

↓

Subscription Renewed

↓

Premium Access Continues
```

No additional action is required from the player if renewal succeeds.

---

# Subscription Expiration

A subscription may expire if:

- The player cancels it.
- Payment fails.
- The billing period ends without renewal.

When this happens:

- Remove premium access.
- Keep the player's saved data.
- Allow the player to subscribe again.

Never delete player progress because a subscription has expired.

---

# Restore Subscriptions

Previously purchased subscriptions should be restored when supported by the platform.

Typical workflow:

```text
Player Reinstalls Game

↓

Restore Purchases

↓

Verify Subscription

↓

Unlock Premium Features
```

Always provide a **Restore Purchases** option for users who reinstall the game or switch devices.

---

# Testing Subscriptions

Before publishing:

- Purchase every subscription plan.
- Verify premium content unlocks.
- Test automatic renewal (sandbox).
- Test subscription expiration.
- Test subscription restoration.
- Test cancellation scenarios.
- Restart the game to verify status persistence.

Testing helps ensure a smooth experience for your players.

---

# Best Practices

- Use descriptive Product IDs.
- Verify subscription status at launch.
- Save subscription information securely.
- Clearly display subscription benefits.
- Offer a Restore Purchases option.
- Explain billing terms before purchase.
- Update the UI when subscription status changes.

---

# Common Mistakes

Avoid these common issues:

- Unlocking premium content before purchase confirmation.
- Assuming subscriptions never expire.
- Forgetting to verify subscription status.
- Not handling cancelled subscriptions.
- Using different Product IDs across platforms.
- Failing to test sandbox subscriptions.

---

# Production Tips

For larger games:

- Store subscription status in a dedicated player profile.
- Refresh subscription status when the game starts.
- Separate subscription management from UI logic.
- Log subscription events for analytics.
- Validate receipts for high-value subscription products.

These practices improve reliability and simplify future maintenance.

---

# What's Next?

Now that you've implemented subscriptions, it's time to support players who reinstall your game or switch devices.

The next guide explains **Restore Purchases**, including platform differences between Google Play and the Apple App Store.

---

# Related Guides

- ← [Non-Consumable Purchases](non-consumables.md)
- → [Restore Purchases](restore-purchases.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
4. [Unity Gaming Services](unity-gaming-services.md)
5. [Create Products](create-products.md)
6. [Consumable Purchases](consumable-purchases.md)
7. [Non-Consumable Purchases](non-consumables.md)
8. [Restore Purchases](restore-purchases.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
