public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        if(nums.Length == 0) return 0;
        int longestStreak = 1;
        int currentStreak = 1;
        Console.WriteLine(string.Join(", ", nums));
        for(int i = 1; i< nums.Length; i++) {
            if(nums[i] == nums[i-1]) continue; 
            if(nums[i] - nums[i-1] == 1) {
                currentStreak++;
                Console.WriteLine($" {i} , nums[i] {nums[i]}, nums[i-1] {nums[i-1]} , currentStreak: {currentStreak}");
            } else {
                currentStreak = 1;
                Console.WriteLine($" where: {i} , nums[i] {nums[i]}, nums[i-1] {nums[i-1]} , currentStreak: {currentStreak}");
            }
            if (currentStreak > longestStreak) longestStreak = currentStreak;
        }
        return longestStreak;
    }
}
