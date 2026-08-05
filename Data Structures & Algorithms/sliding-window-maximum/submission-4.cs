public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b-a));
        int n = nums.Length;
        int[] result = new int[n-k+1];
        for(int i = 0; i < n; i++) {
            pq.Enqueue(i, nums[i]);
            if(i >= k-1) {
                while(pq.Peek() <= i-k) {
                    pq.Dequeue();
                }
                result[i-k+1] = nums[pq.Peek()];
            }
        }
        return result;
    }
}
