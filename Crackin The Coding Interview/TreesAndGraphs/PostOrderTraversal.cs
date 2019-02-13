namespace TreesAndGraphs
{
    public class PostOrderTraversal
    {
        public static PostOrder(Node node)
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