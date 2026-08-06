using UnityEngine;
using UnityEngine.Purchasing;

namespace UnitySourceCode.IAP
{
    /// <summary>
    /// Example demonstrating how to access a Unity IAP purchase receipt.
    /// This example is for educational purposes and shows where receipt
    /// validation would typically occur in a production application.
    /// </summary>
    public static class ReceiptValidationExample
    {
        /// <summary>
        /// Retrieves the purchase receipt from a successfully purchased product.
        /// </summary>
        public static void Validate(Product product)
        {
            if (product == null)
            {
                Debug.LogError("Product is null.");
                return;
            }

            if (!product.hasReceipt)
            {
                Debug.LogWarning("No receipt available for this product.");
                return;
            }

            string receipt = product.receipt;

            Debug.Log("Receipt received successfully.");

            // Example:
            // Send 'receipt' to your backend server for validation.
            //
            // Server -> Google Play / App Store
            //          ↓
            //      Validation Result
            //
            // Never trust client-side data alone for high-value purchases.

            Debug.Log(receipt);
        }
    }
}
