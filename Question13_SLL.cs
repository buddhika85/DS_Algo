using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    public class Question13_SLL
    {
        public void TestSinglyLinkedList()
        {
            var sll = new SinglyLinkedList();
            Console.WriteLine($"{sll.ToString()}");                 // No Elements
            Console.WriteLine($"length is = {sll.Length}\n");       // 0


            sll.AddAtHead(2);
            Console.WriteLine($"{sll.ToString()}");                 // 2
            Console.WriteLine($"length is = {sll.Length}\n");       // 1

            sll.AddAtTail(3);
            Console.WriteLine($"{sll.ToString()}");                 // 2 -> 3
            Console.WriteLine($"length is = {sll.Length}\n");       // 2

            sll.AddAtHead(1);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 2 -> 3
            Console.WriteLine($"length is = {sll.Length}\n");       // 3

            sll.AddAtTail(4);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 2 -> 3 -> 4
            Console.WriteLine($"length is = {sll.Length}\n");       // 4

            sll.AddAtIndex(0, 0);
            Console.WriteLine($"{sll.ToString()}");                 // 0 -> 1 -> 2 -> 3 -> 4
            Console.WriteLine($"length is = {sll.Length}\n");       // 5

            sll.AddAtIndex(5, 5);
            Console.WriteLine($"{sll.ToString()}");                 // 0 -> 1 -> 2 -> 3 -> 4 -> 5
            Console.WriteLine($"length is = {sll.Length}\n");       // 6

            sll.AddAtIndex(3, 30);
            Console.WriteLine($"{sll.ToString()}");                 // 0 -> 1 -> 2 -> 30 -> 3 -> 4 -> 5
            Console.WriteLine($"length is = {sll.Length}\n");       // 7

            try
            {
                sll.AddAtIndex(10, 30);
            }
            catch (Exception e)
            {
                if (e != null && e is ArgumentException)
                {
                    Console.WriteLine($"ArgumentException - {e.Message}");
                }
                else
                {
                    Console.WriteLine($"Exception - {e?.GetType()}, {e?.Message}");
                }
            }

            sll.DeleteAtIndex(0);
            Console.WriteLine($"\n{sll.ToString()}");               // 1 -> 2 -> 30 -> 3 -> 4 -> 5
            Console.WriteLine($"length is = {sll.Length}\n");       // 6

            sll.DeleteAtIndex(5);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 2 -> 30 -> 3 -> 4 
            Console.WriteLine($"length is = {sll.Length}\n");       // 5

            sll.DeleteAtIndex(2);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 2 -> 3 -> 4 
            Console.WriteLine($"length is = {sll.Length}\n");       // 4

            try
            {
                sll.DeleteAtIndex(10);
            }
            catch (Exception e)
            {
                if (e != null && e is ArgumentException)
                {
                    Console.WriteLine($"ArgumentException - {e.Message}");
                }
                else
                {
                    Console.WriteLine($"Exception - {e?.GetType()}, {e?.Message}");
                }
            }

            var node = sll.Get(2);
            Console.WriteLine($"\nIndex 2 value is => {node?.Value}");                 // 3
        }
    }
}