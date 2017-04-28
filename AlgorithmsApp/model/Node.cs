using System;

namespace AlgorithmsApp
{
    public class Node<T>
    {
        private T _data;
        private Node<T>[] _neighbours;

        public Node(T data, Node<T>[] neighbours = null)
        {
            _data = data;
            _neighbours = neighbours;
        }
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node<T>[] Neighbours
        {
            get { return _neighbours; }
            set { _neighbours = value; }
        }
    }
}
