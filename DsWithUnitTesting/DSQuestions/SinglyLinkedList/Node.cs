namespace DSQuestions.SinglyLinkedList
{
    public class Node<T> where T : class
    {
        public T Value { get; set; } = null!;
        public Node<T>? Next { get; set; }
    }
}
