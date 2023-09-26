﻿namespace DSQuestions.SinglyLinkedList
{
    public class SinglyLinkedList<T> where T : class
    {
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Index { get; private set; } = 0;
        public int Size { get; private set; } = 0;

        //•	SinglyLinkedList() Initializes the SinglyLinkedList object. - Done by default constructor

        //•	get(index) Get the value of the index th node.If the index is invalid, return -1.
        public T Get(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException($"{index} - requested index is less than zero");
            if (Head == null)
                throw new ArgumentOutOfRangeException($"Empty Singly List. Size: {Size}");
            if (index >= Size)
                throw new InvalidOperationException($"{index} Index is out of bounds of size {Size}");
            var current = Head;
            var currentIndex = 0;
            while (current != null)
            {
                if (currentIndex == index)
                    return current.Value;

                current = current.Next;
                ++currentIndex;
            }

            // if reached here - it means index out of bounds
            throw new InvalidOperationException($"{index} Index is out of bounds of size {Size}");
        }

        //•	addAtHead(value)- Add a node of given value before the first element of the linked list.
        //•	addAtTail(value) -  Add a node of given value at the last element of the linked list.
        //•	addAtIndex(index, value) Add a node of given value before the index th node in the linked list.
        //•	If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, don’t insert the node.
        //•	deleteAtIndex(index) Delete the index th node in the linked list, if the index is valid, else nothing happens.

    }
}
