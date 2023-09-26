namespace DSQuestions.SinglyLinkedList
{
    public class SinglyLinkedList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        public int Index { get; private set; } = 0;
        public int Size { get; private set; } = 0;

        //•	SinglyLinkedList() Initializes the SinglyLinkedList object.
        //•	get(index) Get the value of the index th node.If the index is invalid, return -1.
        //•	addAtHead(value)- Add a node of given value before the first element of the linked list.
        //•	addAtTail(value) -  Add a node of given value at the last element of the linked list.
        //•	addAtIndex(index, value) Add a node of given value before the index th node in the linked list.
        //•	If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, don’t insert the node.
        //•	deleteAtIndex(index) Delete the index th node in the linked list, if the index is valid, else nothing happens.

    }
}
