using System.Text;

namespace DS_Algo
{
    // FIFO
    public class QueueUsingArray
    {
        private object[] _array = new object[100];
        public int Length {get; private set;}

        // join to last
        public void Enqueue(object value)
        {
            if (Length == _array.Length)
            {
                DoubleTheSize();
            }
            _array[Length++] = value;      // insert to last and then increase length
        }

        // take first out
        public object Dequeue()
        {
            if (Length == 0)
                throw new InvalidOperationException("Queue is empty. Cannot Dequeue");
            
            // first in element
            var varFirstIn = _array[0];

            // shift all to left
            for (int i = 1; i < _array.Length; i++)
            {
                _array[i - 1] = _array[i];
            }

            // decrease length
            --Length;
            return varFirstIn;
        }

        // look at first one to go out - not removing
        public object Peek()
        {
            if (Length == 0)
                throw new InvalidOperationException("Queue is empty. Cannot Dequeue");
            return _array[0];
        }

        private void DoubleTheSize()
        {
            var newArray = new object[_array.Length * 2];
            for (var i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            // dereference to new array
            _array = newArray;
        }

        public override string ToString()
        {
            if (Length == 0)
                return "Empty Queue";
            
            StringBuilder sb = new();
            sb.AppendLine($"Queue with length {Length}");
            for (int i = 0; i < Length; i++)
            {
                sb.AppendLine($"{_array[i]}");
            }
            return sb.ToString();
        }
    }
}