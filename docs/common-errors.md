# Common Errors

Even with a properly configured Unity In-App Purchase (IAP) system, you may occasionally encounter issues during development, testing, or production. Most problems are caused by incorrect configuration, mismatched Product IDs, missing store settings, or network-related issues.

This guide covers the most common Unity IAP errors, explains why they occur, and provides practical solutions to help you resolve them quickly.

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
- [Best Practices](best-practices.md)

---

# Products Not Loading

## Symptoms

- Store appears empty
- Purchase buttons remain disabled
- Product information is missing

## Possible Causes

- Incorrect Product IDs
- Products not created in the store
- Unity IAP not initialized
- No internet connection

## Solution

- Verify Product IDs match exactly.
- Confirm products are active in Google Play Console or App Store Connect.
- Wait for Unity IAP initialization before enabling purchase buttons.
- Test with an active internet connection.

---

# Purchase Failed

## Symptoms

- Purchase window closes unexpectedly
- Transaction does not complete
- Error message displayed

## Possible Causes

- User cancelled the purchase
- Billing service unavailable
- Network issue
- Product unavailable

## Solution

- Handle cancelled purchases gracefully.
- Check internet connectivity.
- Verify the product is active.
- Test using a sandbox account.

---

# Invalid Product ID

## Symptoms

- Purchase cannot start
- Product not found

## Possible Causes

- Typographical error
- Product ID mismatch
- Product not registered

## Solution

Compare Product IDs across:

- Unity Project
- Google Play Console
- App Store Connect

Every Product ID must match exactly.

---

# Unity IAP Initialization Failed

## Symptoms

- Store never becomes available
- Initialization callback reports failure

## Possible Causes

- Unity Gaming Services not configured
- Internet unavailable
- Package installation issue

## Solution

- Verify Unity Gaming Services setup.
- Confirm Unity IAP package installation.
- Restart Unity.
- Check Console for initialization errors.

---

# Restore Purchases Doesn't Work

## Symptoms

- Previously purchased items are missing

## Possible Causes

- Wrong account
- Attempting to restore consumables
- Store communication issue

## Solution

- Sign in using the original store account.
- Restore only non-consumables and subscriptions.
- Verify internet connectivity.

---

# Subscription Not Detected

## Symptoms

- Premium content remains locked
- Subscription appears inactive

## Possible Causes

- Subscription expired
- Validation failed
- Incorrect Product ID

## Solution

- Verify subscription status.
- Refresh purchase information.
- Confirm Product IDs.

---

# Receipt Validation Failed

## Symptoms

- Purchase completes but rewards are not granted

## Possible Causes

- Invalid receipt
- Corrupted receipt
- Validation logic error

## Solution

- Test with valid sandbox purchases.
- Verify validation implementation.
- Check server logs if using backend validation.

---

# Duplicate Rewards

## Symptoms

- Player receives the same reward multiple times

## Possible Causes

- Purchase processed twice
- Missing transaction tracking
- Duplicate callbacks

## Solution

- Track transaction IDs.
- Complete transactions properly.
- Prevent duplicate reward processing.

---

# Prices Not Displaying

## Symptoms

- Shop displays blank prices
- Placeholder text appears

## Possible Causes

- Products not loaded
- Initialization incomplete
- Store connection failed

## Solution

Display prices only after Unity IAP finishes loading product metadata.

---

# Purchases Work in Editor but Not on Device

## Symptoms

- Testing succeeds in Unity Editor
- Device purchases fail

## Possible Causes

- Local build installed manually
- Store configuration incomplete
- Test account missing

## Solution

- Install builds through Google Play Internal Testing or TestFlight.
- Use sandbox accounts.
- Verify store configuration.

---

# Build Rejected by App Store

## Possible Causes

- Missing Restore Purchases option
- Incorrect subscription information
- Incomplete product metadata

## Solution

- Add a Restore Purchases button.
- Complete App Store Connect configuration.
- Review Apple's submission guidelines.

---

# Debugging Tips

When troubleshooting:

- Read Unity Console messages carefully.
- Check Product IDs first.
- Confirm Unity IAP initialization succeeds.
- Verify store configuration.
- Test on physical devices.
- Enable debug logging during development.

---

# Troubleshooting Checklist

Before searching for advanced solutions, verify:

- [ ] Unity IAP installed
- [ ] Unity Gaming Services configured
- [ ] Product IDs match
- [ ] Products active in store dashboards
- [ ] Internet connection available
- [ ] Sandbox account configured
- [ ] Purchase restoration tested
- [ ] Receipt validation tested
- [ ] Android tested
- [ ] iOS tested

Most Unity IAP issues can be resolved by carefully reviewing these items.

---

# Production Tips

When debugging production builds:

- Log initialization status.
- Log Product IDs.
- Log transaction IDs.
- Log purchase failures.
- Monitor analytics for failed transactions.
- Avoid exposing sensitive purchase information in logs.

Good logging significantly reduces debugging time after release.

---

# What's Next?

You now know how to identify and resolve the most common Unity IAP issues.

The final guide in this repository answers frequently asked questions from Unity developers and provides quick references for common implementation scenarios.

---

# Related Guides

- ← [Best Practices](best-practices.md)
- → [FAQ](faq.md)

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
12. [Best Practices](best-practices.md)
13. [FAQ](faq.md)
