using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    /*
    You are given the head of a Singly Linked list. 
    Write a function that will take the given head as input, reverse the Linked List and return the new head of the reversed Linked List.
    */
    public class SinglyLinkedListReverse
    {
        public void TestReverseLinkedList()
        {
            var sll = new SinglyLinkedList();
            sll.AddAtIndex(0, 0);
            sll.AddAtIndex(1, 1);
            sll.AddAtIndex(2, 2);           
            sll.AddAtIndex(3, 3);
            sll.AddAtIndex(4, 4);
            Console.WriteLine($"{sll.ToString()}");                 // 0 -> 1 -> 2 -> 3 -> 4 
            Console.WriteLine($"length is = {sll.Length}\n");       // 5

            sll.Head = ReverseLinkedList(sll.Head);
            Console.WriteLine($"Reversed : {sll.ToString()}");                 // 4 -> 3 -> 2 -> 1 -> 0 
            Console.WriteLine($"length is = {sll.Length}\n");       // 5
        }

        public Node ReverseLinkedList(Node head)
        {
            if (head == null)
                return null;

            Node prev = null;
            Node curr = head;
            while(curr != null)
            {
                Node next = curr.Next;
                curr.Next = prev;

                prev = curr;
                curr = next;
                if (curr != null)
                {
                    next = curr.Next;
                }
                else
                {
                    next = null;
                }
            }

            if (prev != null)
            {
                head = prev;
            }
            return head;
        }
    }
}