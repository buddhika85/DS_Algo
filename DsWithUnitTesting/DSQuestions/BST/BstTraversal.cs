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


        public List<int> DepthFirstSearchInOrder(BinarySearchTree bst)
        {
            // To Do
            return new List<int>();
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
