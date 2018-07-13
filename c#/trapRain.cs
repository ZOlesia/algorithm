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

        static void Main(string[] args)
        {
            System.Console.WriteLine(trapingRainWater(new int[]{3, 2, 1}));
            System.Console.WriteLine(Trap(new int[]{3, 2, 1}));
        }

    }
}