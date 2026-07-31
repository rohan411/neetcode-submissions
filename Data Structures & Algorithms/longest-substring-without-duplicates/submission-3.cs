public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int result = 0;
        int n = s.Length;
        int i = 0;
        while(i < n) {
            HashSet<char> map = new HashSet<char>();
            int temp = 0;
            //Console.WriteLine($" i => {i}, temp => {temp}, result => {result}");
            int j = i;
            while(j < n && map.Add(s[j])) {
                //Console.WriteLine($" i => {i}, char => {s[i]}");
                temp++;
                j++;
            }
            if(temp > result) result = temp;
            i++;
        }
        return result;
    }
}
