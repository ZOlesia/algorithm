using System.Collections.Generic;

namespace c_
{
    public class stairs
    {
        static int climbingSteps(int num)
        {
            int[] steps = {1, 2};
            if(num == 1) return 1;
            List<int> combinations = new List<int>();
            int count = 0;
            findCombinations(steps, num, combinations, count, 0);
            return count;
        }

        static void findCombinations(int[] steps, int num, List<int>combinations, int count, int idx)
        {
            if(num == 0) 
            {
                count++;
                return;
            }

            for(int i = idx; i < steps.Length; i++)
            {
                if(steps[i] > num) break;
                combinations.Add(steps[i]);
                findCombinations(steps, num-steps[i], combinations, count, i);
                combinations.RemoveAt(combinations.Count-1);
            }
        }


//the other way to do it is to use the same concept of fibbonachi


    }
}


