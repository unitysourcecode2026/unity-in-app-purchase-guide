# Unity IAP Example Scripts

This folder contains production-oriented Unity In-App Purchase (IAP) examples that complement the documentation in the `docs/` folder.

These scripts demonstrate clean architecture principles and are intended as educational references. They are not complete, plug-and-play solutions, but provide a solid foundation for integrating Unity IAP into your own projects.

---

# Example Files

| File | Description |
|------|-------------|
| `ProductIds.cs` | Centralizes all Product IDs used by Unity IAP. |
| `IAPManager.cs` | Demonstrates Unity IAP initialization, purchase handling, and callback implementation. |
| `ProductCatalogExample.cs` | Shows how to register consumable, non-consumable, and subscription products. |
| `RestorePurchasesExample.cs` | Demonstrates how to restore eligible purchases using Unity IAP. |
| `ReceiptValidationExample.cs` | Shows how to access purchase receipts and prepare them for validation. |

---

# Recommended Folder Structure

```text
Scripts/

├── IAP/
│   ├── ProductIds.cs
│   ├── IAPManager.cs
│   ├── ProductCatalogExample.cs
│   ├── RestorePurchasesExample.cs
│   └── ReceiptValidationExample.cs
```

---

# What You'll Learn

These examples demonstrate how to:

- Initialize Unity IAP
- Register products
- Start purchases
- Process successful purchases
- Restore eligible purchases
- Access purchase receipts
- Organize Product IDs
- Build a maintainable purchasing system

---

# Best Practices

When using these examples in your own projects:

- Keep Product IDs centralized.
- Separate UI from purchasing logic.
- Validate receipts for premium purchases.
- Save player data immediately after successful purchases.
- Test every purchase flow before publishing.

---

# Related Documentation

Continue learning with the documentation in the `docs/` folder:

- Introduction
- Prerequisites
- Install Unity IAP
- Unity Gaming Services
- Create Products
- Consumable Purchases
- Non-Consumable Purchases
- Subscriptions
- Restore Purchases
- Receipt Validation
- Testing
- Best Practices
- Common Errors
- FAQ

For a complete overview, return to the repository's main `README.md`.

---

# License

These example scripts are released under the MIT License. You are free to use, modify, and adapt them in your own Unity projects.
