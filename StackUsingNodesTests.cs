
namespace DS_Algo
{
    public class StackUsingNodesTests
    {
        public void Test()
        {
            StackUsingNodes stack = new();
            Console.WriteLine(stack.ToString());        // Empty stack

            try
            {
                Console.WriteLine("\nPop on empty stack");
                Console.WriteLine($"{stack.Pop()}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"IndexOutOfRangeException - {e.Message}");
            }

            try
            {
                Console.WriteLine("\nPeek on empty stack");
                Console.WriteLine($"{stack.Peek()}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"IndexOutOfRangeException - {e.Message}");
            }

            
            Console.WriteLine("\nPush on empty stack");
            stack.Push(1);
            Console.WriteLine(stack.ToString());        // 1

            Console.WriteLine("Push another");
            stack.Push(2);
            Console.WriteLine(stack.ToString());        // 1, 2

            Console.WriteLine($"Peeked - {stack.Peek()}");  // 2           
            Console.WriteLine(stack.ToString());        // 1, 2

             Console.WriteLine($"Poped - {stack.Pop()}");  // 2           
            Console.WriteLine(stack.ToString());        // 1
        }
    }
}