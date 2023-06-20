namespace DS_Algo
{
    public class StackUsingArrayTests
    {
        private StackUsingArray _stackUsingArray = new StackUsingArray();

        public void Test()
        {
            Display();

            _stackUsingArray.Push(1);
            Console.WriteLine("After pushing 1");
            Display();

             _stackUsingArray.Push(2);
            Console.WriteLine("After pushing 2");
            Display();

             _stackUsingArray.Push(3);
            Console.WriteLine("After pushing 3");
            Display();

            Console.WriteLine($"peekedValue: {_stackUsingArray.Peek()}");
            Console.WriteLine("After peeking stack should look the same:");
            Display();

            Console.WriteLine($"popedValue: {_stackUsingArray.Pop()}");
            Console.WriteLine("After poping stack should not have top element which was 3:");
            Display();
        }

        private void Display()
        {
            Console.WriteLine($"Length: {_stackUsingArray.Length}, => \n{_stackUsingArray.ToString()}");
        }
    }
}