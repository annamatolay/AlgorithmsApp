using System;

namespace AlgorithmsApp
{
    public class Tree<T>
    {
        private Node<int>[] _nodes;
        private int _level;

        public Tree(int level)
        {
//            _nodes = nodes;
            _level = level;
        }

        public Node<int>[] Nodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }

        public bool init()
        {
            _nodes = new Node<int>[_level];
            for (int i = 0; i < _nodes.Length; i++)
            {
                _nodes[i].Data = Convert.ToInt32(Console.ReadLine());
            }
            return true;
        }
    }
}