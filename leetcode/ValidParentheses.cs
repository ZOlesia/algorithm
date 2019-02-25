namespace leetcode
{
    public class ValidParentheses
    {
        public static bool IsValid(string s) {
            if(s.Length == 0) return true;
            if(s.Length == 1) return false;
            var st = new Stack<char>();
            
            
            for(int i = 0; i < s.Length; i++){
                if(s[i] == '(' || s[i] == '{' || s[i] == '[' ){
                    st.Push(s[i]);
                } 
                else if( s[i] == ')' && st.Count != 0 && st.Peek() == '(')
                {
                    st.Pop();
                }
                else if( s[i] == '}' && st.Count != 0 && st.Peek() == '{')
                {
                    st.Pop();
                }
                else if(s[i] == ']' && st.Count != 0 && st.Peek() == '[')
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }
            
            return st.Count == 0;
        
        }
    }
}