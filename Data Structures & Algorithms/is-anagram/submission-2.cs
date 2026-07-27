public class Solution {
    public bool IsAnagram(string s, string t){
        Dictionary<char, int> anagramDict = new Dictionary<char, int>();
        if(s.Length != t.Length) return false;
        for(int i=0; i< s.Length; i++)
        { 
            if(!anagramDict.TryAdd(s[i], 1))
            {
                anagramDict[s[i]] += 1;
            }
            if (anagramDict.ContainsKey(t[i]))
            {
                anagramDict[t[i]] -= 1;
            } else {
             anagramDict.TryAdd(t[i], -1);
            }
        }
        
        foreach(var kv in anagramDict) {
            if (kv.Value != 0) return false;
        }
        return true;
    }
    
}