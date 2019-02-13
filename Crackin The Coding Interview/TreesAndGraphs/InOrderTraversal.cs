namespace TreesAndGraphs
{
    public class InOrderTraversal
    {
        public static InOrder(Node node)
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