using System.Text;

namespace DS_Algo
{
    public class QueueNode
    {
        public object Value { get; set; } = null!;
        public QueueNode? Next { get; set; }
    }

    public class QueueUsingLL
    {
        public QueueNode? First { get; private set; }
        public QueueNode? Last { get; private set; }
        public int Length { get; private set; }

        public void Enqueue(object value)
        {
            if (Length == 0)
            {
                First = new QueueNode { Value =  value,  Next = null};
                Last = First;
                Length = 1;
                return;
            }

            Last.Next = new QueueNode { Value =  value,  Next = null};
            Last = Last.Next;
            ++Length;
            return;
        }

        public object Dequeue()
        {
            if (Length == 0)
                throw new InvalidOperationException("Queue empty. Cannot Dequeue");

            var dequeued = First;

            if (Length == 1)
            {
                First =  null;
                Last = null;
            }
            else
            {
                First = dequeued.Next;
            }
            --Length;
            return dequeued;
        }

        public object Peek()
        {
            if (Length == 0)
                throw new InvalidOperationException("Queue empty. Cannot Peek");
            
            return First?.Value;
        }

        public override string ToString()
        {
            if (Length == 0)
                return "Empty queue";
            
            StringBuilder sb = new();
            sb.AppendLine($"Queue with length {Length}");
            var curr = First;
            while(curr != null)
            {
                sb.AppendLine($"{curr.Value}");
                curr = curr.Next;
            }
            return sb.ToString();
        }
    }
}