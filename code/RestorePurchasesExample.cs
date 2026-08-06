using UnityEngine;
using UnityEngine.Purchasing;

namespace UnitySourceCode.IAP
{
    /// <summary>
    /// Example showing how to restore previous purchases.
    /// Note: Restore Purchases is primarily required for Apple platforms.
    /// Google Play automatically restores eligible purchases when users
    /// sign in with the same Google account.
    /// </summary>
    public class RestorePurchasesExample : MonoBehaviour
    {
        private IExtensionProvider extensionProvider;

        public void Initialize(IExtensionProvider extensions)
        {
            extensionProvider = extensions;
        }

        public void RestorePurchases()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer ||
                Application.platform == RuntimePlatform.OSXPlayer)
            {
                var apple =
                    extensionProvider.GetExtension<IAppleExtensions>();

                apple.RestoreTransactions(OnTransactionsRestored);
            }
            else
            {
                Debug.Log(
                    "Restore Purchases is handled automatically on Google Play.");
            }
        }

        private void OnTransactionsRestored(bool success)
        {
            if (success)
            {
                Debug.Log("Purchases restored successfully.");
            }
            else
            {
                Debug.LogWarning("No purchases available to restore.");
            }
        }
    }
}
