public class Solution {
    public int MaxArea(int[] heights) {
        int vol = 0;
        int l = 0; int r = heights.Length - 1;
        while(l<r) {
            int tempVol = int.Min(heights[l], heights[r])*(r-l);
            if(tempVol > vol) vol = tempVol;
            if(heights[l] > heights[r]) {
                r--;
            } else {
                l++;
            }
        }
        // for(int i=0 ; i< heights.Length; i++) {
        //     int tempVol = 0;
        //     for(int j=i+1 ; j< heights.Length; j++) {
        //         tempVol = int.Min(heights[i], heights[j])*(j-i);
        //         if(tempVol > vol) vol = tempVol;
        //     }
        // }
        return vol;
    }
}
