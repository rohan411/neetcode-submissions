public class Solution {
    public int MaxArea(int[] heights) {
        int vol = 0;
        int l = 0; int r = heights.Length - 1;
        int tempVol = 0;
        while(l<r) {
            if(heights[l] > heights[r]) {
                tempVol = heights[r]*(r-l);
                r--;
            } else {
                tempVol = heights[l]*(r-l);
                l++;
            }
            if(tempVol > vol) vol = tempVol;
        }
        return vol;
    }
}
