using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_
{
    class Program
    {
        static char maxConsecutive (string str)
        {
            Dictionary<char, int> dict= new Dictionary<char, int>();

            int count = 1;
            for(int i = 0; i < str.Length-1; i++)
            {
                if(str[i] == str[i+1])
                {
                    count++;
                } 
                else if (dict.ContainsKey(str[i]) && dict[str[i]] > count)
                {
                    count = 1;
                } 
                else 
                {
                    dict[str[i]] = count;
                    count = 1;
                }
            }
            return dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key;
        }

        static int []  mergeArray (int[] A, int[] B)
        {
            int removeItem;
            var arr1 = new List<int>(A); 
            var arr2 = new List<int>(B);
            List<int> arr = new List<int>();

            while(arr1.Count != 0 && arr2.Count != 0)
            {
                if(arr1[0] > arr2[0])
                {
                    removeItem = arr2[0];
                    arr2.RemoveAt(0);
                    arr.Add(removeItem);
                } else 
                {
                    removeItem = arr1[0];
                    arr1.RemoveAt(0);
                    arr.Add(removeItem);
                }
            }

            if(arr1.Count == 0)
            {
                arr.Concat(arr2).ToArray();
            }
            if(arr2.Count == 0)
            {
                arr.Concat(arr1).ToArray();
            }

            var result = arr.ToArray();
            return result;
        }

        static int[] zeroOnTheLeftOneOnTheRight (int[] A)
        {
            var list = new List<int>();
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i] == 0)
                {
                    list.Insert(0, A[i]);
                } else {
                    list.Add(A[i]);
                }
            }
            var arrray = list.ToArray();
            return arrray;
        }

        static int[] negativeOnTheLeftPositiveOnTheRight(int[] A)
        {
            var list = new List<int>();
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i] < 0)
                {
                    list.Insert(0, A[i]);
                } else 
                {
                    list.Add(A[i]);
                }
            }
            var array = list.ToArray();
            return array;
        }

        static int findDifferenceNumber(int n, int[] A)
        {
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i]/2 == n)
                {
                    return A[i];
                }
            }
            return 0;
        }

        static char mostRepeatedCharacter(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            str = str.ToLower();
            System.Console.WriteLine(str);
            for(int i = 0; i < str.Length; i++)
            {
                if(!dict.ContainsKey(str[i]))
                {
                    dict[str[i]] = 1;
                } else 
                {
                    dict[str[i]] += 1;
                }
            }

            return dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key;
        }


        static int[] swapArray (int[] arr)
        {
            
            for(int i = 0; i < arr.Length/2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1-i];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }

        static int[] swapEvenNum(int[] arr)
        {
            int idx = arr.Length - 1;
            for(int i = 0; i < arr.Length/2; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    for(int j = idx; j >= 0; j--)
                    {
                        if(arr[j] % 2 == 0)
                        {
                            var temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                            idx = j-1;
                            break;
                        }
                    }
                }
            }
            return arr;
        }

        static int giveMaxSumS(int[] A)
        {
            int max = 0;
            int max2 = 0;
            for(int i = 0; i < A.Length; i++)
            {
                max = max + A[i];
                if(max < 0)
                {
                    max = 0;
                } 
                else if(max2 < max)
                {
                    max2 = max;
                }
            }
            return max2;
        }

        public static void Sort(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int pivot = B[i];
                List<int> left = new List<int>();
                List<int> right = new List<int>();
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] < pivot)
                    {
                        left.Add(A[j]);
                    }
                    else
                    {
                        right.Add(A[j]);
                    }
                }
                A = left.Concat(right).ToArray();
            }
        }

        public static void LongSubstring(string A)
        {
            int start = 0;
            int end = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 0;
            List<char> list = new List<char>();
            for(int i = 0; i < A.Length; i++)
            {
                if(!dict.ContainsKey(A[i]))
                {
                    dict[A[i]] = 1;
                    count++;
                } 
                else if(dict[A[i]] == 1)
                {
                    end = i - 1;
                    if(count > list.Count)
                    {
                        list.Clear();
                        for(int j = start; j <= end; j++)
                        {
                            list.Add(A[j]);
                            dict.Remove(A[j]);
                        }
                    }
                    count = 1;
                    start = i;
                    dict[A[i]] = 1;
                }
            }
        } 


        public static void ReverseWords(string A)
        {
            // A = String.Join(" ", A.Split(" ").Reverse().ToArray());
            string[] words = A.Split(' ');
            Array.Reverse(words);
            A = String.Join(" ", words);
        }



        static public List<String> sortedNumAlphabet(int num){
            
            List<string> list = new List<string>();

            for(int i = 1; i <= num; i++)
            {
                list.Add(i.ToString());
                for(int j = 0; j < 10; j++)
                {
                    list.Add(i.ToString() + j.ToString());
                    if(i.ToString() + j.ToString() == num.ToString())
                    {
                        for(int x = i+1; x < 10; x++)
                        {
                            list.Add(x.ToString());
                        }
                        return list;
                    }
                }
            }
            return list;
        }


            static bool OneAway(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            if (Math.Abs(len1 - len2) > 1) return false;

            string shorter = str1.Length > str2.Length ? str2 : str1;
            string longer = str1.Length > str2.Length ? str1 : str2;
            int idx1 = 0;
            int idx2 = 0;
            bool foundDiff = false;
            while (idx1 < str1.Length && idx2 < str2.Length)
            {
                if (shorter[idx1] != longer[idx2])
                {
                    System.Console.WriteLine(str1[idx1] + " " + str2[idx2]);
                    if (shorter[idx1] != longer[idx2])
                    {
                        if (foundDiff) return false;
                        foundDiff = true;
                        if (shorter.Length == longer.Length)
                        {
                            idx1++;
                        }
                    }
                }
                else
                {
                    idx1++;
                }
                idx2++;
            }
            return true;
        }




