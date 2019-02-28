using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class IntersectionOfTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2) {
            var set = new HashSet<int>();
            
            for(int i = 0; i < nums1.Length; i++){
                set.Add(nums1[i]);
            }
            
            var resultSet = new HashSet<int>();
            
            for(int i = 0; i < nums2.Length; i++){
                if(set.Contains(nums2[i])){
                    resultSet.Add(nums2[i]);
                }
            }
            
            
            
            return resultSet.ToArray();
        }
    }
}