public class Solution {
    public string MinWindow(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        if( m > n) return "";
        Dictionary<char, int> need = new Dictionary<char, int>();
        for(int i=0; i<m; i++) {
            need[t[i]] = need.GetValueOrDefault(t[i]) + 1;
        }
        int required = need.Count;
        int formed = 0;
        int bestLen = int.MaxValue; int finalStart = 0; int left = 0;
        Dictionary<char, int> window = new Dictionary<char, int>();
        for(int right=0; right<n; right++) {   
            window[s[right]] = window.GetValueOrDefault(s[right]) + 1;

            //match char which met requirement
            if(need.ContainsKey(s[right]) && need[s[right]] == window[s[right]]) {
                formed++;
            }
            while(formed == required) {
                if(right - left + 1 < bestLen) {
                    bestLen = right - left +1;
                    finalStart = left;
                }
                char c = s[left];
                window[c]--;
                if(need.ContainsKey(c) && need[c] > window[c]) {
                    formed--;
                }
                left++;
            }
        }
        return bestLen == int.MaxValue ? "" : s.Substring(finalStart, bestLen);
  }

  private bool checkDict(Dictionary<char, int> need, Dictionary<char, int> window) {
    foreach(var kv in need) {
        if(window.GetValueOrDefault(kv.Key) < kv.Value) return false;
    }
    return true;
  }
}