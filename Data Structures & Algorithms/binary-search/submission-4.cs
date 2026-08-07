public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;
        // if(r == 0) return -1;
        // if(r == 1) return nums[0] == target ? 0 : -1;
        while(l <= r) {
            int mid = l + (r-l)/2;
            if(nums[mid] == target) return mid;
            if(nums[mid] > target) {
                r = mid - 1;
            } else {
                l = mid + 1;
            }
        }
        return -1;
    }
}
