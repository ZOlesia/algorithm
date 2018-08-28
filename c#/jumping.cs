using System.Collections.Generic;

namespace c_
{
    public class stajumping
    {
       
        static bool CanJump(int[] nums) {
            if(nums.Length == 0) return false;
            else if(nums.Length == 1 && nums[0] == 0) return true;
            
            int i = 0;
            
            while(i!= nums.Length-1)
            {
                var run = i + nums[i];
                
                if(run > nums.Length - 1) return false;
                
                if(nums[run] == 0) return false;
                
                i = run;
                
            }
            
            return true;
                
        }
    }
}



// Hint: you are encouraged to write comments to express yourself

// Question:
// For Company table: (Name, City), write a query to return the cities which have the largest number of companies.

// Sample data:

// (Name, City)

// Myriad, Bellevue

// Microsoft, Redmond

// Boeing, Bellevue





// Question:
// Given an array of non-negative integers, you are initially positioned at the first index of the array.

// Each element in the array represents your maximum jump length at that position.

// Determine if you are able to reach the last index.

// For example:

// A = [2,3,1,1,4], return true.

// A = [3,2,1,0,4], return false.