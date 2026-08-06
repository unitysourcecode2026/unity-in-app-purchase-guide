# Testing

Testing is one of the most important stages of implementing Unity In-App Purchases (IAP). Before releasing your game, every purchase flow should be thoroughly tested to ensure products are configured correctly, purchases complete successfully, rewards are granted properly, and restoration works as expected.

This guide explains how to test Unity IAP on Android and iOS using Google Play Internal Testing, TestFlight, and sandbox environments.

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

---

# Why Testing Matters

A successful implementation is more than simply displaying a purchase button.

Before publishing your game, verify that:

- Products load correctly
- Prices display correctly
- Purchases complete successfully
- Rewards are granted correctly
- Restore Purchases works
- Subscriptions activate correctly
- Error messages are user-friendly
- UI updates correctly after purchases

Testing helps identify issues before your players encounter them.

---

# Testing on Android

For Android, Unity IAP should be tested using **Google Play Internal Testing**.

Typical workflow:

```text
Create Internal Testing Release
            │
            ▼
Upload APK or AAB
            │
            ▼
Add Test Users
            │
            ▼
Install From Play Store
            │
            ▼
Test Purchases
```

Always install the game from Google Play rather than directly from a local APK when testing purchases.

---

# Testing on iOS

For iOS, use **TestFlight** together with Apple's Sandbox environment.

Typical workflow:

```text
Upload Build

↓

App Store Connect

↓

TestFlight

↓

Invite Testers

↓

Install Game

↓

Test Purchases
```

TestFlight allows subscription renewals and purchase restoration to be tested before release.

---

# Sandbox Accounts

Never test purchases using a real payment account.

Instead:

### Google Play

Use:

- License Testers
- Internal Testing Track

### Apple

Use:

- Sandbox Apple ID
- TestFlight Testers

Sandbox purchases simulate real purchases without charging money.

---

# Test Every Product Type

Verify every product individually.

## Consumables

Examples:

- Coins
- Gems
- Energy
- Hints

Confirm:

- Purchase succeeds
- Rewards are granted
- Multiple purchases work correctly

---

## Non-Consumables

Examples:

- Remove Ads
- Premium Upgrade
- Unlock All Levels

Confirm:

- Purchase succeeds
- Content unlocks
- Purchase restores correctly
- Purchase button disappears after ownership

---

## Subscriptions

Examples:

- VIP Membership
- Monthly Pass
- Premium Membership

Confirm:

- Subscription activates
- Premium content unlocks
- Renewal works (sandbox)
- Expiration behaves correctly
- Restoration succeeds

---

# Test Failed Purchases

Players won't always complete purchases successfully.

Verify handling for:

- Payment cancelled
- Network failure
- Invalid Product ID
- Billing unavailable
- Store temporarily unavailable

Your game should display helpful error messages and continue functioning normally.

---

# Test Restore Purchases

Verify purchase restoration by:

- Purchasing a non-consumable
- Reinstalling the game
- Restoring purchases
- Confirming premium content unlocks

Repeat the process on multiple devices when possible.

---

# Test Receipt Validation

If your game validates receipts:

Verify that:

- Valid receipts succeed
- Invalid receipts fail
- Duplicate receipts are rejected
- Rewards are granted only after validation

---

# Test Different Scenarios

Run tests under different conditions:

- Online
- Offline
- Slow internet
- Device restart
- App restart
- Multiple purchases
- Interrupted purchases

Testing different scenarios helps identify edge cases before release.

---

# Testing Checklist

Before publishing your game, complete the following checklist:

- [ ] All products load correctly
- [ ] Prices display correctly
- [ ] Consumables work
- [ ] Non-consumables work
- [ ] Subscriptions work
- [ ] Restore Purchases works
- [ ] Receipt validation works
- [ ] Failed purchases handled
- [ ] UI updates correctly
- [ ] Player data saves correctly
- [ ] No Console errors
- [ ] No purchase duplication

---

# Common Testing Mistakes

Avoid these common issues:

- Testing with a local APK instead of a store-installed build
- Using real payment accounts
- Forgetting to activate products
- Product IDs don't match
- Testing only one product
- Ignoring failed purchase scenarios
- Not testing restoration

---

# Production Tips

Before releasing your game:

- Test every Product ID.
- Test on multiple devices.
- Test both Android and iOS.
- Keep debug logging enabled during testing.
- Remove unnecessary debug logs before publishing.
- Record purchase failures to simplify troubleshooting.

A thorough testing phase significantly reduces post-launch issues.

---

# What's Next?

Your purchasing system is now implemented and tested.

The next guide covers **Best Practices**, including clean architecture, project organization, security recommendations, and maintenance tips for production-ready Unity IAP implementations.

---

# Related Guides

- ← [Receipt Validation](receipt-validation.md)
- → [Best Practices](best-practices.md)

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
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)
