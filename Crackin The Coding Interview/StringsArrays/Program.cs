using System;

namespace StringsArrays
{
    class Program
    {
        public static bool isPermutation(string s1, string s2)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
