using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo
{
    // FIFO
    public class QueueUsingArray
    {
        private object[] _array = new object[100];
        private int _length;

        // join to last
        public void Enqueue(object value)
        {
            if (_length == _array.Length)
            {
                DoubleTheSize();
            }
            _array[_length++] = value;      // insert to last and then increase length
        }

        // take first out
        public object Dequeue()
        {
            if (_length == 0)
                throw new InvalidOperationException("Queue is empty. Cannot Dequeue");
            
            // first in element
            var varFirstIn = _array[0];

            // shift all to left
            for (int i = 1; i < _array.Length; i++)
            {
                _array[i - 1] = _array[i];
            }

            // decrease length
            --_length;
            return varFirstIn;
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
            if (_length == 0)
                return "Empty Queue";
            
            StringBuilder sb = new();
            for (int i = 0; i < _array.Length; i++)
            {
                sb.AppendLine($"{_array[i]}");
            }
            return sb.ToString();
        }
    }
}