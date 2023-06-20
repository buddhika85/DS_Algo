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

    
        // null <- 1 <=> 2 <=> 3 <=> 4 -> null
        // insert node 3 before node 2        
        // null <- 1 <=> 3 <=> 2 <=> 4 -> null

        // null <- 1 <=> 2 <=> 3 <=> 4 -> null
        // insert node 5 before node 1        
        // null 5 <=> 1 <=> 3 <=> 2 <=> 4 -> null

        // O(1) time and space complexity
        public void Insert(DllNode nodeToInsert, DllNode nodeBefore)
        {
            // remove node to insert if its there
            RemoveNode(nodeToInsert);

            var newAfter = nodeBefore;
            var newBefore = nodeBefore.Prev;

            if (newBefore == null)
            {
                // insert a new head and shift all
                Head = nodeToInsert;
                nodeToInsert.Prev = null;
            }
            else
            {
                // insert in the middle
                newBefore.Next = nodeToInsert;
                nodeToInsert.Prev = newBefore;
            }

            nodeToInsert.Next = newAfter;
            newAfter.Prev = nodeToInsert;
        }

        // Time complexity - O(n)
        // space complexity - O(1)
        public void Remove(int valueToRemove)
        {
            if (Head == null)
                return;

            DllNode? lastNodeNotRemoved = Head.Value != valueToRemove ? Head : null;
            var curr = Head.Next;
            while (curr != null)
            {
                if (curr.Value != valueToRemove)
                {
                    if (lastNodeNotRemoved != null)
                    {
                        lastNodeNotRemoved.Next = curr;
                        curr.Prev = lastNodeNotRemoved;                        
                    }
                    else
                    {
                        // head changes
                        Head = curr;
                        curr.Prev = null;
                    }
                    lastNodeNotRemoved = curr;
                }
                curr = curr.Next;
            }
            Tail = lastNodeNotRemoved;
            if (lastNodeNotRemoved != null)
            {
                lastNodeNotRemoved.Next = null;
            }
            
        }
    
        // Time complexity - O(n)
        // space complexity - O(1)
        public void InsertAtPosition(int position, DllNode node)
        {
            if (node == null)
                return;     // invalid position
            if (position < 0)
                return;     // invalid position
            
            // no nodes
            if (Head == null)
            {
                Head = node;
                Tail = node;       
                return;         
            }

            // remove if exits
            RemoveNode(node);

            // insert to head
            if (position == 0)
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
                node.Prev = null;
                return;
            }          

            // insert at the position
            var index = 1;
            var curr = Head.Next;
            var inserted = false;
            while(curr != null && !inserted)
            {
                if (index == position)
                {
                    // perform the insert
                    if (curr.Prev != null)
                    {
                        curr.Prev.Next = node;
                        node.Prev = curr.Prev;
                    }
                    curr.Prev = node;
                    node.Next = curr;
                    inserted = true;
                }
                ++index;
                curr = curr.Next;
            }

            if (!inserted)
            {
                Tail.Next = node;
                node.Prev = Tail;
                node.Next = null;
                Tail = node;
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