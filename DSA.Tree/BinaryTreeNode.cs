
namespace DSA.Tree
{
    public  class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Data = value;
            Left = null;
            Right = null;
        }

        public void Bfs()
        {
            Bfs(this);
        }

        public void DfsPreOrder()
        {
            DfsPreOrder(this);
        }

        public void DfsPostOrder()
        {
            DfsPostOrder(this);
        }

        public void DfsInOrder()
        {
            DfsInOrder(this);
        }

        private void DfsInOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            DfsInOrder(node.Left);
            Console.Write(node.Data + " ");
            DfsInOrder(node.Right);
        }

        private void DfsPreOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            // Visit left child
            DfsPreOrder(node.Left);
            // Visit right child
            DfsPreOrder(node.Right);
        }

        private void DfsPostOrder(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            // Visit left child
            DfsPostOrder(node.Left);

            // Visit right child
            DfsPostOrder(node.Right);

            Console.Write(node.Data + " ");
        }

        private void Bfs(BinaryTreeNode<T> node)
        {
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Data + " ");
                // Enqueue left child
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                // Enqueue right child
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
