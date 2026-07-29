public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length == 0) return [-1, -1];
        int l = 0; int r = numbers.Length - 1;
        while(l < r) {
            if(numbers[l] + numbers[r] == target) return [l+1,r+1];
            while( l< r && (numbers[l] + numbers[r] < target)) l++;
            while( l< r && (numbers[l] + numbers[r] > target)) r--;
        }
        return [-1,-1];
    }
}
