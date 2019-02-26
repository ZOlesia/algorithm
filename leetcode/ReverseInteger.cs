namespace leetcode
{
    public class ReverseInteger
    {
        public static int reverseInt(int x){
            bool negative = false;
            if(x < 0){
                negative = true;
                x *= -1;
            }

            long reversed = 0;

            while(x > 0){
                var f = reversed * 10;
                var s = x % 10;
                reversed = f + s;
                x /= 10;
            }

            if(reversed > int.MaxValue){
                return 0;
            }

            return negative ? (int)(-1 * reversed) : (int)reversed;
        }
    }
}