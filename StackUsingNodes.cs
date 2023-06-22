using System.Text;

namespace DS_Algo
{
    public class StackUsingNodes
    {
        public StackNode? First { get; private set; }
        public StackNode? Last { get; private set; }
        public int Length { get; private set; } = 0;

        // create a new node and push to the top of the stack - Last in on top
        public void Push(int value)
        {
            StackNode? currTop = First;
            First = new StackNode { Value = value, Next = currTop };
            if (currTop == null)
            {                
                Last = First;
            }
            else
            {
                Last = currTop;
            }
            ++Length;
        }

        // remove from top of the stack - LIFO
        public int Pop()
        {
            if (First == null)      // same as Length == 0
                throw new IndexOutOfRangeException("Stack is empty, cannot pop");

            var popped = First;
            First = First.Next;
            if (Last == popped)
                Last = First;            
            --Length;
            return popped.Value;
        }

        // return top of the stack value, but do not remove
        public int Peek()
        {
            if (First == null)      // same as Length == 0
                throw new IndexOutOfRangeException("Stack is empty, cannot pop");
            
            return First.Value;
        }

        public override string ToString()
        {            
            if (Length == 0)
                return "Empty Stack";

            StringBuilder sb = new();
            var curr = First;
            while(curr != null)
            {
                sb.AppendLine($"{curr.Value}");
                curr = curr.Next;
            }
            return sb.ToString();
        }
    }

    public class StackNode
    {
        public int Value { get; set; }
        public StackNode? Next { get; set; }
    }
}