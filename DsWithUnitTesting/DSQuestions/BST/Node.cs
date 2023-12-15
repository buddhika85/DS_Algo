namespace DSQuestions.BST
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public override string ToString()
        {
            return $"Node - Value: {Value}, HasLeft: {Left != null}, HasRight: {Right != null}";
        }
    }
}
