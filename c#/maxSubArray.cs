namespace c_
{
    public class MaxSubArray
    {
        public int maxSubArray(int[] nums) {
            int sum = 0;
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if(sum < 0) sum = 0;
                else if(max < sum) max = sum;
            }
        
            return max;
        }
    }
}