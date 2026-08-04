public class Solution {
    public string MinWindow(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        if( m > n) return "";
        //int[] count = new int[52]();
        Dictionary<char, int> need = new Dictionary<char, int>();
        for(int i=0; i<m; i++) {
            need[t[i]] = need.GetValueOrDefault(t[i]) + 1;
        }
        string needStr = string.Join(",", need.Select(kv => $"{kv.Key}={kv.Value}"));
        Console.WriteLine($"need => {needStr}");
        int bestLen = int.MaxValue; int start = 0;
        for(int i=0; i<n; i++) {
            Dictionary<char, int> window = new Dictionary<char, int>();
            for(int j = i; j < n; j++) {
                window[s[j]] = window.GetValueOrDefault(s[j]) + 1;
                if(checkDict(need, window)) {
                    if (j - i + 1 < bestLen) {
                        bestLen = j - i + 1;
                        start = i;
                    }
                    break;
                }
            }
        }
        return bestLen == int.MaxValue ? "" : s.Substring(start, bestLen);
  }

  private bool checkDict(Dictionary<char, int> need, Dictionary<char, int> window) {
    foreach(var kv in need) {
        if(window.GetValueOrDefault(kv.Key) < kv.Value) return false;
    }
    return true;
  }
}
