public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var prefixProduct = new int[n];
        var suffixProduct = new int[n];
        var resultProduct = new int[n];
        prefixProduct[0] = 1;
        suffixProduct[n-1] = 1;
        for(int i=1; i < n; i++) {
            prefixProduct[i] = prefixProduct[i-1]*nums[i-1];
        }
        for(int j=n-2; j>=0; j--) {
            suffixProduct[j] = suffixProduct[j+1]*nums[j+1];
        }
        for(int k=0; k < n; k++) {
             resultProduct[k] = prefixProduct[k]*suffixProduct[k];
        }
        Console.WriteLine($"Result output {resultProduct}");
        return resultProduct;
    } 
}

























