# Introduction

Welcome to the **Unity In-App Purchase Guide**, a production-focused documentation repository designed to help Unity developers implement reliable and scalable in-app purchases (IAP) for Android and iOS games.

Whether you're creating your first mobile game or expanding an existing project with monetization, this guide walks through the complete purchasing workflow using **Unity Gaming Services (UGS)** and the **Unity IAP** package.

Unlike many tutorials that only demonstrate a simple purchase button, this repository focuses on building a purchasing system that is suitable for real-world production environments. The documentation covers project setup, product configuration, purchase processing, testing, restoration, receipt validation, troubleshooting, and recommended architecture.

---

# What You'll Learn

By following this guide, you'll learn how to:

- Install and configure Unity IAP
- Connect a Unity project with Unity Gaming Services
- Create products for Google Play and the App Store
- Configure Consumable products
- Configure Non-Consumable products
- Configure Subscription products
- Process purchases securely
- Restore purchases on iOS
- Validate purchase receipts
- Test purchases before publishing
- Handle common purchasing errors
- Follow production-ready best practices

---

# Who This Guide Is For

This repository is suitable for:

- Beginner Unity developers
- Indie game developers
- Mobile game studios
- Freelance Unity developers
- Students learning game monetization
- Developers publishing on Google Play
- Developers publishing on the Apple App Store

No previous experience with Unity IAP is required, although basic knowledge of the Unity Editor and C# is recommended.

---

# Why Unity IAP?

Instead of implementing separate billing systems for Android and iOS, Unity IAP provides a unified API that allows developers to manage purchases through a single codebase.

Benefits include:

- One purchasing API for Android and iOS
- Integration with Unity Gaming Services
- Support for multiple product types
- Simplified purchase restoration
- Built-in testing workflow
- Cross-platform development
- Easier maintenance

---

# Supported Product Types

This guide explains how to implement all major purchase types.

## Consumables

Products that players can purchase multiple times.

Examples:

- Coins
- Gems
- Energy
- Hints
- Extra Lives

---

## Non-Consumables

Products purchased once and owned permanently.

Examples:

- Remove Ads
- Premium Upgrade
- Unlock All Levels
- Character Packs

---

## Subscriptions

Recurring purchases that provide ongoing access to content or premium features.

Examples:

- VIP Membership
- Monthly Rewards
- Premium Pass
- Exclusive Content

---

# Repository Structure

```
unity-in-app-purchase-guide/

docs/
code/
screenshots/
assets/
README.md
LICENSE
```

The **docs/** folder contains detailed implementation guides.

The **code/** folder includes reusable C# examples that demonstrate production-ready purchasing workflows.

The **screenshots/** folder stores setup images for Unity, Google Play Console, and App Store Connect.

The **assets/** folder contains diagrams and supporting resources used throughout the documentation.

---

# Learning Path

For the best experience, read the documentation in this order:

1. [Prerequisites](prerequisites.md)
2. [Install Unity IAP](install-unity-iap.md)
3. [Unity Gaming Services](unity-gaming-services.md)
4. [Create Products](create-products.md)
5. [Consumable Purchases](consumable-purchases.md)
6. [Non-Consumables](non-consumables.md)
7. [Subscriptions](subscriptions.md)
8. [Restore Purchases](restore-purchases.md)
9. [Receipt Validation](receipt-validation.md)
10. [Testing](testing.md)
11. [Best Practices](best-practices.md)
12. [Common Errors](common-errors.md)
13. [FAQ](faq.md)

Following this sequence will help you build a complete purchasing system from initial setup to production deployment.

---

# Production Focus

Every section in this repository is written with maintainability in mind.

Rather than encouraging quick fixes or copy-and-paste implementations, the examples promote clean architecture, reusable code, and workflows that can scale as your project grows.

The goal is to help developers build purchasing systems that remain reliable throughout development, testing, and live operation.

---

# Next Step

Continue to the next guide:

➡ **Prerequisites**

Before integrating Unity IAP, ensure your development environment, Unity version, Unity Gaming Services configuration, and store accounts are properly prepared.
