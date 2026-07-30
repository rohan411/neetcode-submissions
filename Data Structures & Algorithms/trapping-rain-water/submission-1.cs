public class Solution {
    public int Trap(int[] height) {
        int totalVol = 0;
        if(height.Length == 0) return totalVol;
        int n = height.Length;
        var leftMax = new int[n]; var rightMax = new int[n];
        leftMax[0] = height[0];
        rightMax[n-1] = height[n-1];
        for(int k = 1; k<n; k++) leftMax[k] = Math.Max(leftMax[k-1], height[k]);
        for(int k = n-2; k>=0; k--) rightMax[k] = Math.Max(rightMax[k+1], height[k]);

        for(int k = 0; k< n; k++) {
            totalVol += Math.Min(leftMax[k], rightMax[k]) - height[k];
        }
        return totalVol;
    }
}
