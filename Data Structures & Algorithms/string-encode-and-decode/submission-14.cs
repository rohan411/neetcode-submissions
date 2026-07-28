public class Solution {

    public string Encode(IList<string> strs) {

        Console.WriteLine($"Count => {strs.Count}");
        if (strs.Count == 0) return string.Empty;
    return string.Join("\u0101", strs) + "\u0101";   // ← trailing delimiter added
    }

    public List<string> Decode(string s) {
        Console.WriteLine($"Stting => {s}");
        if (s == string.Empty) return new List<string>();
        var parts = s.Split("\u0101");
    return parts.Take(parts.Length - 1).ToList();     // ← drop the trailing "" from Split
   }
}
