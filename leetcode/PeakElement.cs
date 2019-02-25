namespace leetcode
{
    public class PeakElement
    {
        public static int FindPeakElement(int[] nums) {
            for(int i = 0; i < nums.Length-1; i++){
                if(nums[i] > nums[i+1]){
                    return i;
                }
            }
            return nums.Length -1;
        }

        public static int FindPeakElementWithBinarySearch(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right){
                int middle = (right + left)/2;
                if(nums[middle] < nums[middle+1]){
                    left = middle + 1;
                } else {
                    right = middle;
                }
            }
            return left;
        }
    }
}