using System;

namespace leetcode
{
    public class HouseRobber
    {
        public static int Rob(int[] nums) {
        
            if(nums == null || nums.Length == 0){
                return 0;
            }
            
            if(nums.Length == 1){
                return nums[0];
            }
            
            if(nums.Length == 2){
                return Math.Max(nums[0], nums[1]);
            }
            
            
            
            var dp = new int[nums.Length];
            
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            
            for(int i = 2; i < dp.Length; i++){
                dp[i] = Math.Max(nums[i] + dp[i-2], dp[i-1]);
            }
            
            return dp[dp.Length-1];
        }
    }
}