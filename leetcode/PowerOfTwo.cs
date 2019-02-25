namespace leetcode
{
    public class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int n) {
            if(n == 1) return true;
            if(n < 1) return false;
            while(n != 1){
                if(n % 2 != 0) return false;
                n = n/2;
            }
            return true;
        }
    }
}