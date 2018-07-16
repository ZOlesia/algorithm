using System.Collections.Generic;
using System.Linq;

namespace c_
{
    public class ValidPar
    {
        static bool iSValid(string str)
        {
            Dictionary<char, char> parent = new Dictionary<char, char>{
                {'{', '}'},
                {'[', ']'},
                {'(', ')'}
            };

            List<char> charArr = new List<char>();

            for(int i = 0; i < str.Length; i++)
            {
                    if(parent.ContainsKey(str[i]))
                    {
                        charArr.Add(str[i]);
                    } 
                    else
                    {
                        if(charArr.Count == 0) return false;
                        var pop = charArr[charArr.Count-1];
                        if(str[i] != parent[pop])
                        {
                            return false;
                        }
                        charArr.Remove(pop);
                    } 
            }
            return true;
        }


        // static void Main(string[] args)
        // {
        //     System.Console.WriteLine(iSValid("(([{{}}]))"));
        //     // System.Console.WriteLine(Trap(new int[]{2, 3, 0, 1, 0, 4, 2, 0}));
        // }
    }
}