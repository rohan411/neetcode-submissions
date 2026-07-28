public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i=0; i < nums.Length; i++) {
            if(dict.ContainsKey(nums[i])) {
                dict[nums[i]]++;
            } else {
                dict.Add(nums[i], 1);
            }
        }
        var sortedDict = dict.OrderByDescending(kv => kv.Value);
        var result = new int[k];
        int j = 0;
        // foreach(var kv in sortedDict) {
        //     Console.WriteLine($"{kv.Key} => {kv.Value}");
        // }
        foreach(var kv in sortedDict) {
            if( j >= k) return result;
            result[j] = kv.Key;
            j++;
        }
        return result;
    }
}