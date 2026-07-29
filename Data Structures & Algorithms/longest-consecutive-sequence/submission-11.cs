public class Solution {
    public int LongestConsecutive(int[] nums) {
      if (nums == null || nums.Length == 0) return 0;
      HashSet<int> set = new HashSet<int>(nums);
      //Console.WriteLine($"set: [{string.Join(", ", set)}]");
      int maxStreak = 1;   // both declared and initialized
      foreach(var num in set) {
        if(set.Contains(num-1)) continue;
        int currentStreak = 1;
        while(set.Contains(num+currentStreak)) currentStreak++;
        if(currentStreak > maxStreak) maxStreak = currentStreak;
      }
      return maxStreak;
    }
}
