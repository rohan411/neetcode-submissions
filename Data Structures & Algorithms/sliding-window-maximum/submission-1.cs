public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[n-k+1];
        int left= 0; //int count = 0;
        for(int right = 0; right+k <= n; right++) {
            int localMax = int.MinValue;
            for(int j = 0; j < k; j++) {
                if(nums[right+j] > localMax) {
                    localMax = nums[right+j];
                    //Console.WriteLine($"localMax => {localMax}");
                }
                //count++;
                //Console.WriteLine($"localMax => {localMax}, count => {count}, n => {n}, j => {j}, right+j => {right+j}");
                if(j == k-1) {
                    result[right] = localMax;
                    //count = 0;
                }
               // Console.WriteLine($"{string.Join(", ", result)}");
            }     
        }
        return result;
    }
}
