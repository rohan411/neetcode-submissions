public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        int n = s.Length;
        int i = 0;
        while(i < n) {
            HashSet<char> map = new HashSet<char>();
            int temp = 0;
            int j = i;
            while(j < n && map.Add(s[j])) {
                temp++;
                j++;
            }
            if(temp > result) result = temp;
            i++;
        }
        return result;
    }
}
