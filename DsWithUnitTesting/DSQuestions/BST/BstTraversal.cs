namespace DSQuestions.BST
{
    public class BstTraversal
    {
        public List<int> BreadFirstSearch(BinarySearchTree bst)
        {
            if (bst.Root == null)
                return new List<int>();

            List<int> list = new();
            Queue<Node> queue = new();

            queue.Enqueue(bst.Root);
            while (queue.Count > 0)                     // while there is something in the queue
            {
                var current = queue.Dequeue();
                list.Add(current.Value);
                if (current.Left != null)
                    queue.Enqueue(current.Left);
                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }
            return list;
        }

        // left,current,right
        public List<int> DepthFirstSearchInOrder(BinarySearchTree bst)
        {
            if (bst.Root == null)
                return new List<int>();

            List<int> list = new();
            InOrderTraverse(bst.Root, list);
            return list;
        }

        private void InOrderTraverse(Node node, List<int> list)
        {
            if (node.Left != null)
                InOrderTraverse(node.Left, list);
            list.Add(node.Value);
            if (node.Right != null)
                InOrderTraverse(node.Right, list);
        }

        // current, left, right
        public List<int> DepthFirstSearchPreOrder(BinarySearchTree bst)
        {
            if (bst.Root == null) return new List<int>();
            List<int> list = new();
            PreOrderTraversal(bst.Root, list);
            return list;
        }

        private void PreOrderTraversal(Node node, List<int> list)
        {
            list.Add(node.Value);
            if (node.Left != null)
                PreOrderTraversal(node.Left, list);
            if (node.Right != null)
                PreOrderTraversal(node.Right, list);
        }

        // left, right, current
        public List<int> DepthFirstSearchPostOrder(BinarySearchTree bst)
        {
            if (bst.Root == null)
                return new List<int>();
            List<int> list = new();
            PostOrderTraversal(bst.Root, list);
            return list;
        }

        private void PostOrderTraversal(Node node, List<int> list)
        {
            if (node.Left != null)
                PostOrderTraversal(node.Left, list);
            if (node.Right != null)
                PostOrderTraversal(node.Right, list);
            list.Add(node.Value);
        }
    }
}
