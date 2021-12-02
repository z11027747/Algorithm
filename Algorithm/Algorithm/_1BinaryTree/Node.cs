using System;

namespace Algorithm._1BinaryTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        public Node<T> Parent { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString() => Data.ToString();
    }
}