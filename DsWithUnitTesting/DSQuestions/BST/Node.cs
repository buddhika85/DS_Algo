namespace DSQuestions.BST
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public bool HasLeft => Left != null;
        public bool HasRight => Right != null;

        public override string ToString()
        {
            return $"Node - Value: {Value}, HasLeft: {Left != null}, HasRight: {Right != null}";
        }
    }
}
