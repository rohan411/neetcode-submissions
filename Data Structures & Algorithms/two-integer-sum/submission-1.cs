public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sumdetectorDict = new Dictionary<int, int>();
        for(int i=0; i< nums.Length; i++) {
            if(sumdetectorDict.ContainsKey(target - nums[i])) {
                return new int[]{sumdetectorDict[target - nums[i]], i};
            }
            sumdetectorDict.Add(nums[i], i);
        }
        return new int[0];
    }
}