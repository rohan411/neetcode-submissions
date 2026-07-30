public class Solution {
    public int MaxArea(int[] heights) {
        int vol = 0;
        for(int i=0 ; i< heights.Length; i++) {
            int tempVol = 0;
            for(int j=i+1 ; j< heights.Length; j++) {
                tempVol = int.Min(heights[i], heights[j])*(j-i);
                if(tempVol > vol) vol = tempVol;
            }
        }
        return vol;
    }
}
