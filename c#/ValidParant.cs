using System.Collections.Generic;

namespace c_
{
    public class ValidParant
    {
        public bool iSValidParant(string str)
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
    }
}
