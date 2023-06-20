using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    public class StackUsingArray
    {
        private readonly int increaseFact = 100;
        private int[] _array;
        public int Length { get; private set; }

        public StackUsingArray()
        {
            _array = new int[increaseFact];     // for now size is 100, if this is not enough we will increase it
        }

        public void Push(int value)
        {
            if (Length == _array.Length)
            {
                Resize();
            }
            // add to top of the array
            _array[Length] = value;
            ++Length;
        }

        public int? Pop()
        {     
            if (Length == 0)
                return null;

            --Length;
            // remove from the top of the array
            var last = _array[Length];
            _array[Length] = 0;
            return last;
        }

        public int? Peek()
        {
            if (Length == 0)
                return null;
            // return top, but do not remove
            return _array[Length - 1];
        }

        private void Resize()
        {
            var resizeArray = new int[_array.Length + increaseFact];
            for (int i = 0; i < _array.Count(); i++)
            {
                resizeArray[i] = _array[i];
            }
            _array = resizeArray;
        }
    }
}