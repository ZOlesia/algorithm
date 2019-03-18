using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class MostCommonWord
    {
        public static string mostCommonWord(string paragraph, string[] banned) {

            var map = new ConcurrentDictionary<string, int>();
            
            string[] p = paragraph.ToLower().Replace(",","").Replace(":","").Replace(".","").Split(" ");
            
            foreach(string word in p){
                if(Array.IndexOf(banned, word) == -1){
                    map.AddOrUpdate(word, 1, (k, v) => v + 1);
                } 
            }
            
            return map.FirstOrDefault(x => x.Value == map.Values.Max()).Key;
        }
    }
}