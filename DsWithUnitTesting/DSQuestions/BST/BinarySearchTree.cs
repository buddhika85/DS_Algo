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
                        node.Left = new Node { Value = value };
                    else
                        node = node.Left;       // go left
                }
                else
                {
                    if (node.Right == null)
                        node.Right = new Node { Value = value };
                    else
                        node = node.Right;      // go right
                }
            }
        }

        public void Remove(int value)
        {

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

        public override string ToString()
        {
            var str = "BST";
            var node = Root;

            // To Do

            return str;
        }
    }
}
