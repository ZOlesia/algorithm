using System.Collections.Generic;

namespace leetcode
{
    public class PlusOne
    {
        public static int[] plusOne(int[] digits) {
            if(digits[digits.Length-1] == 9){
                
                var result = new List<int>(digits);
                var i = result.Count-1;
                
                while(result[i] + 1 > 9){
                        result[i] = 0;
                    
                    if(i == 0){
                        result.Insert(0, 1);
                        return result.ToArray();
                    }
                    
                    i--;
                }
                
                
                result[i]++;
                return result.ToArray();
            } 
            
            else {
                
                digits[digits.Length-1]++;
                return digits;
            }
        }

        public static int[] plusOneAnotherSolution(int[] arr){
            for(int i = arr.Length -1; i >= 0; i--){
                if(arr[i] < 9){
                    arr[i]++;
                    return arr;
                }

                arr[i] = 0;
            }

            int[] result = new int[arr.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}