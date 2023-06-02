using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo
{
    /*
    Construct SLL	"Design a Singly linked list class that has a head and tail. Every node is to have two attributes: value:  the value of the current node, and next: a pointer to the next node. The linked list is to be 0-indexed. The class should support the following: 
                SinglyLinkedList() Initializes the SinglyLinkedList object.
                get(index) Get the value of the indexth node. If the index is invalid, return null.
                addAtHead(value)- Add a node of given value before the first element of the linked list. 
                addAtTail(value) -  Add a node of given value at the last element of the linked list.
                addAtIndex(index, value) Add a node of given value before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, don’t insert the node.
                deleteAtIndex(index) Delete the indexth node in the linked list, if the index is valid, else nothing happens."
    */
    public class SinglyLinkedList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        public int Length { get; set; }

        // get(index) Get the value of the indexth node. If the index is invalid, return null.
        public Node? Get(int index)
        {
            if (IsEmpty())
                return null;

            var currIndex = 0;
            var node = Head;
            while (node != null)
            {
                if (currIndex == index)
                    return node;
                node = node.Next;
                ++currIndex;
            }
            return null;
        }

        // addAtHead(value)- Add a node of given value before the first element of the linked list. 
        public void AddAtHead(int value)
        {
            var newNode = new Node { Value = value };
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            ++Length;
        }

        // addAtTail(value) -  Add a node of given value at the last element of the linked list.
        public void AddAtTail(int value)
        {
            var newNode = new Node { Value = value };
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            ++Length;
        }

        // addAtIndex(index, value) Add a node of given value before the indexth node in the linked list. 
        // If index equals the length of the linked list, the node will be appended to the end of the linked list. 
        // If index is greater than the length, don’t insert the node.
        public void AddAtIndex(int index, int value)
        {
            if (index > Length)
            {
                throw new ArgumentException($"Illegal Index value - cannot add to index {index}, because the length is {Length}");
            }
            else if (index == Length)
            {
                AddAtTail(value);
            }
            else if (index == 0)
            {
                AddAtHead(value);
            }
            else
            {               
                var prev = Get(index - 1);
                var newNode = new Node { Value = value, Next = prev.Next };
                prev.Next = newNode;
                ++Length;
            }
        }

        // deleteAtIndex(index) Delete the indexth node in the linked list, if the index is valid, else nothing happens."
        public void DeleteAtIndex(int index)
        {
            if (index >= Length)
            {
                throw new ArgumentException($"Illegal Index value - cannot remove from index {index}, because the length is {Length}");
            }
            else if (index == 0)
            {
                // remove from head
                Head = Head.Next;
                --Length;
            }
            else if (index == Length - 1)
            {
                // remove from end
                var prev = Get(index - 1);
                prev.Next = null;
                Tail = prev;
                --Length;
            }
            else
            {
                // remove from middle
                var prev = Get(index - 1);
                prev.Next = prev.Next.Next;
                --Length;
            }
        }

        private bool IsEmpty()
        {
            return Length == 0 || Head == null;
        }

        public override string ToString()
        {
            if (IsEmpty())
                return "No Elements";

            var node = Head;
            if (node == null)
                return "No Elements";

            var builder = new StringBuilder();
            builder.Append(node.Value);
            while (node.HasNext())
            {
                node = node.Next;
                builder.Append($" -> {node.Value}");
            }
            return builder.ToString();
        }
    }

    public class Node
    {
        private int _value;
        private Node? _next;

        public int Value { get => _value; set => _value = value; }
        public Node? Next { get => _next; set => _next = value; }

        public bool HasNext()
        {
            return this._next != null;
        }
    }
}