// Given an integer, convert it to a roman numeral. Input can be any value between 1 to 999.

// Roman symbols: 

// I, V, X, L, C, D and M.

// e.g 

// Input : 746

// Output: DCCXLVI 
// 746
//     static string ConvertToRoman(int num)
//     {
//         StringBuilder result = new StringBuilder();
//         Dictionary<int, string> roman = new Dictionary<int, string>{
//             {1, "I"},
//             {5, "V"},
//             {10, "X"},
//             {50, "L"},
//             {100, "C"},
//             {500, "D"},
//             {1000, "M"}
            
//         }; DCCXLVI 

//         foreach(var key in roman)
//         {
//             while(num >= key.Key())
//             {
//                 num -= key.Key();
//                 result.Append(key.Value());
//             }
//         }
//         string resultstr = result.ToString();
//         return resultstr; 
//     }



        static string NumToRom(int num)
        {
            int d;
            StringBuilder str = new StringBuilder();
            int[] nums = {1, 5, 10, 50, 100, 500, 1000};
            char[] rom = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
            List<int> q = new List<int>();

            for(int i = nums.Length-1; i >= 0; i--)
            {
                d = num/nums[i];
                q.Insert(0, d);

                num = num % nums[i];
            }

            for(int i = q.Count-1; i>=0; i--)
            {
                if(q[i] == 0) continue;
                if(q[i] == 4 && q[i+1] == 0) 
                {
                    str.Append(rom[i], 1);
                    str.Append(rom[i+1], 1);
                } 
                else if( q[i] == 4 && q[i+1] == 1)
                {
                    str[str.Length - 1] = rom[i];
                    str.Append(rom[i+2], 1);
                }
                else
                {
                    str.Append(rom[i], q[i]);  //will add to a string rom[i] value q[i] times
                }
            }

            return str.ToString();
        }

        static void GenerateCoin(int num)
        {
            Dictionary<string, int> coins = new Dictionary<string, int>()
            {
                {"onecent", 1},
                {"twocent", 2},
                {"fivecent", 5},
                {"tencent", 10},
                {"twentycent", 20},
                {"fiftycent", 50}
            }; 
            int d;
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach(KeyValuePair<string,int> coin in coins.Reverse())
            {
                d = num / coin.Value;
                result[coin.Key] = d;
                num = num % coin.Value;
            }

            foreach(KeyValuePair<string, int> coin in result.Reverse())
            {
                System.Console.WriteLine(coin.Key + " - " + coin.Value);
            }
        }


        // -----------------------------------INTERVIEW ALGORITHMS-------------------------------------------
        // --------------------------------------------------------------------------------------------------

        static string ReverseString(string s) {
            StringBuilder str = new StringBuilder(s);
            for(int i = 0; i< str.Length/2; i++)
            {
                var temp = str[i];
                str[i] = str[str.Length-1-i];
                str[str.Length-1-i] = temp;
            }
            s = str.ToString();
            return s;
        }

        static IList<string> FizzBuzz(int n) {
            List<string>result = new List<string>();
            for(int i = 1; i <= n; i++)
            {
                if(i % 15 == 0)
                {
                    result.Add("FizzBuzz");
                } 
                else if(i % 3 == 0)
                {
                    result.Add("Fizz");
                } 
                else if(i % 5 == 0)
                {
                    result.Add("Buzz");
                } 
                else 
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }

        static int SingleNumber(int[] nums) {
            bool ex = false;
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int idx = nums.Length-1;

                while(idx >= 0)
                {
                    if(nums[i] == nums[idx] && idx != i)
                    {
                        ex = true;
                        break;
                    } 
                        ex = false;
                        idx--;
                }

                if(ex == false)
                {
                    result = nums[i];
                    break;
                }
            }
            return result;
        }


    // public static void MoveZeros(int[] nums)
    // {
    //     if (nums == null || nums.Length <= 1)
    //         return;

    //     int curr = 0;
    //     int next = 1;

    //     while (next <= nums.Length - 1)
    //     {
    //         if (nums[curr] == 0)
    //         {
    //             if (nums[next] == 0)
    //             {
    //                 next++;
    //                 continue;
    //             }
    //             else
    //             {
    //                 nums[curr] = nums[next];
    //                 nums[next] = 0;
    //             }
    //         }
    //         curr++;
    //         next++;
    //     }
    // }

        static void MoveZeroes(int[] nums) {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        if(nums[j] != 0)
                        {
                            var temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
        }

        static int TitleToNumber(string s) {
            var nums = Enumerable.Range(1, 26).ToArray();
            char[] alpha = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
            int result;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                dict[alpha[i]] = nums[i];
            }

            if(s.Length == 1)
            {
                result = dict.FirstOrDefault(x => x.Key.ToString() == s).Value;
            }
            else
            {
                result = (dict.FirstOrDefault(x => x.Key == s[0]).Value) * alpha.Length;
                result += dict.FirstOrDefault(x => x.Key == s[1]).Value;
            }
            return result;
        }

        static int MajorityElement(int[] nums) {
            int times = nums.Length / 2;
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(!numbers.ContainsKey(nums[i]))
                {
                    numbers[nums[i]] = 1;
                } else 
                {
                    numbers[nums[i]] ++;
                }
            }

            int result = numbers.FirstOrDefault(x => x.Value > times).Key;
            return result;
        }

        static int RomanToInt(string s) {
            Dictionary<int, string> roman = new Dictionary<int, string>{
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"}
            };
            List<char> arr = new List<char>(){'I', 'V', 'X', 'L', 'C', 'D', 'M'};
            int subtract;
            bool firstcase = false;
            bool secondcase = false;
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {

                if(firstcase == true)
                {
                    firstcase = false;
                    continue;
                }

                if(secondcase == true)
                {
                    secondcase = false;
                    continue;
                }

                if(arr[arr.IndexOf(s[i]) + 1] == s[i+1])
                {
                    subtract = (roman.FirstOrDefault(x => x.Value == arr[arr.IndexOf(s[i]) + 1].ToString()).Key) - (roman.FirstOrDefault(x => x.Value == s[i].ToString()).Key);
                    sum += subtract;
                    firstcase = true;
                } 
                else if(arr[arr.IndexOf(s[i]) + 2] == s[i+1])
                {
                    subtract = (roman.FirstOrDefault(x => x.Value == arr[arr.IndexOf(s[i]) + 2].ToString()).Key) - (roman.FirstOrDefault(x => x.Value == s[i].ToString()).Key);
                    sum += subtract;
                    secondcase = true;
                } 
                else
                {
                    sum += roman.FirstOrDefault(x => x.Value == s[i].ToString()).Key;

                }
            }
            return sum;
        }

        static int maxProfit(int[] prices) {
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++) {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }

        static bool IsAnagram(string s, string t) {
            var strmax = s.Length >= t.Length ? s : t;
            var strmin = t.Length <= s.Length ? t : s;
            StringBuilder x = new StringBuilder(strmax);
            bool check = false;
            for(int i = 0; i < strmin.Length; i++)
            {
                for(int j = 0; j < x.Length; j++){
                    if(strmin[i] == x[j])
                    {
                        check = true;
                        x.Remove(j, 1);
                        break;
                    } 
                    check = false;
                }
                if(check == false)
                {
                    return false;
                }
            }
            if(x.Length != 0)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].ToString() == " ")
                    {
                        continue;
                    }
                    return false;
                }
            }
            return true;
        }

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

     static void ReverseList(ListNode head) {
        ListNode holder = head;
        ListNode runner = head.next;
        while(runner != null)
        {
            ListNode newNode = new ListNode(runner.val);
            newNode.next = head;
            head = newNode;
            runner = runner.next;
        }
        holder.next = null; 
    }

     static void DeleteNode(ListNode head, int val) {
        ListNode runner = head;
        while(runner != null)
        {
            if(runner.next.val == val)
            {
                runner.next = runner.next.next;
                break;
            }
            runner = runner.next;
        }
    }

        static bool ContainsDuplicate(int[] nums) {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j]) return true;
                }
            }
            return false;
        }

        static int FirstUniqChar(string s) {
            bool check = false;
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < s.Length; j++)
                {
                    if(s[i] == s[j] && i != j) 
                    { 
                        check = true; 
                        break; 
                    }
                    check = false;
                }
                if(check == false)
                {
                    return i;
                }
            }
            return -1;
        }

        static int MissingNumber(int[] nums) {
            var start = nums.Min();
            var end = nums.Max();
            bool check = false;
            for(int i = start; i < end + 1; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(i == nums[j])
                    {
                        check = true;
                        break;
                    }
                    check = false;
                }
                if(check == false){return i; }
            }
            return -1;
        }
 
        static int[] PlusOne(int[] digits)
        {
            List<int> list = new List<int>(digits);
        
            int i = list.Count-1;
            
            int count = 0;
            
            if(digits[digits.Length-1] == 9)
            {
                while(list[i] == 9)
                {
                    count++;
                    if(i ==  0) break;
                    i--;
                }

                if(count == digits.Length) 
                {
                    list.RemoveRange(i, list.Count);
                    list.Add(1);
                }
                else
                {
                    list.RemoveRange(i+1, count); // will removw values from i index, count - how many items to remove ??
                    list[list.Count-1]++;
                }
                
                
                list.AddRange(Enumerable.Repeat(0, count));  // will add 0`s to the end of the list count times 
            }
            else
            {
                list[list.Count-1]++;
            }
        
        return list.ToArray();
        }

        static string InterviewAlgor(string str)
        {
            var count = 1;
            StringBuilder result = new StringBuilder();
            result.Append(str[0]);
            for(int i = 1; i < str.Length; i++)
            {
                if(str[i-1] != str[i])
                {
                    result.Append(count);
                    result.Append(str[i]); 
                    count = 0;            
                }

                count++;

                if(i == str.Length-1) result.Append(count);
            }
            return result.ToString();
        }



        static void Main(string[] args)
        {
            System.Console.WriteLine(InterviewAlgor("ABCA"));
        }
    }
}     



