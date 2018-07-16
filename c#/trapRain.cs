using System;
using System.Collections.Generic;

namespace c_
{
    public class trapRain
    {
        static int Trap(int[] arr)
        {
            int result = 0;
            int low = 0;
            int idxMax = 0;
            int higher = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0) continue;

                else if(arr[i] >= arr[idxMax])
                {
                    if(arr[idxMax] == arr[i] && idxMax + 1 == i)
                    {
                        idxMax = i;
                    } 
                    else
                    {
                        for(int j = idxMax+1; j < i; j++)
                        {
                            higher = arr[i] > arr[idxMax] ? arr[idxMax] : arr[i];
                            if(higher == 0)
                            {
                                result += arr[i];
                            } 
                            else 
                            {
                                result += higher - arr[j];
                            }
                        }
                        idxMax = i;
                    }
                }
                else
                {
                    low = idxMax;
                }

                if(i == arr.Length-1 && idxMax == low)
                {
                    i = idxMax;
                    idxMax = idxMax + 1;
                }
            }
            return result;
        }

        static int trapingRainWater(int[] arr)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> min = new List<int>();
            int result = 0;
            int leftmax = arr[0];
            int rightmax = arr[arr.Length - 1];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > leftmax)
                {
                    leftmax = arr[i];
                }
                left.Add(leftmax);
            }

            for(int i = arr.Length-1; i >= 0; i--)
            {
                if(arr[i] > rightmax)
                {
                    rightmax = arr[i];
                }
                right.Insert(0, rightmax);
            }

            for(int i = 0; i < left.Count; i++)
            {
                var pushMin = left[i] < right[i] ? left[i] : right[i];
                result += pushMin - arr[i];
            }
            return result;

        }


// Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water. Return the max container size.

// Note: You may not slant the container and n is at least 2.

        static int MaxContainer(int[] arr)
        {
            int max = 0;
            if(arr.Length < 2 || arr == null) return max;

            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int area = (right - left) * Math.Min(arr[left], arr[right]); //we need to know width and height in order to calculate area or container 

                max = Math.Max(area, max);

                if(arr[left] < arr[right])
                {
                    left++;
                } 
                else
                {
                    right++;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            // System.Console.WriteLine(trapingRainWater(new int[]{3, 2, 1}));
            // System.Console.WriteLine(Trap(new int[]{3, 2, 1}));
            System.Console.WriteLine(MaxContainer(new int[]{3, 1, 0, 5}));
        }

    }
}