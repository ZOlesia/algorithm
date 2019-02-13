namespace TreesAndGraphs
{
    public class PostOrderTraversal
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int x) { data = x; }
        }
        public static void PostOrder(Node node)
        {
            if(node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                System.Console.WriteLine(node.data);
            }
        }
    }
}