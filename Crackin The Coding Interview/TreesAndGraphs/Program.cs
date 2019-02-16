using System;

namespace TreesAndGraphs
{
    class Program
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static TreeNode ArrayToBST(int[] arr, int l, int r)
        {
            l = 0;
            r = arr.Length-1;
            var mid = (l+r)/2;

            if(r < l) return null;

            TreeNode root = new TreeNode(arr[mid]);
            root.left = ArrayToBST(arr, l, mid-1);
            root.right = ArrayToBST(arr, mid+1, r);

            return root;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
