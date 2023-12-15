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
        // 3 - Node to remove can be a node with two child nodes -
        //              replace it with in order predecessor (left sub tree largest)
        //                      or successor (right sub tree smallest) ----------> we use this below
        public void Remove(int value, Node? current = null, Node? parent = null)
        {
            if (current == null)
                current = Root;
            var notRemoved = true;
            while (current != null && notRemoved)
            {
                if (value < current.Value)
                {
                    // go left
                    parent = current;
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    // gor right
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // found the node to delete

                    // case 1 - node has 2 children
                    if (current.Left != null && current.Right != null)
                    {

                        // 1.1 find min of right sub tree
                        var min = FindMin(current.Right);
                        current.Value = min.Value;                                      // now there are 2 nodes with value - min.Value  
                        Remove(min.Value, current.Right, current);                     // remove min node from right sub tree
                    }

                    // case 2 - node is root,  but do not have 2 children, may be 1 or 0 child nodes
                    else if (parent == null)
                    {
                        if (current.Left != null)
                        {
                            // has only left child
                            current.Value = current.Left.Value;
                            current.Left = current.Left.Left;
                            current.Right = current.Left?.Right;
                        }
                        else if (current.Right != null)
                        {
                            // has only right child
                            current.Value = current.Right.Value;
                            current.Left = current.Right?.Left;
                            current.Right = current.Right?.Right;
                        }
                        else
                        {
                            // no left, no right
                            Root = null;                // now no nodes in tree
                        }
                    }

                    // case 3 - node has only one child
                    else if (current == parent.Left)
                    {
                        // only left child there
                        parent.Left = current.Left != null ? current.Left : current?.Right;

                    }
                    else if (current == parent.Right)
                    {
                        // only right child there
                        parent.Right = current.Left != null ? current.Left : current?.Right;
                    }
                    // now removal is complete 
                    // break out of the loop
                    notRemoved = false;
                }
            }
        }

        private Node FindMin(Node node)
        {
            // go, left, left,...left, until there is no left element to find min
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        private bool HasTwoChildren(Node node)
        {
            return node.Left != null && node.Right != null;
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
