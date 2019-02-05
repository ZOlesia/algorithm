using System;
using System.Collections.Generic;
using System.Text;

namespace StringsArrays
{
    class Program
    {
        public static bool IsPermutation(string s1, string s2)
        {
            s1.ToLower();
            s2.ToLower();
            var s = new StringBuilder(s2);
            if(s1.Length != s2.Length) return false;
            for(int i = 0; i < s1.Length; i++)
            {
                if(!s.ToString().Contains(s1[i])) return false;
                s.Remove(s.ToString().IndexOf(s1[i]), 1);
            }
            return true;
        }

         public static string Urlify(string s, int l)
        {
            var count = 0;
            for(int i = 0; i < l; i++)
            {
                if(s[i] == ' ') count++;
            }

            var idx = l + count*2;
            var str = new char[idx];
            str = s.ToCharArray();

            for(int i = l-1; i >= 0; i--)
            {
                if(str[i] == ' ')
                {
                    str[idx - 1] = '0';
                    str[idx - 2] = '2';
                    str[idx - 3] = '%';
                    idx = idx - 3;
                }
                else
                {
                    str[idx - 1] = str[i];
                    idx--;
                }
            }
            return str.ToString();
        }

        public static int[,] ZeroMatrix(int[,] arr)
        {
            var rows = new HashSet<int>();
            var columns = new HashSet<int>();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i, j] == 0)
                    {
                        rows.Add(i);
                        columns.Add(j);
                    }
                }
            }

            foreach(int i in rows)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 0;
                }
            }

            foreach(int i in columns)
            {
                for(int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[j, i] = 0;
                }
            }

            return arr;
        }
        static void Main(string[] args)
        {
            var arr = new int[4,4] { {1,3,8,0}, {2,7,1,3}, {0,2,0,1}, {6,7,9,1} };
            Console.WriteLine(ZeroMatrix(arr));
        }
    }
}
