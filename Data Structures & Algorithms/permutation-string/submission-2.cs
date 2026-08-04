public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n = s1.Length;
        int m = s2.Length;
        if(n > m) return false;
        int[] need = new int[26];
        int[] window = new int[26];
        for(int i = 0; i <n ; i++) {
            need[s1[i]  - 'a']++;
            window[s2[i]  - 'a']++;
        }
        if(Matches(need, window)) return true;
        for(int i =n; i< m ; i++) {
            window[s2[i]  - 'a']++;
            window[s2[i-n] - 'a']--;
            if(Matches(need, window)) return true;
        }
        return false;
    }

    private bool Matches(int[] arr1, int[] arr2) {
        for(int i=0; i< 26; i++) {
            if(arr1[i] != arr2[i]) return false;
        }
        return true;
    }
}
