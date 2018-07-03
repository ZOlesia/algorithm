﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            // int count;
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
                            System.Console.WriteLine(idx + "IDX IS HERE !!!!!!!");
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
            for (int i = 0; i < A.Length; i++)
            {
                System.Console.WriteLine(A[i]);
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
                } else if(dict[A[i]] == 1)
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
            foreach(var letter in list)
            {
                System.Console.WriteLine(letter);
            }
        } 


        static void Main(string[] args)
        {
            string A = "abkdncabceebb";
            LongSubstring(A);
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(maxConsecutive("aaaaaabbcbbbbbbbbcbbbb"));
            // int[] A = {1,5,7,12,18,32};
            // int[] B = {2,4,9,16,27,76,98};
            // System.Console.WriteLine(mergeA, B);
            // int [] result = mergeArray(A, B);
            // foreach(int i in result)
            // {
            //     System.Console.WriteLine(i);
            // }
            // int[] A = {0, 1, 0, 1, 0, 0, 1, 1, 1, 0};
            // int [] result = zeroOnTheLeftOneOnTheRight(A);
            // foreach(int i in result)
            // {
            //     System.Console.WriteLine(i);
            // }
            // int[] A = {4, -3, 2, -5, 5, -1, 3};
            // int [] result = negativeOnTheLeftPositiveOnTheRight(A);
            // foreach(int i in result)
            // {
            //     System.Console.WriteLine(i);
            // }
            // int[] A = {9, 29,10, 2, 50, 24, 100};
            // System.Console.WriteLine(findDifferenceNumber(3, A));
            // System.Console.WriteLine(mostRepeatedCharacter("aaabbbbbqqqAAAA"));
            // int[] arr = {1, 2, 6, 12, 1, 0, 4};
            // int[] result = swapEvenNum(arr);
            // foreach(int i in result)
            // {
            //     System.Console.WriteLine(i);
            // }

            // int[] A = {21, 3, -6, 5, 3, 9, 10};
            // System.Console.WriteLine(giveMaxSumS(A));
  
        }
    }
}     



