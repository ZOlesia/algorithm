using System.Collections.Generic;

namespace leetcode
{
    public class TwoSum
    {
        public int[] twoSum(int[] nums, int target) {
            int[] result = new int[2];
            var map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                var difference = target - nums[i];
                if(map.ContainsKey(difference)){
                    result[0] = i;
                    result[1] = map[difference];
                    return result;
                }
                map[nums[i]] = i;
            }
            return result;
        }
    }
}