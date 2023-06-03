using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    /*
    You are given the head of a Sorted Singly Linked list. 
    Write a function that will take the given head as input, delete all nodes that have a value that 
    is already the value of another node so that each value appears 1 time only and return the linked list, which is still to be a sorted linked list."
    */
    public class SinglyLinkedListRemoveDuplicates
    {

        public void RemoveDuplicatesTest()
        {
            var sll = new SinglyLinkedList();
            sll.AddAtIndex(0, 1);
            sll.AddAtIndex(1, 1);
            sll.AddAtIndex(2, 2);
            sll.AddAtIndex(3, 2);
            sll.AddAtIndex(4, 2);
            sll.AddAtIndex(5, 3);
            sll.AddAtIndex(6, 4);
            sll.AddAtIndex(7, 4);
            sll.AddAtIndex(8, 4);
            sll.AddAtIndex(9, 4);
            sll.AddAtIndex(10, 5);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 1 -> 2 -> 2 -> 2 -> 3 -> 4 -> 4 -> 4 -> 4 -> 5
            Console.WriteLine($"length is = {sll.Length}\n");       // 11

            RemoveDuplicates(sll.Head);
            Console.WriteLine($"{sll.ToString()}");                 // 1 -> 2 -> 3 -> 4 -> 5
            Console.WriteLine($"length is = {sll.Length}\n");       // 11
        }

        public void RemoveDuplicates(Node head)
        {
            if (head == null)
                return;

            var node = head;
            var currUnique = node.Value;
            while(node.Next != null)
            {
                var nextNode = node.Next;
                if (currUnique == nextNode.Value)
                {
                    // duplicated value - remove next node
                    node.Next = nextNode.Next;
                    nextNode = null;
                }
                else
                {
                    node = nextNode;
                    currUnique = node.Value;
                }
            }
        }
    }
}