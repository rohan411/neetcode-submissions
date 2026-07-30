public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> interimResult = new List<List<int>>();

        Array.Sort(nums);
        for(int i=0 ; i< nums.Length ; i++) {
            int target = 0 - nums[i];
            int l = i+1; int r = nums.Length-1;
            while (l < r) {
                if(nums[l] + nums[r] == target) {
                    interimResult.Add(new List<int> {nums[i], nums[l], nums[r]}); 
                    l++;r--;
                }
                while( l< r && (nums[l] + nums[r] < target)) l++;
                while( l< r && (nums[l] + nums[r] > target)) r--;
            }
        }
        var seen = new HashSet<string>();
        var result = new List<List<int>>();
        foreach(var list in interimResult) {
            string key = string.Join(", ", list);
            Console.WriteLine($"{key}");
            if(seen.Add(key)) result.Add(list);
        }
        return result;
    }
}
