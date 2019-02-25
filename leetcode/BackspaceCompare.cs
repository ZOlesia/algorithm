using System.Collections.Generic;
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

        //other way of using Stack 
        public static bool backspaceCompareUsingStack(string S, string T){
            var st1 = new Stack<char>();
            var st2 = new Stack<char>();

            for(int i = 0; i < S.Length; i++){
                if(S[i] != '#'){
                    st1.Push(S[i]);
                } else if(st1.Count != 0){
                    st1.Pop();
                }
            }

            for(int i = 0; i < T.Length; i++){
                if(T[i] != '#'){
                    st2.Push(T[i]);
                } else if(st2.Count != 0){
                    st2.Pop();
                }
            }

            if(st1.Count != st2.Count) return false;

            while(st1.Count != 0){
                var current = st1.Pop();
                if(st2.Count == 0 || st2.Pop() != current){
                    return false;
                }
            }
            return true;
        }
    }
}