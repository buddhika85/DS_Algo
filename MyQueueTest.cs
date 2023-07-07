namespace DS_Algo
{
    public class MyQueueTest
    {
         public void Test()
         {
            MyQueue queue = new();
            Console.WriteLine(queue.ToString());

            queue.Enqueu(1);
            queue.Enqueu(2);
            queue.Enqueu(3);
            
            //Console.WriteLine($"\nLength should be 3 now \n- {queue.ToString()}");
            var peeked = queue.Peek();
            Console.WriteLine($"\nPeeked to top: \n{peeked}");        // 1

            var popped = queue.Dequeu();
            Console.WriteLine($"\nDequeues top: \n{popped}");        // 1

            //Console.WriteLine($"\nLength should be 2 now \n{queue.ToString()}");

            popped = queue.Dequeu();
            Console.WriteLine($"\nDequeues top: \n{popped}");        // 2

            popped = queue.Dequeu();
            Console.WriteLine($"\nDequeues top: \n{popped}");        // 3

            //Console.WriteLine($"\nShould be empty now \n{queue.ToString()}");

            try
            {
                Console.WriteLine($"\nPeeking to empty queue");
                peeked = queue.Peek();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e?.Message}");
            } 

            try
            {
                Console.WriteLine($"\nDequeing empty queue");
                peeked = queue.Peek();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e?.Message}");
            } 

            Console.WriteLine($"\nShould be empty now \n{queue.ToString()}");
        }
    }
}