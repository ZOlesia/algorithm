namespace TreesAndGraphs
{
    public class PreOrderTraversal
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int x) { data = x; }
        }
        public static void PreOrder(Node node)
        {
            if(node != null)
            {
                System.Console.WriteLine(node.data);
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
    }
}