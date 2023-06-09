namespace DS_Algo
{
    public class DoublyLinkedList
    {
        public DllNode? Head { get; set; }
        public DllNode? Tail { get; set; }
    }

    public class DllNode
    {
        public int Value { get; set; }
        public DllNode? Prev { get; set; }
        public DllNode? Next { get; set; }
    }
}