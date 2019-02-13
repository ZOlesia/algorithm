namespace TreesAndGraphs
{
    public class InOrderTraversal
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int x) { data = x; }
        }
        public static void InOrder(Node node)
        {
            if(node != null)
            {
                InOrder(node.left);
                System.Console.WriteLine(node.data);
                InOrder(node.right);
            }
        }
    }
}