# Prerequisites

Before integrating Unity In-App Purchases (IAP), ensure your development environment, Unity project, and store accounts are properly configured. Completing these requirements first will help you avoid common setup issues later in the integration process.

---

# Required Software

Install the following software before getting started:

- Unity Hub
- Unity Editor (2022 LTS or newer recommended)
- Visual Studio or JetBrains Rider
- Git (optional but recommended)

Keeping your tools updated ensures compatibility with the latest Unity Gaming Services and Unity IAP packages.

---

# Unity Version

This guide recommends using:

- Unity 2022 LTS
- Unity 6 (latest stable release)

Older versions may work, but some menus and package versions can differ.

---

# Unity Gaming Services Account

Unity IAP is integrated with Unity Gaming Services (UGS).

Before continuing, you should have:

- A Unity account
- Access to the Unity Dashboard
- A Unity Project created
- Unity Gaming Services enabled for the project

You'll configure Unity Gaming Services in the next guide.

---

# Store Accounts

To publish and test purchases, you'll need developer accounts for the platforms you support.

## Google Play

Requirements:

- Google Play Developer Account
- Published application (Internal Testing is sufficient)
- Google Play Console access

---

## Apple App Store

Requirements:

- Apple Developer Program membership
- App Store Connect access
- Registered App ID
- TestFlight (recommended for testing)

---

# Unity Packages

Install these packages using the Unity Package Manager.

Required packages include:

- In-App Purchasing (Unity IAP)
- Unity Gaming Services Core

Additional packages may be installed automatically depending on your Unity version.

---

# Internet Connection

A stable internet connection is required when:

- Signing in to Unity
- Accessing Unity Gaming Services
- Installing packages
- Connecting to Google Play
- Connecting to App Store Connect

---

# Basic Knowledge

You don't need advanced programming experience, but you should be familiar with:

- Unity Editor
- Scenes
- GameObjects
- C# scripting
- Unity Package Manager

If you're new to Unity, it's recommended to complete a basic Unity tutorial before implementing in-app purchases.

---

# Create a Test Project

If you're learning Unity IAP for the first time, create a dedicated test project before integrating purchases into a production game.

A separate project allows you to:

- Experiment safely
- Learn the purchase workflow
- Test product configurations
- Debug errors more easily

Once you're comfortable with the setup, you can apply the same workflow to your main project.

---

# Before You Continue

Make sure you've completed the following checklist:

- [ ] Unity Hub installed
- [ ] Unity 2022 LTS or newer installed
- [ ] Unity project created
- [ ] Unity account available
- [ ] Unity Gaming Services ready
- [ ] Google Play Developer Account (Android)
- [ ] Apple Developer Account (iOS)
- [ ] Stable internet connection
- [ ] Basic Unity knowledge

Completing these prerequisites will make the installation process much smoother.

---

# Related Guides

- ← [Introduction](introduction.md)
- → [Install Unity IAP](install-unity-iap.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
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
