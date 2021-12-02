using Algorithm._1BinaryTree;

namespace Algorithm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            _1BinaryTree.BinaryTree<int> binaryTree = new BinaryTree<int>();

            int[] arr = {88, 80, 95, 76, 82, 90, 98};
            foreach (var item in arr)
            {
                binaryTree.Insert(item);
            }

            // binaryTree.MiddleTraversal(binaryTree.Root);

            binaryTree.Delete(88);
            
            binaryTree.MiddleTraversal(binaryTree.Root);
        }
    }
}