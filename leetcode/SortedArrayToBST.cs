namespace leetcode
{
    public class SortedArrayToBST
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        
        public static TreeNode sortedArrayToBST(int[] nums) {
            
            if(nums == null || nums.Length == 0) return null;
            
            return RecursiveHelper(nums, 0, nums.Length - 1);  
        }


        public static TreeNode RecursiveHelper(int[] nums, int left, int right){
            if(left > right) return null;
            
            var mid = (left+right)/2;
            
            TreeNode current = new TreeNode(nums[mid]);
            
            current.left = RecursiveHelper(nums, left, mid-1);
            current.right = RecursiveHelper(nums, mid+1, right);
            return current;
        }
    }
}