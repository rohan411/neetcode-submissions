public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var resultProduct = new int[n];
        resultProduct[0] = 1;
        int suffixProduct = 1;
        for(int k=1; k < n; k++) {
             resultProduct[k] = resultProduct[k-1]*nums[k-1];
        }
        for(int l=n-1; l >=0; l--) {
             resultProduct[l] = resultProduct[l]*suffixProduct;
             suffixProduct = suffixProduct*nums[l];
        }
        //Console.WriteLine($"Result output {resultProduct}");
        return resultProduct;
    } 
}