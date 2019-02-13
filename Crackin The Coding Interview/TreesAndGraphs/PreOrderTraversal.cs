namespace TreesAndGraphs
{
    public class PreOrderTraversal
    {
        public static PreOrder(Node node)
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