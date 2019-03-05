using System;

namespace leetcode
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s) {
            if(s.Length == 0) return true;

            s = s.ToLower();
            
            var l = 0;
            
            var r = s.Length -1;
            
            while(l < r){
                if(!Char.IsLetterOrDigit(s[l]) ){
                    l++;
                } else if(! Char.IsLetterOrDigit(s[r])){
                    r--;
                } else if(s[l] != s[r]){
                    return false;
                } else{
                    l++;
                    r--;
                }
            }
            
            return true;
        }
    }
}