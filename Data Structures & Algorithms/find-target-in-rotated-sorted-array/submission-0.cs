public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int result = -1;
        int pivot = Pivot(nums);
        if(pivot == 0) {
            result = BinarySearch(nums, 0, n - 1, target);
        } else {
            int leftSearch = BinarySearch(nums, 0, pivot - 1, target);
            int rightSearch = BinarySearch(nums, pivot, n - 1, target);
            result = Math.Max(leftSearch, rightSearch);
        }
        return result;
    }

    private int BinarySearch(int[] nums, int left, int right, int target) {
        int result = -1;
        while(left<= right) {
            int mid = left + (right - left)/2;
            if(nums[mid] == target) {
                result = mid;
            }
            if(nums[mid] > target) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return result;
    }

    private int Pivot(int[] nums) {
        int pivot = 0;
        int left = 0; int right = nums.Length - 1;
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
        return pivot;
    }
}
