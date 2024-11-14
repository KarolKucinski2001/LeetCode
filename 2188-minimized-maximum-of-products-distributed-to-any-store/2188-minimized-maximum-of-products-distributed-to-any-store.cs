public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) {
        int left = 1;
        int right = GetMaxQuantity(quantities);
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanDistribute(n, quantities, mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
    private int GetMaxQuantity(int[] quantities) {
        int maxQuantity = 0;
        foreach (int quantity in quantities) {
            maxQuantity = Math.Max(maxQuantity, quantity);
        }
        return maxQuantity;
    }
    
    private bool CanDistribute(int n, int[] quantities, int maxProductsPerStore) {
        int requiredStores = 0;
        foreach (int quantity in quantities) {
            requiredStores += (quantity + maxProductsPerStore - 1) / maxProductsPerStore;
            if (requiredStores > n) {
                return false;
            }
        }
        return requiredStores <= n;
    }
}