namespace DSQuestions.SinglyLinkedList
{
    public class SinglyLinkedList<T> where T : class
    {
        public Node<T>? Head { get; private set; }
        public Node<T>? Tail { get; private set; }

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
        public void AddAtHead(T value)
        {
            var newNode = new Node<T> { Next = null, Value = value };

            if (Size == 0)
            {
                // now the size will become 1
                AddAsTheFirstToAnEmptyLinkedList(newNode);
            }
            else
            {
                // size will be current size + 1
                AddAsTheFirstToNonEmptyLinkedList(newNode);
            }

            ++Size;
        }


        //•	addAtTail(value) -  Add a node of given value at the last element of the linked list.
        public void AddAtTail(T value)
        {
            var newNode = new Node<T> { Next = null, Value = value };

            if (Size == 0 || Head == null || Tail == null)
            {
                // now the size will become 1
                AddAsTheFirstToAnEmptyLinkedList(newNode);
            }
            else
            {
                // size will be current size + 1
                AddToTailOfNonEmptyLinkedList(newNode);
            }

            ++Size;
        }

        //•	addAtIndex(index, value) Add a node of given value before the index th node in the linked list.
        //•	If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, don’t insert the node.
        public void AddAtIndex(int index, T value)
        {
            var newNode = new Node<T> { Next = null, Value = value };

            if (Size == 0 || Head == null || Tail == null)
            {
                // empty
                if (index == 0)
                {
                    // add to head
                    AddAsTheFirstToAnEmptyLinkedList(newNode);
                    ++Size;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"LL is empty. You can only insert to index 0. You cannot insert a node to index {index} for this.");
                }
            }
            else
            {
                // non empty
                if (index <= Size)
                {
                    // valid
                    if (index == 0)
                    {
                        // add to head
                        AddAsTheFirstToNonEmptyLinkedList(newNode);
                    }
                    else if (index == Size)
                    {
                        // add to tail
                        AddToTailOfNonEmptyLinkedList(newNode);
                    }
                    else
                    {
                        // add to middle
                        var currentIndex = 1;
                        var previousOfNewNode = Head.Next;
                        while (previousOfNewNode != null && currentIndex != index)
                        {
                            ++currentIndex;
                            previousOfNewNode = previousOfNewNode.Next;
                        }

                        if (previousOfNewNode == null)
                        {
                            throw new InvalidOperationException($"Cannot insert to {index} of the Linked List. Please check the logic.");
                        }

                        var newNext = previousOfNewNode.Next;
                        previousOfNewNode.Next = newNode;
                        newNode.Next = newNext;
                    }
                    ++Size;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"LL alreay has {Size} nodes. You can only put elements to indexes 0 to {Size} to this.");
                }
            }
        }


        //•	deleteAtIndex(index) Delete the index th node in the linked list, if the index is valid, else nothing happens.
        public void DeleteIndex(int index)
        {
            if (Size == 0 || Head == null || Tail == null)
            {
                // empty LL
                throw new ArgumentOutOfRangeException($"LL is empty. You can cannot delete any element of this.");
            }

            // non empty LL
            if (index < Size)
            {
                // valid
                if (index == 0)
                {
                    if (Size == 1)
                    {
                        Head = null;
                        Tail = null;
                    }
                    else
                    {
                        var toDelete = Head;
                        Head = toDelete.Next;
                        toDelete.Next = null;
                    }
                }
                else if (index <= Size - 1)
                {
                    // delete last or
                    // delete from middle
                    var previous = Head;
                    var current = Head.Next;
                    var currentIndex = 1;

                    while (currentIndex < index && current != null)
                    {
                        currentIndex++;
                        previous = current;
                        current = current.Next;
                    }

                    // now index == currentIndex
                    if (index == Size - 1)
                    {
                        // delete last
                        previous.Next = null;
                        Tail = previous;
                    }
                    else
                    {
                        // delete from middle
                        var newNext = current?.Next;
                        previous.Next = newNext;

                        if (current != null)
                            current.Next = null;
                    }
                }

                --Size;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"LL alreay has {Size} nodes. You can only put elements to indexes 0 to {Size} to this.");
            }
        }


        private void AddAsTheFirstToAnEmptyLinkedList(Node<T> newNode)
        {
            Head = newNode;
            Tail = newNode;
        }


        private void AddAsTheFirstToNonEmptyLinkedList(Node<T> newNode)
        {
            var oldHead = Head;
            Head = newNode;
            newNode.Next = oldHead;
        }

        private void AddToTailOfNonEmptyLinkedList(Node<T> newNode)
        {
            if (Tail != null)
                Tail.Next = newNode;
            Tail = newNode;
        }
    }
}
