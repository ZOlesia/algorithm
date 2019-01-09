namespace c_
{
    public class bst 
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }

            public TreeNode SearchBST(TreeNode root, int val) {
                
                if(root == null || root.val == val) return root;
                
                while(root != null)
                {
                    if(root.val == val) return root;
                    if(val > root.val)
                    {
                        root = root.right;
                    }
                    else
                    {
                        root = root.left;
                    }
                }
                
                return root;
            }

            public bool IsUnivalTree(TreeNode root) {

                if(root == null) return true;
                
                if(root.left != null && root.left.val != root.val) return false;
                if(root.right != null && root.right.val != root.val) return false;
                
                return IsUnivalTree(root.left) & IsUnivalTree(root.right);
                
            }
        }
    }
}