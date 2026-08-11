public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int pivot = 0;
        int left = 0; int right = n - 1;
        while(left<= right) {
            int mid = left + (right - left)/2;
            if(mid - 1>= 0 && nums[mid-1] > nums[mid]) {
                pivot = mid;
            }
            if(nums[mid] > nums[right]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return nums[pivot];
    }
}
