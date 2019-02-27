using System.Collections.Generic;

namespace leetcode
{
    public class ContainsDuplicateII
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k) {
            var dict = new Dictionary<int, List<int>>();
            
            for(int i = 0; i < nums.Length; i++){
                if(dict.ContainsKey(nums[i])){
                    for(int j = 0; j < dict[nums[i]].Count; j++){
                        if(i - dict[nums[i]][j] == k) return true;
                    }
                    dict[nums[i]].Add(i);
                } else {
                    dict[nums[i]] = new List<int>();
                    dict[nums[i]].Add(i);
                }
            }
            
            return false; 
        }

        public static bool ContainsNearbyDuplicateAnotherSolution(int[] nums, int k) {
            var dict = new Dictionary<int, int>();
            
            for(int i = 0; i < nums.Length; i++){
                int current = nums[i];
                if(dict.ContainsKey(current) && i - dict[current] <= k){
                    return true;
                } else {
                    dict[current] = i;
                }
            }
            
            return false;
            
        }

    }
}