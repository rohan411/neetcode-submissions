public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int left = 0; int right = 0;
        int result = 0;
        while(right < s.Length) {
            while(set.Contains(s[right])) {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            result = Math.Max(result, (right-left) + 1);
            right++;
        }
        return result;
    }
}
