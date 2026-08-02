public class Solution {
    public int CharacterReplacement(string s, int k) {
        int result = 0;
        int n = s.Length;
        int left = 0, right = 0;
        int[] countArr = new int[26];
        int windowLength = 0, maxFreq = 0;
        while(right < n) {
            countArr[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, countArr[s[right] - 'A']);
            while((right - left + 1) - maxFreq > k) {
                countArr[s[left] - 'A']--;
                left ++;
            }
            result = Math.Max(result, right - left + 1);
            right++;
        }
        return result;
    }
}
