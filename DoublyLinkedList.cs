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

        public void RemoveNode(DllNode node)
        {
            if (node == null)
                return;
            
            var curr = Head;
            while(curr != null)
            {
                if (curr ==  node)
                {
                    if (curr == Head)
                    {
                        // remove first node
                        Head = curr.Next;
                        if (curr.Next != null)
                        {
                            curr.Next.Prev = null;
                        }
                    }
                    else if (curr == Tail)
                    {
                        // remove last node
                        Tail = curr.Prev;
                        if (curr.Prev != null)
                        {
                            curr.Prev.Next = null;
                        }
                    }
                    else
                    {
                        // remove from middle
                        if (curr.Prev != null)
                            curr.Prev.Next = curr.Next;
                        if (curr.Next != null)
                            curr.Next.Prev = curr.Prev;
                    }
                }
                curr = curr.Next;
            }
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