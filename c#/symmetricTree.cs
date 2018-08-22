namespace c_
{
    public class SymmetricTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsSymmetric(TreeNode root) {
            return isMirror(root, root);
        }
    
        public bool isMirror(TreeNode t1, TreeNode t2) {
            if(t1.left == t2.right) return true;
            if( t1.left == null && t2.right != null) return false;
            return isMirror(t1.left, t1.right);

        } 
    }
}