using System.Collections.Generic;

namespace leetcode
{
    public class MajorityElement
    {
        public static int majorityElement(int[] arr){
            if(arr.Length == 1) return arr[0];

            var dict  = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++){
                if(dict.ContainsKey(arr[i]) && dict[arr[i]]+1 > arr.Length/2){
                    return arr[i];
                } else if(dict.ContainsKey(arr[i])){
                    dict[arr[i]]++;
                } else{
                    dict[arr[i]] = 1;
                }
            }

            return -1;


        }
    }
}