public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n-k+1];
        for(int i = 0; i+k <= n; i++) {
            int localMax = int.MinValue;
            for(int j = 0; j < k; j++) {
                if(nums[i+j] > localMax) {
                    localMax = nums[i+j];
                }
                if(j == k-1) {
                    result[i] = localMax;
                }
            }     
        }
        return result;
    }
}
