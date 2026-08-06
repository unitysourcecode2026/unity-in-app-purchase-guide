using UnityEngine;

namespace UnitySourceCode.IAP
{
    /// <summary>
    /// Centralized Product IDs used by Unity IAP.
    /// Keeping Product IDs in one place improves maintainability
    /// and reduces the chance of typos across the project.
    /// </summary>
    public static class ProductIds
    {
        // Consumables
        public const string Coin100 = "com.company.game.coin100";
        public const string Coin500 = "com.company.game.coin500";
        public const string Coin1000 = "com.company.game.coin1000";

        // Non-Consumables
        public const string RemoveAds = "com.company.game.removeads";
        public const string PremiumUpgrade = "com.company.game.premium";

        // Subscriptions
        public const string MonthlyVIP = "com.company.game.vip.monthly";
        public const string YearlyVIP = "com.company.game.vip.yearly";
    }
}
