using System.Collections.Generic;

namespace leetcode
{
    public class SingleNumber
    {
        public static int singleNumber(int[] nums) {
            var set = new HashSet<int>();
            
            for(int i = 0; i < nums.Length; i++){
                if(!set.Contains(nums[i])){
                    set.Add(nums[i]);
                } else {
                    set.Remove(nums[i]);
                }
            }
            
            foreach(int i in set){
                return i;
            }
            
            return -1;
        }
    }
}