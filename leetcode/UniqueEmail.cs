using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    public class UniqueEmail
    {
        public static int NumUniqueEmails(string[] emails) {
            var set = new HashSet<string>();
            foreach(string e in emails){
                var s = new StringBuilder();
                for(int i = 0; i < e.Length; i++){
                    if(e[i] == '.'){
                        continue;
                    } else if(e[i] == '+'){
                        while(e[i] != '@'){
                            i++;
                        }
                        s.Append(e.Substring(i + 1));
                        break;
                    } else {
                        s.Append(e[i]);
                    }
                }
                set.Add(s.ToString());
            }
            
            return set.Count;
        }
    }
}