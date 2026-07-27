public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> resultDictionary = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++){
            string hashCode = CharCountString(strs[i]);
            if(!resultDictionary.TryGetValue(hashCode, out var list)) {
                list = new List<string> {strs[i]};
                resultDictionary[hashCode] = list;
            }
            else {
                list.Add(strs[i]);
            }
        }
        return resultDictionary.Values.ToList();
    }

    private string CharCountString(string s) {
        int[] count = new int[26];
        for (int j = 0; j< s.Length; j++) {
            count[s[j] - 'a']++;
        }
        return string.Join('#', count);
    }
}
