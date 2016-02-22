using System;

namespace Keresofa
{
    internal class Program
    {
        public static void InOrder(Action<int> action, BinaryTree tree)
        {
            _inOrder(tree.Root, action);
        }

        private static void _inOrder(TreeNode root, Action<int> action)
        {
            if (root == null)
            {
                return;
            }

            _inOrder(root.Left, action);
            action(root.Value);
            _inOrder(root.Right, action);
        }

        public static void Main(string[] args)
        {
            int[] szamInts = {10, 1, 4, 6, 6, 3, 9, 10, 12};
            var tree = new BinaryTree(szamInts);

            InOrder(Console.WriteLine, tree);


            Console.ReadLine();
        }
    }
}