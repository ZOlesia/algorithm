using System.Collections.Generic;
using System.Linq;

namespace c_
{
    public class ValidPar
    {
        static bool iSValid(string str)
        {
            Dictionary<char, char> parent = new Dictionary<char, char>(){
                {'{', '}'},
                {'[', ']'},
                {'(', ')'}
            };

            List<char> charArr = new List<char>();

            for(int i = 0; i < str.Length; i++)
            {
                    if(parent.ContainsKey(str[i]))
                    {
                        charArr.Add(parent[str[i]]);
                    } 
                    else
                    {
                        if(charArr.Count == 0) return false;
                        if(str[i] != charArr[charArr.Count-1])
                        {
                            return false;
                        }
                        charArr.RemoveAt(charArr.Count-1);
                    } 
            }
            if(charArr.Count > 0) return false;
            return true;
        }


        // static void Main(string[] args)
        // {
        //     System.Console.WriteLine(iSValid("[([]])"));
        //     // System.Console.WriteLine(Trap(new int[]{2, 3, 0, 1, 0, 4, 2, 0}));
        // }
    }
}