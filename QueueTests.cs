namespace DS_Algo
{
    public class QueueTests
    {
        public void QueueUsingLLTests()
        {
            Console.WriteLine("Queue Using LL Tests");
            QueueUsingLL queue = new();
            Console.WriteLine($"{queue.ToString()}");
            
            try
            {
                Console.WriteLine("\nEmpty Queue - Peek");
                object item = queue.Peek();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            }

            try
            {
                Console.WriteLine("\nEmpty Queue - Dequeue");
                object item = queue.Dequeue();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            }

            queue.Enqueue(1);
            Console.WriteLine($"\nAfter adding 1 =\n{queue.ToString()}");

            queue.Enqueue(2);
            Console.WriteLine($"\nAfter adding 2 =\n{queue.ToString()}");

            var peedked = queue.Peek();
            Console.WriteLine($"\nPeeked top 1 = {peedked}");           
            Console.WriteLine($"After Peeking queue looks same =\n{queue.ToString()}");

            var dequeued = queue.Dequeue();
            Console.WriteLine($"\nDequeued top 1 = {dequeued}");           
            Console.WriteLine($"After dequeueing queue =\n{queue.ToString()}");

            dequeued = queue.Dequeue();
            Console.WriteLine($"\nDequeued top 1 = {dequeued}");           
            Console.WriteLine($"After dequeueing queue =\n{queue.ToString()}");

            try
            {
                Console.WriteLine("\nNothing left in the Queue - after Dequeueing");
                object item = queue.Dequeue();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            } 
        }

        public void QueueUsingArrayTests()
        {
            Console.WriteLine("Queue Using Array Tests");
            QueueUsingArray queue = new();
            Console.WriteLine($"{queue.ToString()}");
            
            try
            {
                Console.WriteLine("\nEmpty Queue - Peek");
                object item = queue.Peek();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            }

            try
            {
                Console.WriteLine("\nEmpty Queue - Dequeue");
                object item = queue.Dequeue();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            }

            queue.Enqueue(1);
            Console.WriteLine($"\nAfter adding 1 =\n{queue.ToString()}");

            queue.Enqueue(2);
            Console.WriteLine($"\nAfter adding 2 =\n{queue.ToString()}");

            var peedked = queue.Peek();
            Console.WriteLine($"\nPeeked top 1 = {peedked}");           
            Console.WriteLine($"After Peeking queue looks same =\n{queue.ToString()}");

            var dequeued = queue.Dequeue();
            Console.WriteLine($"\nDequeued top 1 = {dequeued}");           
            Console.WriteLine($"After dequeueing queue =\n{queue.ToString()}");

            dequeued = queue.Dequeue();
            Console.WriteLine($"\nDequeued top 1 = {dequeued}");           
            Console.WriteLine($"After dequeueing queue =\n{queue.ToString()}");

            try
            {
                Console.WriteLine("\nNothing left in the Queue - after Dequeueing");
                object item = queue.Dequeue();
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine($"Exception - InvalidOperationException - {e?.Message}");
            } 
        }
    }
}