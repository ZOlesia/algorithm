using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> groupAnagrams(string[] strs) {
            var result = new List<IList<string>>();
            
            var map = new Dictionary<string, IList<string>>();
            
            for(int i = 0; i < strs.Length; i++){
                
                var sorted = SortString(strs[i]);
                
                if(!map.ContainsKey(sorted)){
                    map[sorted] = new List<string>();
                } 
                    
                map[sorted].Add(strs[i]); 
            }
            
            foreach(var key in map.Values){
                result.Add(key);
            }
            
            return result;
        }
    
    
        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}