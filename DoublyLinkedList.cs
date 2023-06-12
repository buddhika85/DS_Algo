using System.Text;

namespace DS_Algo
{
    public class DoublyLinkedList
    {
        public DllNode? Head { get; set; }
        public DllNode? Tail { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            var node = Head;
            while(node != null)
            {
                if (node == Head)
                {
                    stringBuilder.Append("Head -> ");
                }
                else if (node != Head)
                {
                    stringBuilder.Append(" <=> ");
                }
                stringBuilder.Append($"{node.Value}");
                if (node == Tail)
                {
                    stringBuilder.Append(" <- Tail");
                }
                node = node.Next;
            }
            return stringBuilder.ToString();
        }

        // O(1) time and space complexity
        public void RemoveNode(DllNode node)
        {
            if (node == null)
                return;

            if (node == Head)
            {
                // remove first node
                Head = node.Next;
                if (node.Next != null)
                {
                    node.Next.Prev = null;
                }
            }
            else if (node == Tail)
            {
                // remove last node
                Tail = node.Prev;
                if (node.Prev != null)
                {
                    node.Prev.Next = null;
                }
            }
            else
            {
                // remove from middle
                if (node.Prev != null)
                    node.Prev.Next = node.Next;
                if (node.Next != null)
                    node.Next.Prev = node.Prev;
            }            
        }

        // Head -> 1 <=> 2 <=> 3 <- Tail
        // put 3 before 2 - output = Head -> 1 <=> 3 <=> 2 <- Tail
        // nodeBefore = 2, nodeToInsert = 3
        // next = nodeToInsert.next
        // prev = nodebefore.prev
        // if prev == null
        //      head = nodeToInsetr
        // else
        //      prev.next = nodeToInsert
        // nodeToInsert.prev = prev
        // nodeBefore.prev = nodeToInsert
        // nodeBefore.next = next
        // if next == null
        //      tail = nodeBefore
        public void Insert(DllNode nodeToInsert, DllNode nodeBefore)
        {

        }
    }

    public class DllNode
    {
        public int Value { get; set; }
        public DllNode? Prev { get; set; }
        public DllNode? Next { get; set; }

        public override string ToString()
        {
            return $"Current = {Value}\tPrev = {Prev?.Value}\tNext {Next?.Value}";
        }
    }
}