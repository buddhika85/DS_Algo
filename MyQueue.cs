using System.Text;

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
            try
            {
                Prepare();
                return _outStack.Pop();
            }
            catch (InvalidOperationException)
            {                
                throw new InvalidOperationException("Queue is Empty. Cannot Deuque.");
            }
        }

        public object Peek()
        {
            try
            {
                Prepare();
                return _outStack.Peek();
            }
            catch (InvalidOperationException)
            {                
                throw new InvalidOperationException("Queue is Empty. Cannot Peek.");
            }
        }

        // returns true if empty
        public bool IsEmpty()
        {
            return !_outStack.Any() && !_inStack.Any();
        }

        // prepares to dequeue or peek
        private void Prepare()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (!_outStack.Any())
            {                
                FillOutStack();
            }
        }

        // a helper which populates _outStack from _inStack
        private void FillOutStack()
        {
            do
            {
                _outStack.Push(_inStack.Pop());
            }while(_inStack.Any());
        }

        public override string ToString()
        {
            if (IsEmpty())
                return "Empty Queue";
            FillOutStack();
            StringBuilder sb = new();
            foreach (var item in _outStack)
            {
                sb.AppendLine($"{item}");
            }
            return sb.ToString();           
        }
    }
}