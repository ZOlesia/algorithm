using System.Collections.Generic;

namespace leetcode
{
    public class PhoneLetterCombination
    {
        public static List<string> LetterCombination(string digits){
            var result = new List<string>();
            string[] mapping = new string[] {"0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

            var current = "";

            RecursionHelper(result, current, digits, mapping, 0);

            return result;
        }

        private static void RecursionHelper(List<string> result, string current, string digits, string[] mapping, int index)
        {
            if(current.Length == digits.Length){
                result.Add(current);
                return;
            }

            string letters = mapping[digits[index] - '0'];

            for(int i = 0; i < letters.Length; i++){
                RecursionHelper(result, current + letters[i], digits, mapping, index+1);
            }

            
        }
    }
}