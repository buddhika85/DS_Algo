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
            InOrderTraverseSingleNode(bst.Root, list);
            return list;
        }

        private void InOrderTraverseSingleNode(Node node, List<int> list)
        {
            if (node.Left != null)
                InOrderTraverseSingleNode(node.Left, list);
            list.Add(node.Value);
            if (node.Right != null)
                InOrderTraverseSingleNode(node.Right, list);
        }

        public List<int> DepthFirstSearchPreOrder(BinarySearchTree bst)
        {
            // To Do
            return new List<int>();
        }

        public List<int> DepthFirstSearchPostOrder(BinarySearchTree bst)
        {
            // To Do
            return new List<int>();
        }
    }
}
