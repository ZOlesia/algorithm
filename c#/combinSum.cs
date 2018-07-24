using System;
using System.Collections.Generic;

namespace c_
{
    public class combinationSum 
    {
        static List<List<int>> combSum (int[] candidates, int target)
        {
            List<List<int>> results = new List<List<int>>();
            if(candidates.Length == 0) return results;

            Array.Sort(candidates);

            List<int> combination = new List<int>();

            findCombinations(results, combination, candidates, target, 0);

            System.Console.WriteLine(results.Count);
            return results;
        }

        static void findCombinations(List<List<int>> results, List<int> combination, int[]candidates, int target, int startIdx)
        {
            if(target == 0) 
            {
                results.Add(new List<int>(combination));
                return;
            } 

            for(int i = startIdx; i < candidates.Length; i++)
            {
                if(candidates[i] > target) break;
                combination.Add(candidates[i]);
                findCombinations(results, combination, candidates, target - candidates[i], i);
                combination.RemoveAt(combination.Count-1);
            }
        }
        // static void Main()
        // {
        //     combSum(new int[]{1, 2}, 3);
        // }
    }
}
