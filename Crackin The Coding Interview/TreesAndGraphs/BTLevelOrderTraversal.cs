using System;
using System.Collections;
using System.Collections.Generic;

namespace TreesAndGraphs
{
    public class BTLevelOrderTraversal
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static List<List<int>> LevelOrder(TreeNode root) {
            List<List<int>> result = new List<List<int>>();
            if(root == null) return result;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while(q != null)
            {
                var size = q.Count;
                var currentLevel = new List<int>();

                for(int i = 0; i < size; i++)
                {
                    TreeNode current = q.Dequeue();
                    currentLevel.Add(current.val);
                    if(current.left != null)
                    {
                        q.Enqueue(current.left);
                    }
                    if(current.right != null)
                    {
                        q.Enqueue(current.right);
                    }
                }
                result.Add(currentLevel);
            }
            return result;
        }
    }
}