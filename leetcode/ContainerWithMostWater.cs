using System;

namespace leetcode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height) {
            var l = 0;
            var r = height.Length-1;
            
            var max = 0;
            
            
            while(l < r){
                var area = (Math.Min(height[l], height[r])) * (r - l);
                
                max = Math.Max(max, area);
                
                if(height[l] < height[r]){
                    l++;
                } else{
                    r--;
                }
            }
            
            return max;
        }
    }
}