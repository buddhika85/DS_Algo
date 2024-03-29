﻿namespace DSQuestions.SinglyLinkedList
{
    public class Node<T> where T : class
    {
        public T Value { get; set; } = null!;
        public Node<T>? Next { get; set; }

        public override string ToString() => Value.ToString() ?? "[Error-Node value empty]";
    }
}
