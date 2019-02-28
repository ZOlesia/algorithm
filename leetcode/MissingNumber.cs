using System.Collections.Generic;

namespace leetcode
{
    public class MissingNumber
    {
        public int missingNumber(int[] nums) {
    
            int sum = 0;
            
            for(int i = 0; i < nums.Length; i++){
                sum += nums[i];
                }
            

            int n = nums.Length + 1;

            return (n * (n - 1) / 2) - sum ;
        }

        public int missingNumberAnotherSolution(int[] nums) {
    
            var set = new HashSet<int>(nums);
            
            for(int i = 0; i < nums.Length; i++){
                if(!set.Contains(i)){
                    return i;
                }
            }

            return -1;
        }
    }
}