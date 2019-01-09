namespace c_
{
    public class convertToBST
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int x)
            {
                data = x;
                left = right = null;
            }
        }

    public class BinaryTree
    {
        public Node root;
        public static Node SortedArrayToBST(int[] arr, int start, int end)
        {
            if(start > end) {return null; }

            int middle = (start + end) / 2;
            var newNode = new Node(arr[middle]);
            newNode.left = SortedArrayToBST(arr, start, middle-1);
            newNode.right = SortedArrayToBST(arr, middle+1, end);
            return newNode;
        }
    }
        

    }
}