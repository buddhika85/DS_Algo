namespace DSQuestions.BST
{   /*
    Design a Binary Search Tree class that supports the following:
    1.Insert a value
    2.Remove a value. This method should remove the first occurrence of a value. 
    3.Find a value. If the value is found it should return the node with the value else return false.
    */
    public class BinarySearchTree
    {
        public Node? Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node { Value = value };
                return;
            }

            var node = Root;
            while (node != null)
            {
                if (value < node.Value)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node { Value = value };
                        return;
                    }
                    else
                        node = node.Left;       // go left
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node { Value = value };
                        return;
                    }
                    else
                        node = node.Right;      // go right
                }
            }
        }
        public Node? Find(int value)
        {
            var node = Root;
            while (node != null)
            {
                if (node.Value == value)
                    return node;
                if (value < node.Value)
                {
                    if (node.Left == null)
                        return null;
                    else
                        node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                        return null;
                    else
                        node = node.Right;
                }
            }
            return null;
        }

        // 3 possibilities
        // 1 - Node to remove can be a leaf node
        // 2 - Node to remove can be a node with one child
        // 3 - Node to remove can be a node with two child nodes - replace it with in order predecessor (left sub tree largest) or successor (right sub tree smallest)
        public void Remove(int value)
        {
            if (Root != null && Root.Value == value)
            {
                // remove root
                Root = null;
            }

            var parent = FindParent(value);
            if (parent == null)
            {
                throw new ArgumentException($"node with value {value} unavailable in the tree");
            }

            if (IsLeaf(parent))
            {

            }
            else
            {

            }
        }



        private bool IsLeaf(Node node)
        {
            return node.Left == null && node.Right == null;
        }

        public Node? FindParent(int value)
        {
            var node = Root;
            Node? parent = null;
            while (node != null)
            {
                if (node.Value == value)
                    return parent;
                if (value < node.Value)
                {
                    if (node.Left == null)
                        return null;
                    else
                    {
                        parent = node;
                        node = node.Left;
                    }
                }
                else
                {
                    if (node.Right == null)
                        return null;
                    else
                    {
                        parent = node;
                        node = node.Right;
                    }
                }
            }
            return null;
        }

        public override string ToString()
        {
            var str = "BST";
            var node = Root;

            // To Do

            return str;
        }
    }
}
