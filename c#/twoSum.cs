using System.Collections.Generic;
using System.Text;

namespace c_
{
    public class TwoSum
    {
        public int[] twoSum(int[] nums, int target) {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target) 
                    {
                        return new int[] { i, j };
                    }
                }
            }
            
            return new int[] {};
        }

        public static bool PalindromeOfPermutation(string phrase)
        {
            var str = new StringBuilder(phrase.ToLower());
            for(int i = 0; i < str.Length; i++)
            {
                if(i == str.Length-1) break;
                if(str[i] == ' ')
                {
                    str.Remove(i, 1);
                    continue;
                }

                for(int j = i+1; j < str.Length; j++)
                {
                    if(str[i] == str[j])
                    {
                        str.Remove(j, 1);
                        str.Remove(i, 1);
                        i = i-1;
                        break;
                    }
                } 
            }

            if(str.Length > 1) return false;
            return true;
        }

        public static bool OneWay(string original, string check)
        {
            if(original.Length == check.Length) return replace(original, check);
            else if(original.Length < check.Length) return insert(original, check);
            else if(original.Length > check.Length) return remove(original, check);
            else return false;
        }

        public static bool replace(string original, string check)
        {
            var count = 0;
            for(int i = 0; i < original.Length; i++)
            {
                if(original[i] != check[i]) count++;
                if(count > 1) return false;
            }
            return true;
        }

        public static bool insert(string original, string check)
        {
            var str = new StringBuilder(check);
            var count = 0;
            for(int i = 0; i < original.Length; i++)
            {
                if(str.ToString().Contains(original[i])) 
                {
                    str.Remove(str.ToString().IndexOf(original[i]), 1);
                }
                else count++;
                if(count > 1) return false;
            }
            if(str.Length > 1) return false;
            return true;
        }

        public static bool remove(string original, string check)
        {
            var str = new StringBuilder(check);
            var count = 0;
            for(int i = 0; i < original.Length; i++)
            {
                if(str.ToString().Contains(original[i])) 
                {
                    str.Remove(str.ToString().IndexOf(original[i]), 1);
                }
                else count ++;
                if(count > 1) return false;
            }
            if(str.Length > 1) return false;
            return true;
        }


        public static string Compression(string str)
        {
            var returnStr = new StringBuilder();
            var count = 1;
            for(int i = 1; i < str.Length; i++)
            {
                if(str[i] != str[i-1])
                {
                    returnStr.Append(str[i-1]).Append(count);
                    count = 1;
                }
                else count++;
                if(i == str.Length-1) returnStr.Append(str[i-1]).Append(count);
            }
            System.Console.WriteLine(returnStr.ToString());
            return returnStr.ToString();
        }
        static void Main(string[] args)
        {
            
            System.Console.WriteLine(Compression("aabcccccaaa"));
        }
    }
}