using System.Collections.Generic;

namespace leetcode
{
    public class JewelsAndStones
    {
        public static int numJewelsInStones(string j, string s){
            var set = new HashSet<char>();

            for(int i = 0; i < j.Length; i++){
                set.Add(j[i]);
            }

            var count = 0;

            for(int i = 0; i < s.Length; i++){
                if(set.Contains(s[i])){
                    count++;
                }
            }

            return count;
        }
    }
}