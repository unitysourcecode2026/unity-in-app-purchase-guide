# Unity Gaming Services

Unity Gaming Services (UGS) provides the cloud infrastructure that powers many Unity features, including In-App Purchases (IAP), Authentication, Cloud Save, Analytics, and more.

Before you can configure products or process purchases, your Unity project must be connected to Unity Gaming Services.

This guide explains how to connect your project and verify that everything is configured correctly.

---

# What is Unity Gaming Services?

Unity Gaming Services is a collection of online services designed to help developers build, manage, and monetize games.

Some commonly used services include:

- Unity In-App Purchases (IAP)
- Authentication
- Analytics
- Cloud Save
- Cloud Code
- Economy
- Remote Config
- Leaderboards

For this guide, we'll focus on the services required for Unity IAP.

---

# Before You Begin

Make sure you've completed:

- [Introduction](introduction.md)
- [Prerequisites](prerequisites.md)
- [Install Unity IAP](install-unity-iap.md)

---

# Step 1 — Sign In to Unity

Open your Unity project.

In the top-right corner of the Unity Editor, sign in using your Unity account.

```
Unity Editor

Profile
↓

Sign In
```

If you're already signed in, you can continue to the next step.

---

# Step 2 — Open the Services Window

Navigate to:

```
Window
└── General
    └── Services
```

If you're using Unity 6, Unity may automatically guide you to the Services setup page.

---

# Step 3 — Link Your Project

If your project is not already linked:

Click:

```
Link Project
```

Then:

- Select your Organization
- Choose an existing Project

or

- Create a new Unity Project from the dashboard

Click **Link**.

---

# Step 4 — Verify the Connection

Once linked, your project should display:

- Organization Name
- Project Name
- Project ID
- Connected status

This confirms that your Unity project is connected to Unity Gaming Services.

---

# Step 5 — Enable Required Services

Depending on your Unity version, you may be prompted to enable services.

For Unity IAP, ensure the following services are available:

- Core Services
- In-App Purchasing

Other services such as Analytics or Authentication can be enabled later if your game requires them.

---

# Step 6 — Save Your Project

After linking your project:

```
File
↓

Save
```

Saving ensures Unity stores your project configuration.

---

# Verify the Setup

Your project should now have:

- [ ] Unity account signed in
- [ ] Project linked
- [ ] Organization selected
- [ ] Project ID assigned
- [ ] Unity Gaming Services enabled
- [ ] No Console errors

If everything is checked, you're ready to configure store products.

---

# Common Problems

## Unable to Sign In

Possible causes:

- No internet connection
- Unity servers temporarily unavailable
- Incorrect account credentials

Try restarting Unity and signing in again.

---

## Services Window is Empty

Possible causes:

- Project not linked
- Unity Hub outdated
- Unity Editor needs restarting

Restart Unity and reopen the Services window.

---

## Project Already Linked

If Unity reports that your project is already linked, no further action is required.

You can continue with the next guide.

---

## Connection Errors

If Unity cannot connect to the dashboard:

- Check your internet connection.
- Verify that you're signed in with the correct Unity account.
- Ensure your firewall or proxy isn't blocking Unity services.

---

# Best Practices

- Use a separate Unity project for testing before integrating IAP into a production game.
- Keep your Unity account associated with the correct organization.
- Avoid switching organizations after products have been configured.
- Regularly update Unity Hub and the Unity Editor to ensure compatibility with the latest services.

---

# What's Next?

Now that your project is connected to Unity Gaming Services, the next step is creating your in-app purchase products.

You'll learn how to:

- Create Product IDs
- Configure Consumables
- Configure Non-Consumables
- Configure Subscriptions
- Prepare products for Google Play and the App Store

---

# Related Guides

- ← [Install Unity IAP](install-unity-iap.md)
- → [Create Products](create-products.md)

You can also jump to any section of the guide:

1. [Introduction](introduction.md)
2. [Prerequisites](prerequisites.md)
3. [Install Unity IAP](install-unity-iap.md)
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
