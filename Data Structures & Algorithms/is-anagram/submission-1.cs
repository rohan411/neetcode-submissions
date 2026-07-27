public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] result = new int[26];
        for(int i=0; i< s.Length; i++) {
            result[s[i] - 'a'] ++;
            result[t[i] - 'a'] --;
        }
        foreach (int i in result) {
            if( i!= 0) return false;
        }
        return true;
    }
}
