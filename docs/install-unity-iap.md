# Install Unity IAP

Unity In-App Purchasing (Unity IAP) is provided as an official package through the Unity Package Manager. This guide explains how to install and verify the package before configuring your products.

---

# Before You Begin

Ensure you've completed the requirements listed in the [Prerequisites](prerequisites.md) guide.

Recommended:

- Unity 2022 LTS or newer
- Unity project created
- Unity account signed in
- Internet connection available

---

# Step 1 — Open Your Unity Project

Launch **Unity Hub** and open the project where you want to implement In-App Purchases.

Wait until the project finishes importing before proceeding.

---

# Step 2 — Open Package Manager

In the Unity Editor, navigate to:

```
Window
└── Package Manager
```

The Package Manager allows you to install official Unity packages.

---

# Step 3 — Select Unity Registry

At the top-left of the Package Manager window:

```
Packages:
▼ Unity Registry
```

Selecting **Unity Registry** displays all official Unity packages.

---

# Step 4 — Search for In-App Purchasing

Use the search box and type:

```
In-App Purchasing
```

Select the package published by **Unity Technologies**.

---

# Step 5 — Install the Package

Click:

```
Install
```

Unity will automatically download and install:

- Unity IAP
- Required dependencies
- Unity Gaming Services components (if needed)

Wait until installation completes.

---

# Step 6 — Restart Unity (If Prompted)

Some Unity versions recommend restarting the Editor after installation.

If prompted:

```
Save Project
↓

Restart Unity
```

This ensures all package dependencies are initialized correctly.

---

# Step 7 — Verify Installation

Open the Package Manager again.

Locate:

```
In-App Purchasing
```

You should see:

- Installed
- Current package version
- Documentation links
- Package information

If the package appears as installed, Unity IAP is ready to use.

---

# Step 8 — Check Services Window

Navigate to:

```
Window
└── General
    └── Services
```

If the Services window opens successfully, your project is ready for Unity Gaming Services configuration.

We'll configure these services in the next guide.

---

# Common Installation Issues

## Package Not Found

Possible causes:

- Unity Registry not selected
- No internet connection
- Package Manager failed to refresh

Solution:

- Refresh Package Manager
- Restart Unity
- Check your internet connection

---

## Installation Failed

Possible causes:

- Firewall restrictions
- Proxy configuration
- Unity Package Server unavailable

Solution:

- Restart Unity
- Retry installation
- Update Unity Hub

---

## Missing Dependencies

If Unity reports missing dependencies:

1. Close Unity
2. Reopen the project
3. Allow Package Manager to resolve dependencies automatically

---

# Verify Everything Works

After installation, confirm the following:

- [ ] Unity IAP package installed
- [ ] No Package Manager errors
- [ ] Unity project opens normally
- [ ] Services window available
- [ ] Console has no package-related errors

If all items are checked, you're ready to configure Unity Gaming Services.

---

# What's Next?

Installing Unity IAP adds the purchasing framework to your project, but purchases won't work until Unity Gaming Services is connected.

The next guide explains how to link your Unity project with Unity Gaming Services and prepare it for creating store products.

---

# Related Guides

- ← [Prerequisites](prerequisites.md)
- → [Unity Gaming Services](unity-gaming-services.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
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
