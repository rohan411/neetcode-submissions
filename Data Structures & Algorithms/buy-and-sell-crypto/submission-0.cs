public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = int.MaxValue;
        for(int i=0; i< prices.Length; i++) {
            if(prices[i] < min) {
                min = prices[i];
            } else if (prices[i] - min > maxProfit){
                maxProfit = prices[i] - min;
            } 
        }
        return maxProfit;
    }
}
