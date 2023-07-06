namespace DS_Algo
{
    // a queue using 2 stacks
    public class MyQueue
    {
        private Stack<object> _inStack = new Stack<object>();
        private Stack<object> _outStack = new Stack<object>();

        // store at the end
        public void Enqueu(object value)
        {
            _inStack.Push(value);
        }

        // first in first out
        public object Dequeu()
        {
            if (!_outStack.Any() && !_inStack.Any())
                throw new InvalidOperationException("Queue is Empty. Cannot Deuque.");

            if (!_outStack.Any())
            {
                // populate _outStack from _inStack
                do
                {
                    _outStack.Push(_inStack.Pop());
                }while(_inStack.Any());
            }

            return _outStack.Pop();
        }
    }
}