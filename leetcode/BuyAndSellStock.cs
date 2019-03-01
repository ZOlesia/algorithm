namespace leetcode
{
    public class BuyAndSellStock
    {
        public int MaxProfit(int[] prices) {
            var profit = 0;

            
            for(int i = 0; i < prices.Length - 1; i++){
                if(prices[i+1] > prices[i] ){
                    profit += prices[i+1] - prices[i];
                }   
            }
            
            return profit;
        }
    }
}