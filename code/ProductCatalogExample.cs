using UnityEngine.Purchasing;

namespace UnitySourceCode.IAP
{
    /// <summary>
    /// Demonstrates how to register Unity IAP products
    /// using a clean and maintainable approach.
    /// </summary>
    public static class ProductCatalogExample
    {
        public static void RegisterProducts(ConfigurationBuilder builder)
        {
            // Consumables
            builder.AddProduct(
                ProductIds.Coin100,
                ProductType.Consumable);

            builder.AddProduct(
                ProductIds.Coin500,
                ProductType.Consumable);

            builder.AddProduct(
                ProductIds.Coin1000,
                ProductType.Consumable);

            // Non-Consumables
            builder.AddProduct(
                ProductIds.RemoveAds,
                ProductType.NonConsumable);

            builder.AddProduct(
                ProductIds.PremiumUpgrade,
                ProductType.NonConsumable);

            // Subscriptions
            builder.AddProduct(
                ProductIds.MonthlyVIP,
                ProductType.Subscription);

            builder.AddProduct(
                ProductIds.YearlyVIP,
                ProductType.Subscription);
        }
    }
}
