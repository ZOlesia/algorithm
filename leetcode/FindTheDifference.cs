using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class FindTheDifference
    {
        public char findTheDifference(string s, string t) {
            if(t.Length < s.Length) return ' ';
            var counts = new Dictionary<char, int>();
            
            for(int i = 0; i< t.Length; i++){
                if(!counts.ContainsKey(t[i])){
                    counts[t[i]] = 1;
                } else{
                    counts[t[i]]++;
                }
            }
            
            for(int i = 0; i < s.Length; i++){
                counts[s[i]]--;
            }
            
        return counts.FirstOrDefault(x => x.Value > 0).Key;
            
        
        }
    }
}