using DSA.Tree;

/*
        1
       / \
      2   3
     / \ / \
    4  5 6  7
 */

var root = new BinaryTreeNode<int>(1);
root.Left = new BinaryTreeNode<int>(2);
root.Right = new BinaryTreeNode<int>(3);
root.Left.Left = new BinaryTreeNode<int>(4);
root.Left.Right = new BinaryTreeNode<int>(5);
root.Right.Left = new BinaryTreeNode<int>(6);
root.Right.Right = new BinaryTreeNode<int>(7);

Console.WriteLine("BFS Pre Order Traversal:");
root.DfsPreOrder();

Console.WriteLine("\n\nBFS Post Order Traversal:");
root.DfsPostOrder();

Console.WriteLine("\n\nBFS In Order Traversal: ");
root.DfsInOrder();

Console.ReadKey();
