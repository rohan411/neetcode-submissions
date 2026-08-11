public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length; int n = nums2.Length;
        int[] arr = new int[m+n];
        int i = 0, j = 0, k = 0;
        while(i < m && j < n) {
            if (nums1[i] <= nums2[j]) arr[k++] = nums1[i++];
            else arr[k++] = nums2[j++];
        }
        while(i < m) arr[k++] = nums1[i++];
        while(j < n) arr[k++] = nums2[j++];
        if(k%2 == 0) {
            return (double)(arr[k/2 - 1] + arr[k/2])/2;
        } else {
            return (double)(arr[k/2]);
        }
    }
}
