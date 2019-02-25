using System.Text;

namespace leetcode
{
    public class BackspaceCompare
    {
        public static bool backspaceCompare(string S, string T) {
            var str1 = Helper(S);
            var str2 = Helper(T);
            
            if(str1.Length != str2.Length) return false;
            
            return str1 == str2;
        }
    
        public static string Helper(string str){
            var j = 0;
            var s = new StringBuilder(str);
            while(j < s.Length){
                if(s[j] == '#'){
                    if(j == 0){
                        s.Remove(j, 1);
                        j -= 1;
                    } else{
                        s.Remove(j-1, 2);
                        j -= 2;
                    }
                    
                } else {
                    j++;
                }
                
                if(j < 0) j = 0;
            }
            
        return s.ToString();  
        }
    }
}