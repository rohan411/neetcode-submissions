public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int m = 0;
        int left = 1; int right = 0;
        for(int i = 0; i< piles.Length; i++) {
            if(piles[i] > right) right = piles[i];
        }
        int minRate = right;
        while(left <= right) {
            int mid = left+(right - left)/2;
            if(HoursNeeded(piles, mid) <= h) {
                minRate = mid;
                right = mid - 1;
            } else {
                left = mid+1;
            }
        }
        return minRate;
    }

    private int HoursNeeded(int[] piles, int mid) {
        int hours = 0;
        for(int i = 0; i< piles.Length; i++) {
            hours += (piles[i] + mid - 1) / mid;
        }
        return hours;
    }
}
