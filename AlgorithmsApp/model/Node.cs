using System;

namespace AlgorithmsApp
{
    public class Node<T>
    {
        private T _data;
        private Node<T>[] _neig;

        public Node(T data, Node<T>[] neigh = null)
        {
            _data = data;
            _neig = neigh;
        }
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node<T>[] Neig
        {
            get { return _neig; }
            set { _neig = value; }
        }
    }
}
