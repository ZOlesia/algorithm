using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class FrequencySort
    {
        public string frequencySort(string s) {
            var dict = new Dictionary<char, int>();
            
            for(int i = 0; i < s.Length; i++){
                if(!dict.ContainsKey(s[i])){
                    dict[s[i]] = 1;
                } else{
                    dict[s[i]]++;
                }
            }
            
            var maxHeap = new SortedSet<char>(dict.Keys);
            
            maxHeap.Reverse();
            
            var result = new StringBuilder();
            
            while(maxHeap.Count != 0){
                
                
                char current = maxHeap.First();
                maxHeap.Remove(current);
                
                for(int i = 0; i < dict[current]; i++){
                    result.Append(current);
                }
            }
            
            return result.ToString();
        }

        public string FrequencySortWorksSolution(string s) {
            var dict = new Dictionary<char, int>();
            
            for(int i = 0; i < s.Length; i++){
                if(!dict.ContainsKey(s[i])){
                    dict[s[i]] = 1;
                } else{
                    dict[s[i]]++;
                }
            }
            
            var result = new StringBuilder();
            
            foreach(KeyValuePair<char, int> c in dict.OrderByDescending(key => key.Value)){
                for(int i = 0; i < c.Value; i++){
                    result.Append(c.Key);
                }
            }
            
            return result.ToString();
        }
    }
}