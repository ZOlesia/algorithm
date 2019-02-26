using System;

namespace leetcode
{
    public class MoveZeroes
    {
        public static void moveZeroes(int[] nums) {
            var s = 0;
            var f = 1;
            
            while(s < nums.Length && f < nums.Length){
                if(nums[s] == 0){
                    if(nums[f] != 0){
                        nums[s] = nums[f];
                        nums[f] = 0;
                        s++;
                    }
                    f++;
                } else {
                    s++;
                    f++;
                }
            }
        }

        public static void MoveZeroesAnotherSolution(int[] arr){
            int idx = 0;

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] != 0){
                    arr[idx++] = arr[i]; // first set the value and after increment the idx by 1
                }
            }

            for(int i = idx; i < arr.Length; i++){
                arr[i] = 0;
            }
        }

    }
}