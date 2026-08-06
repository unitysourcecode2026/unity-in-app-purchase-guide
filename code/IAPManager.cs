using UnityEngine;
using UnityEngine.Purchasing;

namespace UnitySourceCode.IAP
{
    /// <summary>
    /// Production-ready Unity IAP Manager example.
    /// Demonstrates initialization and purchase entry points.
    /// </summary>
    public class IAPManager : MonoBehaviour, IDetailedStoreListener
    {
        private IStoreController storeController;
        private IExtensionProvider extensionProvider;

        public bool IsInitialized =>
            storeController != null &&
            extensionProvider != null;

        private void Start()
        {
            InitializePurchasing();
        }

        public void InitializePurchasing()
        {
            if (IsInitialized)
                return;

            var builder = ConfigurationBuilder.Instance(
                StandardPurchasingModule.Instance());

            RegisterProducts(builder);

            UnityPurchasing.Initialize(this, builder);
        }

        private void RegisterProducts(ConfigurationBuilder builder)
        {
            builder.AddProduct(
                ProductIds.Coin100,
                ProductType.Consumable);

            builder.AddProduct(
                ProductIds.RemoveAds,
                ProductType.NonConsumable);

            builder.AddProduct(
                ProductIds.MonthlyVIP,
                ProductType.Subscription);
        }

        public void BuyProduct(string productId)
        {
            if (!IsInitialized)
            {
                Debug.LogWarning("Unity IAP is not initialized.");
                return;
            }

            Product product =
                storeController.products.WithID(productId);

            if (product == null)
            {
                Debug.LogWarning("Product not found.");
                return;
            }

            storeController.InitiatePurchase(product);
        }

        public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
        {
            Debug.Log($"Purchase Successful: {args.purchasedProduct.definition.id}");

            switch (args.purchasedProduct.definition.id)
            {
                case ProductIds.Coin100:

                    Debug.Log("Grant 100 Coins");

                    break;

                case ProductIds.RemoveAds:

                    Debug.Log("Disable Ads");

                    break;

                case ProductIds.MonthlyVIP:

                    Debug.Log("Enable VIP");

                    break;
            }

            return PurchaseProcessingResult.Complete;
        }

        public void OnInitialized(
            IStoreController controller,
            IExtensionProvider extensions)
        {
            storeController = controller;
            extensionProvider = extensions;

            Debug.Log("Unity IAP Initialized.");
        }

        public void OnInitializeFailed(
            InitializationFailureReason error)
        {
            Debug.LogError(error);
        }

        public void OnInitializeFailed(
            InitializationFailureReason error,
            string message)
        {
            Debug.LogError($"{error} : {message}");
        }

        public void OnPurchaseFailed(
            Product product,
            PurchaseFailureDescription failure)
        {
            Debug.LogError(
                $"Purchase Failed : {failure.reason}");
        }
    }
}
