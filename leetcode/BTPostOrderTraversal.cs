using System.Collections.Generic;

namespace leetcode
{
    public class BTPostOrderTraversal
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static List<int> PostorderTraversal(TreeNode root) {
            var values = new List<int>();
            if(root == null) return values;

            var stack = new Stack<TreeNode>();

            stack.Push(root);

            while(stack.Count != 0){
                var current = stack.Pop();

                values.Insert(0, current.val);

                if(current.left != null){
                    stack.Push(current.left);
                }

                if(current.right != null){
                    stack.Push(current.right);
                }
            }

            return values;
        }
    }
}