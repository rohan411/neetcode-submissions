public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var prefixProduct = new int[n];
        var suffixProduct = new int[n];
        var resultProduct = new int[n];
        prefixProduct[0] = 1;
        suffixProduct[n-1] = 1;
        int i = 1;
        int j = n-2;
        while (i < n && j >=0)
        {
            prefixProduct[i] = prefixProduct[i-1]*nums[i-1];
            suffixProduct[j] = suffixProduct[j+1]*nums[j+1];
            i++;
            j--;
        }    
        for(int k=0; k < n; k++) {
             resultProduct[k] = prefixProduct[k]*suffixProduct[k];
        }
        Console.WriteLine($"Result output {resultProduct}");
        return resultProduct;
    } 
}

























